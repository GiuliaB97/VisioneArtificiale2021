using Emgu.CV;
using Emgu.CV.Structure;

namespace _02_CBIRSystem
{
    public class ColorFeatureExtractor
    {
        private int binCount = 20;
        public ColorFeatureExtractor()
        {

        }

        public float[] ComputeDescriptor(Image<Bgr, byte> img)
        {
            //var imgYCbCr = img.Convert<Ycc, byte>();
            //float[] bgrHist = new float[binCount * 2];
            //float[] histR = ComputeHistogram(imgYCbCr[1]);
            //float[] histB = ComputeHistogram(imgYCbCr[2]);
            //int pixelCount = img.Width * img.Height;
            //for (int i = 0; i < binCount; i++)
            //{
            //    bgrHist[i] = histR[i] / pixelCount;
            //    bgrHist[i + binCount] = histB[i] / pixelCount;
            //}
            //return bgrHist;

            // ***********Versione con istogramma 2D * ***********
            var imgYCbCr = img.Convert<Ycc, byte>();
            var range = new RangeF(0, 255);
            DenseHistogram hist = new DenseHistogram(new int[] { binCount, binCount }, new RangeF[] { range, range });
            hist.Calculate<byte>(new Image<Gray, byte>[] { imgYCbCr[1], imgYCbCr[2] }, true, null);
            int pixelCount = img.Width * img.Height;
            var h = hist.GetBinValues();
            for (int i = 0; i < h.Length; i++)
            {
                h[i] = h[i] / pixelCount;
            }
            return h;
            //***************************************************
        }

        private float[] ComputeHistogram(Image<Gray, byte> img)
        {
            DenseHistogram hist = new DenseHistogram(binCount, new RangeF(0, 255));
            hist.Calculate<byte>(new Image<Gray, byte>[] { img[0] }, false, null);
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
