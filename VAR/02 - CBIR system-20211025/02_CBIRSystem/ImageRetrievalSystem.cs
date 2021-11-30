using Emgu.CV;
using Emgu.CV.Features2D;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CBIRSystem
{
    public class ImageRetrievalSystem
    {
        private BoWFeatureExtractor bowExtractor = new BoWFeatureExtractor();
        private ColorFeatureExtractor colorExtractor = new ColorFeatureExtractor();
        private ShapeFeatureExtractor shapeExtractor = new ShapeFeatureExtractor();
        private string[] dbImagesFilePaths;
        private Image<Bgr, byte>[] dbImages;
        private VectorOfMat dbBoWDescriptors;
        private float[][] dbColorDescriptors;
        private Image<Gray,byte>[] dbShapeDescriptors;
        private double defaultWBow = 1.0;
        private double defaultWColor = 0.5;
        private double defaultWShape = 0.5;

        public ImageRetrievalSystem()
        {
            WeightBoW = defaultWBow;
            WeightColor = defaultWColor;
            WeightShape = defaultWShape;
        }
        public double WeightBoW { get; set; }
        public double WeightColor { get; set; }
        public double WeightShape { get; set; }

        public void Train(string[] dbImageFilePaths)
        {
            this.dbImagesFilePaths = dbImageFilePaths;
            dbImages = new Image<Bgr, byte>[dbImageFilePaths.Length];
            for (int i = 0; i < dbImages.Length; i++)
            {
                dbImages[i] = new Image<Bgr, byte>(dbImagesFilePaths[i]);
            }
            dbShapeDescriptors = shapeExtractor.ComputeDescriptors(dbImages);
            dbColorDescriptors = colorExtractor.ComputeDescriptors(dbImages);
            bowExtractor.Train(dbImages);
            dbBoWDescriptors = bowExtractor.ComputeDescriptors(dbImages);

        }

        public string[] Search(Image<Bgr, byte> query, int imagesToRetrieve)
        {
            string[] res = null;
            if (bowExtractor != null)
            {
                var queryDescriptorBow = bowExtractor.ComputeDescriptor(query);
                var resBow = FindNearestImages(queryDescriptorBow, imagesToRetrieve, dbBoWDescriptors);
                var queryDescriptorColor = colorExtractor.ComputeDescriptor(query);
                var resColor = FindNearestImagesColor(queryDescriptorColor, imagesToRetrieve, dbColorDescriptors);
                var queryDescriptorShape = shapeExtractor.ComputeDescriptor(query.Convert<Gray, byte>());
                var resShape = FindNearestImagesShape(queryDescriptorShape, imagesToRetrieve, dbShapeDescriptors);
                res = BordaCount(resBow, resColor, resShape, imagesToRetrieve);
            }
            return res;
        }

        private string[] FindNearestImagesShape(Image<Gray, byte> queryDescriptorShape, int imagesToRetrieve, Image<Gray, byte>[] dbShapeDescriptors)
        {
            double[] distances = new double[dbShapeDescriptors.Length];
            int[] idx = new int[distances.Length];

            for (int i = 0; i < dbShapeDescriptors.Length; i++)
            {
                distances[i] = (queryDescriptorShape.AbsDiff(dbShapeDescriptors[i]).GetSum()).Intensity;
                idx[i] = i;
            }
            Array.Sort(distances, idx);
            var res = new string[imagesToRetrieve];
            for (int i = 0; i < imagesToRetrieve; i++)
            {
                res[i] = dbImagesFilePaths[idx[i]];
            }
            return res;
        }

        private string[] BordaCount(string[] resBow, string[] resColor, string[] resShape, int imagesToRetrieve)
        {
            var res = new string[imagesToRetrieve];
            Dictionary<string, double> results = new Dictionary<string, double>(imagesToRetrieve);
            if (WeightBoW > 0.0)
            {
                results = AddResults(results, resBow, WeightBoW);
            }
            if (WeightColor > 0.0)
            {
                results = AddResults(results, resColor, WeightColor);
            }
            if (WeightShape > 0.0)
            {
                results = AddResults(results, resShape, WeightShape);
            }
            var bestImages = (from r in results
                         orderby r.Value descending
                         select r).Take(imagesToRetrieve);
            var bestImagesArray = bestImages.ToArray();
            for (int i = 0; i < imagesToRetrieve; i++)
            {
                res[i] = bestImagesArray[i].Key;
            }
            return res;
        }

        private Dictionary<string, double> AddResults(Dictionary<string, double> results, string[] resImgList, double weight)
        {
            for (int i = 0; i < resImgList.Length; i++)
            {
                double score = weight * (resImgList.Length - i);
                double v;
                if (results.TryGetValue(resImgList[i], out v))
                {
                    results[resImgList[i]] = v + score;
                }
                else
                {
                    results.Add(resImgList[i], score);
                }
            }
            return results;
        }

        private string[] FindNearestImages(Mat queryDescriptor, int imagesToRetrieve, VectorOfMat dbDescriptors)
        {
            double[] distances = new double[dbDescriptors.Size];
            int[] idx = new int[distances.Length];

            for (int i = 0; i < dbDescriptors.Size; i++)
            {
                distances[i] = CvInvoke.Norm(queryDescriptor, dbDescriptors[i], Emgu.CV.CvEnum.NormType.L2);
                idx[i] = i;
            }
            Array.Sort(distances, idx);
            var res = new string[imagesToRetrieve];
            for (int i = 0; i < imagesToRetrieve; i++)
            {
                res[i] = dbImagesFilePaths[idx[i]];
            }
            return res;
        }

        private string[] FindNearestImagesColor(float[] queryDescriptor, int imagesToRetrieve, float[][] dbDescriptors)
        {
            double[] distances = new double[dbDescriptors.Length];
            int[] idx = new int[distances.Length];

            for (int i = 0; i < dbDescriptors.Length; i++)
            {
                float d = 0;
                for (int j = 0; j < dbColorDescriptors[i].Length; j++)
                {
                    var diff = queryDescriptor[j] - dbColorDescriptors[i][j];
                    d += diff * diff;
                }
                distances[i] = d;
                idx[i] = i;
            }
            Array.Sort(distances, idx);
            var res = new string[imagesToRetrieve];
            for (int i = 0; i < imagesToRetrieve; i++)
            {
                res[i] = dbImagesFilePaths[idx[i]];
            }
            return res;
        }
    }
}
