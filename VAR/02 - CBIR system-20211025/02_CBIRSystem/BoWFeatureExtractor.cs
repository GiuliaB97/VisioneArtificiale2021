using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Features2D;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.CV.XFeatures2D;

namespace _02_CBIRSystem
{
    public class BoWFeatureExtractor
    {
        public enum FeatureDetectorType { SIFT, SURF };
        private FeatureDetectorType defaultFeatureDetectorType = FeatureDetectorType.SIFT;
        private int defaultWordCount = 100;

        public FeatureDetectorType FeatureDetector { get; set; }
        public int WordCount { get; set; }

        private BOWImgDescriptorExtractor bowDescriptorExtractor;
        private Feature2D featureDetector;
        private BFMatcher matcher;

        public BoWFeatureExtractor()
        {
            FeatureDetector = defaultFeatureDetectorType;
            WordCount = defaultWordCount;
        }

        public BoWFeatureExtractor(FeatureDetectorType featureDetectorType, int wordCount)
        {
            FeatureDetector = featureDetectorType;
            WordCount = wordCount;
        }

        public void Train(Image<Bgr, byte>[] images)
        {
            switch (FeatureDetector)
            {
                case FeatureDetectorType.SIFT:
                    featureDetector = new SIFT();
                    break;
                case FeatureDetectorType.SURF:
                    featureDetector = new SURF(500);
                    break;
                default:
                    break;
            }
            bowDescriptorExtractor = new BOWImgDescriptorExtractor(featureDetector, matcher = new BFMatcher(DistanceType.L2));
            BOWKMeansTrainer bowTrainer = new BOWKMeansTrainer(WordCount, new MCvTermCriteria(10, 0.01), 3, KMeansInitType.PPCenters);
            {
                VectorOfKeyPoint modelKeyPoints = new VectorOfKeyPoint();
                Mat modelDescriptors = new Mat();
                foreach (var img in images)
                {
                    featureDetector.DetectAndCompute(img, null, modelKeyPoints, modelDescriptors, false);
                    //Add the extracted BoW modelDescriptors into BOW trainer
                    bowTrainer.Add(modelDescriptors);
                }
                Mat vocabulary = new Mat();
                bowTrainer.Cluster(vocabulary);
                bowDescriptorExtractor.SetVocabulary(vocabulary);
            }
        }

        public Mat ComputeDescriptor(Image<Bgr, byte> image)
        {
            Mat descriptors = new Mat();
            VectorOfKeyPoint kpts = new VectorOfKeyPoint();
            {
                featureDetector.DetectRaw(image, kpts);
                bowDescriptorExtractor.Compute(image, kpts, descriptors);
            }
            return descriptors;
        }

        public VectorOfMat ComputeDescriptors(Image<Bgr, byte>[] images)
        {
            var res = new Mat[images.Length];
            for (int i = 0; i < images.Length; i++)
            {
                res[i] = ComputeDescriptor(images[i]);
            }
            return new VectorOfMat(res);
        }
    }
}
