using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CBIRSystem
{
    public class ShapeFeatureExtractor
    {
        public ShapeFeatureExtractor()
        {

        }

        public Image<Gray, byte>[] ComputeDescriptors(Image<Bgr, byte>[] images)
        {
            var res = new Image<Gray, byte>[images.Length];
            for (int i = 0; i < images.Length; i++)
            {
                res[i] = ComputeDescriptor(images[i].Convert<Gray, byte>());
            }
            return res;
        }

        public Image<Gray, byte> ComputeDescriptor(Image<Gray, byte> img)
        {
            var gx = img.Sobel(1, 0, 3);
            var gy = img.Sobel(0, 1, 3);

            var gMod = new Image<Gray, float>(img.Width, img.Height);
            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    var grad = Math.Sqrt(gx[y, x].Intensity * gx[y, x].Intensity + gy[y, x].Intensity * gy[y, x].Intensity);
                    gMod[y, x] = new Gray(grad);
                }
            }
            var gModBinary = gMod.Resize(120, 80, Emgu.CV.CvEnum.Inter.Linear).ThresholdBinary(new Gray(200), new Gray(255)).Convert<Gray, byte>();
            var gModFinal = gModBinary.Dilate(3).Erode(3);
            return gModFinal;
        }
    }
}
