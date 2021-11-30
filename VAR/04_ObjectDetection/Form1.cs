using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_ObjectDetection
{
    public partial class Form1 : Form
    {
        private ProductDetector detector;
        private ProductCandidate[] detectedProducts;
        private Image<Bgr, byte> currentTestImg;
        private Image<Bgr, byte> currentProductImg;
        public Form1()
        {
            InitializeComponent();
            detector = new ProductDetector();
        }

        private void buttonLoadProduct_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = "image files(*.jpg; *.png) | *.jpg; *.png";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    currentProductImg = new Image<Bgr, byte>(dlg.FileName);
                    imageBoxProduct.Image = currentProductImg;
                    textBoxProductName.Text = Path.GetFileName(dlg.FileName);
                    detectedProducts = null;
                    imageBoxTestImage.Image = currentTestImg;
                }
            }
        }

        private void buttonLoadTestImage_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = "image files(*.jpg; *.png) | *.jpg; *.png";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    currentTestImg = new Image<Bgr, byte>(dlg.FileName);
                    imageBoxTestImage.Image = currentTestImg;
                    textBoxTestImagePath.Text = Path.GetFileName(dlg.FileName);
                    detectedProducts = null;
                    imageBoxTestImage.Image = currentTestImg;
                }
            }
        }

        private void buttonDetect_Click(object sender, EventArgs e)
        {
            if (currentProductImg != null && currentTestImg != null)
            {
                Cursor = Cursors.WaitCursor;
                UpdateControlState(false);
                detector.MinimumScaleFactor = (float)numericUpDownMinSCale.Value;
                detector.MaximumScaleFactor = (float)numericUpDownMaxScale.Value;
                detector.ScaleIncrementStep = (float)numericUpDownScaleIncrementStep.Value;
                detector.WindowOverlapPercentage = (float)numericUpDownStepPercentage.Value;
                detector.DistanceThreshold = (float)numericUpDownDistanceThr.Value;
                detectedProducts = null;
                imageBoxTestImage.Image = currentTestImg;
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void UpdateControlState(bool state)
        {
            buttonLoadTestImage.Enabled = state;
            buttonLoadProduct.Enabled = state;
            buttonDetect.Enabled = state;

            numericUpDownMinSCale.Enabled = state;
            numericUpDownMaxScale.Enabled = state;
            numericUpDownScaleIncrementStep.Enabled = state;
            numericUpDownDistanceThr.Enabled = state;
            numericUpDownStepPercentage.Enabled = state;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = detector.Detect((Image<Bgr, byte>)imageBoxTestImage.Image, (Image<Bgr, byte>)imageBoxProduct.Image);
        }
        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            detectedProducts = (ProductCandidate[])e.Result;
            UpdateImages();
            UpdateControlState(true);
            Cursor = Cursors.Default;
        }

        private void UpdateImages()
        {
            imageBoxTestImage.Image = detector.InputImage;
        }

        private void imageBoxTestImage_Paint(object sender, PaintEventArgs e)
        {
            if (currentTestImg != null)
            {
                if (detectedProducts != null)
                {
                    Image<Bgr, byte> img = currentTestImg.Clone();
                    // Initial candidates
                    foreach (var p in detector.InitialCandidates)
                    {
                        img.Draw(p.Rectangle, new Bgr(Color.Red), 1);
                    }

                    // Final candidates
                    foreach (var p in detectedProducts)
                    {
                        img.Draw(p.Rectangle, new Bgr(Color.Green), 3);
                        img.Draw(string.Format("{0:0.00}", p.Distance), new Point(p.Rectangle.Left, p.Rectangle.Bottom), FontFace.HersheySimplex, 0.5, new Bgr(Color.Green), 1, LineType.EightConnected, false);
                    }
                    imageBoxTestImage.Image = img;
                }
                else
                {
                    imageBoxTestImage.Image = currentTestImg.Clone();
                }
            }
        }

        //private void imageBoxProduct_Paint(object sender, PaintEventArgs e)
        //{
        //    if (detectedProducts != null)
        //    {
        //        var img = currentProductImg;
        //        // Initial candidates
        //        foreach (var p in detector.SamplingPoints)
        //        {
        //            img.Draw(new Cross2DF(p.Point, 2, 2), new Bgr(Color.Red), 1);
        //        }
        //        imageBoxProduct.Image = img;
        //    }
        //}
    }
}
