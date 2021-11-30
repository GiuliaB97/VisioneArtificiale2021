using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_HarrisCornerDetection
{
    public class HarrisCornerDetector
    {
        private const int defaultR = 3;
        private const double defaultAlfa = 0.04;
        private const int defaultCornernessThr = 1000000;
        private const double defaultSigma = 1.4;
        private const int defaultFilterSize = 7;

        public int R { get; set; }
        public double Alfa { get; set; }
        public double Sigma { get; set; }
        public int CornernessThreshold { get; set; }
        public int FilterSize { get; set; }
        public HarrisCornerDetector()
        {
            R = defaultR;
            Alfa = defaultAlfa;
            CornernessThreshold = defaultCornernessThr;
            Sigma = defaultSigma;
            FilterSize = defaultFilterSize;
        }

        public Image<Gray, double> CornernessMap = null;
        public HarrisCornerDetector(int r, double alfa, int cornernessThr, double sigma, int filterSize)
        {
            R = r;
            Alfa = alfa;
            CornernessThreshold = cornernessThr;
            Sigma = sigma;
            FilterSize = filterSize;
        }

        public Point[] DetectCorners(Image<Gray, byte> image)
        {

            // Gradient computation with Sobel 3x3
            var gx = image.Sobel(1, 0, 3);
            var gy = image.Sobel(0, 1, 3);

            var gx2 = new Image<Gray, float>(image.Width, image.Height);
            var gy2 = new Image<Gray, float>(image.Width, image.Height);
            var gxy = new Image<Gray, float>(image.Width, image.Height);

            gx2 = gx.Mul(gx);
            gy2 = gy.Mul(gy);
            gxy = gx.Mul(gy);

            // Gaussian smoothing
            gx2 = gx2.SmoothGaussian(FilterSize, FilterSize, Sigma, Sigma);
            gy2 = gy2.SmoothGaussian(FilterSize, FilterSize, Sigma, Sigma);
            gxy = gxy.SmoothGaussian(FilterSize, FilterSize, Sigma, Sigma);

            // Compute cornerness
            CornernessMap = new Image<Gray, double>(gxy.Width, gxy.Height);
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    var m = new Matrix<double>(2, 2);
                    m[0, 0] = gx2.Data[y, x, 0];
                    m[0, 1] = m[1, 0] = gxy.Data[y, x, 0];
                    m[1, 1] = gy2.Data[y, x, 0];

                    var tr = m[0, 0] + m[1, 1];
                    var det = m[0, 0] * m[1, 1] - m[1, 0] * m[0, 1];
                    var val = det - Alfa * tr * tr;
                    if (val > CornernessThreshold)
                        CornernessMap.Data[y, x, 0] = val;
                }
            }

            // Non-maxima suppression
            var maxY = CornernessMap.Height - R;
            var maxX = CornernessMap.Width - R;

            var pointList = new List<Point>();

            for (int y = R; y < maxY; y++)
            {
                for (int x = R; x < maxX; x++)
                {
                    double currentValue = CornernessMap[y, x].Intensity;
                    if (currentValue != 0)
                    {
                        for (int i = -R; (i <= R); i++)
                        {
                            // for each windows' pixel
                            for (int j = -R; j <= R; j++)
                            {
                                if (CornernessMap[y + i, x + j].Intensity > currentValue)
                                {
                                    currentValue = 0;
                                    break;
                                }
                            }
                        }
                    }

                    // check if this point is really interesting
                    if (currentValue != 0)
                    {
                        pointList.Add(new Point(x, y));
                    }
                }
            }
            return pointList.ToArray();
        }
    }
}
