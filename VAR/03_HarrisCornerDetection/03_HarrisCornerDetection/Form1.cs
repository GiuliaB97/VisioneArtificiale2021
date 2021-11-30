using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_HarrisCornerDetection
{
    public partial class Form1 : Form
    {
        private Point[] corners = null;
        private Image<Bgr, byte> inputImage = null;
        private HarrisCornerDetector detector = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                corners = null;
                textBoxInputImagePath.Text = dlg.FileName;
                inputImage = new Image<Bgr, byte>(dlg.FileName);
                imageBoxInputImage.Image = inputImage;
                imageBoxCornernessMap.Image = null;
                imageBoxResult.Image = null;
            }
        }

        private void buttonDetect_Click(object sender, EventArgs e)
        {
            if (imageBoxInputImage.Image != null)
            {
                imageBoxResult.Image = null; ;
                imageBoxCornernessMap.Image = null;
                Update();
                backgroundWorkerDetection.RunWorkerAsync();
            }
        }

        private void imageBoxResult_Paint(object sender, PaintEventArgs e)
        {
            if (inputImage != null && corners != null)
            {
                var tempImage = inputImage.Clone();
                for (int i = 0; i < corners.Length; i++)
                {
                    tempImage.Draw(new CircleF(corners[i], 3), new Bgr(Color.Red), 1);
                }
                imageBoxResult.Image = tempImage;
            }
        }

        private void backgroundWorkerDetection_DoWork(object sender, DoWorkEventArgs e)
        {
            var alfa = (float)numericUpDownAlfa.Value;
            var cornernessThr = (int)numericUpDownCornernessThr.Value;
            var filterSize = (int)numericUpDownFilterSize.Value;
            var r = (int)numericUpDownR.Value;
            var sigma = (float)numericUpDownSigma.Value;
            detector = new HarrisCornerDetector(r, alfa, cornernessThr, sigma, filterSize);
            corners = detector.DetectCorners(inputImage.Convert<Gray, byte>());
        }

        private void backgroundWorkerDetection_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            imageBoxResult.Image = inputImage;
            imageBoxCornernessMap.Image = detector.CornernessMap;
            Update();
        }
        
    }
}
