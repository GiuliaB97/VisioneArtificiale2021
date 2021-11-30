using Emgu.CV;
using Emgu.CV.ML;
using Emgu.CV.ML.MlEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_TextureClassification
{
    public class TextureClassifier
    {
        private KNearest knn;
        private double[] minVals, maxVals;
        public int K { get; set; }  // K value for the KNN classifier
        private int defaultK = 1;

        public TextureClassifier()
        {
            K = defaultK;
        }
        public TextureClassifier(int k)
        {
            K = k;
        }

        public void Train(Image<Gray, byte>[] images, int[] trainingLabels, out Matrix<double>[] avgCoOccurrMatrices)
        {
            Matrix<float> tData;
            Matrix<int> tLab;

            // Feature extraction
            var trainingImages = SplitImagesPerClass(images, trainingLabels);
            Matrix<double>[][] coOccurrMatrices = ComputeUnorientedCoOccurrenceMatrices(trainingImages);
            avgCoOccurrMatrices = ComputeAverageCoOccurrenceMatricesPerClass(coOccurrMatrices);
            ExtractFeatures(coOccurrMatrices, out tData, out tLab);
            ComputeNormalizationFactors(tData);
            NormalizeData(tData);
            // KNN Classifier training
            knn = new KNearest();
            knn.DefaultK = K;
            knn.Train(new TrainData(tData, DataLayoutType.RowSample, tLab));
        }

        public int Test(Image<Gray, byte> testImg, out Matrix<double> testCoOccurrMatrix)
        {
            // Classification of a single test image
            testCoOccurrMatrix = ComputeUnorientedCoOccurrenceMatrix(testImg);
            var fv = ExtractFeatureVector(testCoOccurrMatrix);
            Matrix<float> sample = new Matrix<float>(1, fv.Length);
            for (int i = 0; i < fv.Length; i++)
            {
                sample[0, i] = fv[i];
            }
            NormalizeData(sample);
            return (int)knn.Predict(sample.GetRow(0));
        }

        private Matrix<double>[][] ComputeUnorientedCoOccurrenceMatrices(Image<Gray, byte>[][] trainingImages)
        {
            var res = new Matrix<double>[trainingImages.GetLength(0)][];
            for (int c = 0; c < trainingImages.GetLength(0); c++)
            {
                res[c] = new Matrix<double>[trainingImages[c].Length];
                for (int i = 0; i < trainingImages[c].Length; i++)
                {
                    res[c][i] = ComputeUnorientedCoOccurrenceMatrix(trainingImages[c][i]);
                }
            }
            return res;
        }

        private Matrix<double> ComputeUnorientedCoOccurrenceMatrix(Image<Gray, byte> img)
        {
            // Computation of the unoriented co-occurrence matrix (average of the four oriented matrices)
            throw new NotImplementedException();
        }

        Matrix<double> ComputeCoOccurrenceMatrix(Image<Gray, byte> img, int dx, int dy)
        {
            // Computation of the co-occurrence matrix for direction dx, dy
            throw new NotImplementedException();
        }

        private Matrix<double>[] ComputeAverageCoOccurrenceMatricesPerClass(Matrix<double>[][] coOccurrMatrices)
        {
            var res = new Matrix<double>[coOccurrMatrices.GetLength(0)];
            for (int c = 0; c < coOccurrMatrices.GetLength(0); c++)
            {
                res[c] = new Matrix<double>(256, 256);
                for (int i = 0; i < coOccurrMatrices[c].Length; i++)
                {
                    res[c] = res[c].Add(coOccurrMatrices[c][i]);
                }
                res[c] /= coOccurrMatrices[c].Length;
            }
            return res;
        }

        private void NormalizeData(Matrix<float> tData)
        {
            // Normalize feature vectors according to the range of values observed during training
            double[] ranges = new double[minVals.Length];
            for (int i = 0; i < ranges.Length; i++)
            {
                ranges[i] = maxVals[i] - minVals[i];
            }
            for (int r = 0; r < tData.Rows; r++)
            {
                for (int c = 0; c < tData.Cols; c++)
                {
                    tData[r, c] = (float)((tData[r, c] - minVals[c]) / ranges[c]);
                }
            }
        }

        private void ComputeNormalizationFactors(Matrix<float> tData)
        {
            // Feature-wise computation of the minimum and maximum values for feature normalization
            minVals = new double[tData.Cols];
            maxVals = new double[tData.Cols];
            for (int r = 0; r < tData.Rows; r++)
            {
                for (int c = 0; c < tData.Cols; c++)
                {
                    minVals[c] = Math.Min(minVals[c], tData[r, c]);
                    maxVals[c] = Math.Max(maxVals[c], tData[r, c]);
                }
            }
        }

        private void ExtractFeatures(Matrix<double>[][] coOccurrMatrices, out Matrix<float> tData, out Matrix<int> tLab)
        {
            var tDataCount = 0;
            for (int c = 0; c < coOccurrMatrices.GetLength(0); c++)
            {
                tDataCount += coOccurrMatrices[c].Length;
            }
            tData = new Matrix<float>(tDataCount, 4);
            tLab = new Matrix<int>(tDataCount, 1);
            int idx = 0;
            for (int c = 0; c < coOccurrMatrices.GetLength(0); c++)
            {
                for (int i = 0; i < coOccurrMatrices[c].Length; i++)
                {
                    var m = coOccurrMatrices[c][i];
                    var v = ExtractFeatureVector(m);
                    for (int j = 0; j < v.Length; j++)
                    {
                        tData[idx, j] = v[j];
                    }
                    tLab[idx++, 0] = c;
                }
            }
        }

        float[] ExtractFeatureVector(Matrix<double> m)
        {
            // Computation of the 4-dimensional feature vector from the unoriented co-occurrence matrix m
            throw new NotImplementedException();
        }
        private double ComputeHomogeneity(Matrix<double> matrix)
        {
            throw new NotImplementedException();
        }

        private double ComputeContrast(Matrix<double> matrix)
        {
            throw new NotImplementedException();
        }

        private double ComputeEntropy(Matrix<double> matrix)
        {
            throw new NotImplementedException();
        }

        private double ComputeEnergy(Matrix<double> matrix)
        {
            throw new NotImplementedException();
        }

        private Image<Gray, byte>[][] SplitImagesPerClass(Image<Gray, byte>[] images, int[] trainingLabels)
        {
            var classCount = trainingLabels.Max() + 1;
            List<Image<Gray, byte>>[] imgPerClassList = new List<Image<Gray, byte>>[classCount];
            for (int i = 0; i < classCount; i++)
            {
                imgPerClassList[i] = new List<Image<Gray, byte>>();
            }
            for (int i = 0; i < trainingLabels.Length; i++)
            {
                imgPerClassList[trainingLabels[i]].Add(images[i]);
            }
            var res = new Image<Gray, byte>[classCount][];
            for (int i = 0; i < classCount; i++)
            {
                res[i] = imgPerClassList[i].ToArray();
            }
            return res;
        }
    }
}
