using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System;

namespace _00_Brightness
{
    class Program
    {
        static void Main(string[] args)
        {
            var imgPath = @"...";
            var img = new Image<Gray, Byte>(imgPath);
            int var = -40;

            //Variazione luminosità
            var res = new Image<Gray, Byte>(img.Width, img.Height);
            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    res[y, x] = new Gray(img[y, x].Intensity + var);
                }
            }

            ImageViewer.Show(img, "Immagine originale");
            ImageViewer.Show(res, "Immagine risultato");

            var resEmgu = img.Add(new Gray(var));

            ImageViewer.Show(resEmgu, "Immagine risultato Emgu");
        }
    }
}
