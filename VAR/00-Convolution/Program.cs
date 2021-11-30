using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System.Drawing;

namespace _00_Convolution
{
    class Program
    {

        static void Main(string[] args)
        {
            var imgPath = @"...";
            var img = new Image<Gray, byte>(imgPath);

            var kernel = new Matrix<float>(new float[,] {{1, 1, 1,1,1},
                                                        {1, 1, 1,1,1},
                                                        {1, 1, 1,1,1},
                                                        {1, 1, 1,1,1},
                                                        {1, 1, 1,1,1}});
            var f = 1.0 / kernel.Sum;

            //var kernel = new Matrix<float>(new float[,] {{-1,-1,-1},
            //                                            {-1, 8,-1},
            //                                            {-1,-1,-1} });
            //var f = 1.0;

            var kernelSize = kernel.Rows; //Ipotizziamo filtri quadrati
            var halfKernelSize = kernelSize / 2;
            int y1 = halfKernelSize;
            int y2 = img.Height - halfKernelSize - 1;
            int x1 = halfKernelSize;
            int x2 = img.Width - halfKernelSize - 1;

            // Convoluzione
            var res = new Image<Gray, float>(img.Width, img.Height);
            for (int y = y1; y <= y2; y++)
            {
                for (int x = x1; x <= x2; x++)
                {
                    var val = 0.0;
                    for (int fy = 0; fy < kernelSize; fy++)
                    {
                        var yImg = y + halfKernelSize - fy;

                        for (int fx = 0; fx < kernelSize; fx++)
                        {
                            var xImg = x + halfKernelSize - fx;

                            val += (double)img[yImg, xImg].Intensity * (double)kernel[fy, fx];
                        }
                    }
                    val *= f;
                    res[y, x] = new Gray(val);
                }
            }

            ImageViewer.Show(img, "Immagine originale");
            ImageViewer.Show(res, "Immagine risultato");

            var kernelEmgu = new ConvolutionKernelF(kernel.Mul(f), new Point(kernel.Width / 2, kernel.Height / 2));
            var resEmgu = img.Convolution(kernelEmgu.Flip(Emgu.CV.CvEnum.FlipType.Horizontal).Flip(Emgu.CV.CvEnum.FlipType.Vertical));

            ImageViewer.Show(resEmgu, "Immagine risultato Emgu");
        }
    }
}
