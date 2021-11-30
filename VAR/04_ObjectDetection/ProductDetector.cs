using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Features2D;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.CV.XFeatures2D;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ObjectDetection
{
    public class ProductCandidate
    {
        public Rectangle Rectangle { get; set; }
        public double Distance { get; set; }

        public ProductCandidate(Rectangle rectangle, double d)
        {
            Rectangle = rectangle;
            Distance = d;
        }
    }

    public class ProductDetector
    {
        public double MinimumScaleFactor { get; set; }
        public double MaximumScaleFactor { get; set; }
        public double ScaleIncrementStep { get; set; }
        public double DistanceThreshold { get; set; }
        public double WindowOverlapPercentage { get; set; }
        public ProductCandidate[] InitialCandidates { get; private set; }
        public ProductCandidate[] FinalCandidates { get; private set; }
        public MKeyPoint[] SamplingPoints { get; private set; }
        public Image<Bgr, byte> InputImage { get; private set; }

        private const double defaultMinimumScaleFactor = 50;
        private const double defaultMaximumScaleFactor = 2.0;
        private const double defaultScaleIncrementStep = 0.5;
        private const double defaultDistanceThreshold = 0.95;
        private const double defaultWindowOverlapPercentage = 0.2;
        private const double histIntersectionThr = 1.1;

        private Feature2D featureDetector = new SURF(500);
        private ColorFeatureExtractor colorExtractor = new ColorFeatureExtractor();

        public void ClassifierFaceDetector()
        {
        }
        private void InitProperties()
        {
            MinimumScaleFactor = defaultMinimumScaleFactor;
            MaximumScaleFactor = defaultMaximumScaleFactor;
            ScaleIncrementStep = defaultScaleIncrementStep;
            DistanceThreshold = defaultDistanceThreshold;
            WindowOverlapPercentage = defaultWindowOverlapPercentage;
        }

        public ProductCandidate[] Detect(Image<Bgr, byte> img, Image<Bgr, byte> productImg)
        {
            InputImage = img;
            FinalCandidates = null;
            var initialCandidates = new List<ProductCandidate>();

            var productImgHist = colorExtractor.ComputeDescriptor(productImg);
            var productImgGray = productImg.Convert<Gray, byte>();

            // Calcolo dei fattori di scala da applicare
            var scaleFactors = new List<double>();
            for (var scale = MinimumScaleFactor; scale <= MaximumScaleFactor; scale += ScaleIncrementStep)
            {
                scaleFactors.Add(scale);
            }

            // Riscalatura immagine di test (in base ai vari scaleFactors)

            // Feature extraction template (calcolo sampling points e descrittori)
            // ................

            // Ricerca su immagine a diverse scale
            for (int sc = 0; sc < scaleFactors.Count; sc++)
            {
                // Finestra mobile sull'immagine riscalata
                // - verifica istogramma
                // - calcolo descrittori locali 
                // - calcolo distanza media descrittori e confronto con soglia
                throw new NotImplementedException();
            }
            InitialCandidates = initialCandidates.ToArray();
            if (InitialCandidates != null)
            {
                FinalCandidates = PostProcessing(initialCandidates, 0.3);
            }
            return FinalCandidates;
        }

        private float ColorHistIntersection(float[] hist1, float[] hist2)
        {
            float intersection = 0;
            for (int j = 0; j < hist1.Length; j++)
            {
                intersection += Math.Min(hist1[j], hist2[j]);
            }
            return intersection;
        }

        private Image<Bgr, byte>[] ComputeTestImageResized(Image<Bgr, byte> testImage, double[] scaleFactors)
        {
            var testImageResized = new Image<Bgr, byte>[scaleFactors.Length];
            var partition = Partitioner.Create(0, scaleFactors.Length);
            Parallel.ForEach(partition, p =>
            {
                for (int i = p.Item1; i < p.Item2; i++)
                {
                    testImageResized[i] = testImage.Resize(scaleFactors[i], Inter.Cubic);
                }
            }
            );
            return testImageResized;
        }

        public VectorOfKeyPoint ComputeSamplingPoints(Image<Gray, byte> img, int spacing, float scale)
        {
            List<MKeyPoint> samplingPoints = new List<MKeyPoint>();
            int pointsPerCol = img.Height / spacing;
            int pointsPerRow = img.Width / spacing;
            int halfDenseSamplingSpacing = spacing / 2;

            int borderX = (img.Width - (pointsPerRow - 1) * spacing) / 2;
            int borderY = (img.Height - (pointsPerCol - 1) * spacing) / 2;

            int posY = borderY;
            for (int y = 0; y < pointsPerCol; y++)
            {
                int posX = (y % 2 == 0 ? borderX : halfDenseSamplingSpacing + borderX);
                for (int x = 0; x < pointsPerRow; x++)
                {
                    if (posX <= img.Width - borderX && posY <= img.Height - borderY && posX >= 0 && posY >= 0)
                    {
                        var p = new MKeyPoint();
                        p.Point = new Point(posX, posY);
                        p.Size = scale;
                        samplingPoints.Add(p);
                        posX += spacing;
                    }
                }
                posY += spacing;
            }
            var keyPoints = new VectorOfKeyPoint(samplingPoints.ToArray());
            return keyPoints;
        }

        private ProductCandidate[] PostProcessing(List<ProductCandidate> detObjects, double percOverlap)
        {
            throw new NotImplementedException();
        }

        private int Overlap(ProductCandidate obj1, ProductCandidate obj2)
        {
            Rectangle r1, r2;
            r1 = obj1.Rectangle;
            r2 = obj2.Rectangle;
            r1.Intersect(r2);
            return r1.Width * r1.Height;
        }

    }
}
