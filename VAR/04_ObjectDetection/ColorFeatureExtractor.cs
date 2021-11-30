using Emgu.CV;
using Emgu.CV.Structure;

namespace _05_ObjectDetection
{
    public class ColorFeatureExtractor
    {
        private int binCount = 20;
        public ColorFeatureExtractor()
        {

        }

        public float[] ComputeDescriptor(Image<Bgr, byte> img)
        {
            var imgYCbCr = img.Convert<Ycc, byte>();
            float[] bgrHist = new float[binCount * 2];
            float[] histR = ComputeHistogram(imgYCbCr[1]);
            float[] histB = ComputeHistogram(imgYCbCr[2]);
            int pixelCount = img.Width * img.Height;
            for (int i = 0; i < binCount; i++)
            {
                bgrHist[i] = histR[i] / pixelCount;
                bgrHist[i + binCount] = histB[i] / pixelCount;
            }
            return bgrHist;
        }

        private float[] ComputeHistogram(Image<Gray, byte> img)
        {
            DenseHistogram hist = new DenseHistogram(binCount, new RangeF(0, 255));
            hist.Calculate<byte>(new Image<Gray, byte>[] { img[0] }, true, null);
            return hist.GetBinValues();
        }

        public float[][] ComputeDescriptors(Image<Bgr, byte>[] images)
        {
            var res = new float[images.Length][];
            for (int i = 0; i < images.Length; i++)
            {
                res[i] = ComputeDescriptor(images[i]);
            }
            return res;
        }
    }
}
