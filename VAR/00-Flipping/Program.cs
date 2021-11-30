using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System.Drawing;

namespace _00_Flipping
{
   
        class Program
        {
            static void Main(string[] args)
            {
                var imgPath = @"...";
                var img = new Image<Bgr, Byte>(imgPath);

                //Flip
                var resHFlip = new Image<Bgr, Byte>(img.Width, img.Height);
                var resVFlip = new Image<Bgr, Byte>(img.Width, img.Height);
                for (int y = 0; y < img.Height; y++)
                {
                    for (int x = 0; x < img.Width; x++)
                    {
                        resHFlip[y, img.Width - x - 1] = img[y, x];
                        resVFlip[img.Height - y - 1, x] = img[y, x];
                    }
                }

                ImageViewer.Show(img, "Immagine originale");
                ImageViewer.Show(resHFlip, "Flip orizzontale");
                ImageViewer.Show(resVFlip, "Flip verticale");

                var resHFlipEmgu = img.Flip(FlipType.Horizontal);
                var resVFlipEmgu = img.Flip(FlipType.Vertical);

                ImageViewer.Show(resHFlipEmgu, "Flip orizzontale Emgu");
                ImageViewer.Show(resVFlipEmgu, "Flip verticale Emgu");
            }
        }
    
}
