using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV.Util;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace _02_CBIRSystem
{
    public partial class Form1 : Form
    {
        ImageRetrievalSystem imageRet = null;
       
        string[] queryResults = null;
        int imagesToRetrieve = 12;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    textBoxDBFolder.Text = dlg.SelectedPath;
                }
            }
        }

        private void buttonExtractFeatures_Click(object sender, EventArgs e)
        {
            if (textBoxDBFolder.Text != null && Directory.Exists(textBoxDBFolder.Text))
            {
                buttonExtractFeatures.Enabled = false;
                buttonSearch.Enabled = false;
                backgroundWorkerTraining.RunWorkerAsync();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxDetector.SelectedIndex = 0;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (imageRet != null)
            {
                imageRet.WeightBoW = (float)numericUpDownWBoW.Value;
                imageRet.WeightColor = (float)numericUpDownWColor.Value;
                imageRet.WeightShape = (float)numericUpDownWShape.Value;

                if (!backgroundWorkerSearch.IsBusy)
                {
                    backgroundWorkerSearch.RunWorkerAsync();
                }
                else
                {
                    backgroundWorkerSearch.CancelAsync();
                }
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = dlg.FileName;
                    imageBoxQuery.Image = new Image<Bgr, byte>(textBox1.Text);
                    ShowResults(null);
                }
            }
        }

        private void backgroundWorkerTraining_DoWork(object sender, DoWorkEventArgs e)
        {
            var imageList = Directory.GetFiles(textBoxDBFolder.Text, "*.jpg");
            imageRet = new ImageRetrievalSystem();
            imageRet.Train(imageList);
        }

        Image<Bgr, byte> query;

        private void backgroundWorkerSearch_DoWork(object sender, DoWorkEventArgs e)
        {
            query = (Image<Bgr, byte>)imageBoxQuery.Image;
            queryResults = imageRet.Search(query, imagesToRetrieve);
        }

        private void backgroundWorkerSearch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ShowResults(queryResults);
        }

        private void ShowResults(string[] queryResults)
        {
            if (queryResults != null)
            {
                imageBox1.Image = new Image<Bgr, byte>(queryResults[0]);
                imageBox2.Image = new Image<Bgr, byte>(queryResults[1]);
                imageBox3.Image = new Image<Bgr, byte>(queryResults[2]);
                imageBox4.Image = new Image<Bgr, byte>(queryResults[3]);
                imageBox5.Image = new Image<Bgr, byte>(queryResults[4]);
                imageBox6.Image = new Image<Bgr, byte>(queryResults[5]);
                imageBox7.Image = new Image<Bgr, byte>(queryResults[6]);
                imageBox8.Image = new Image<Bgr, byte>(queryResults[7]);
                imageBox9.Image = new Image<Bgr, byte>(queryResults[8]);
                imageBox10.Image = new Image<Bgr, byte>(queryResults[9]);
                imageBox11.Image = new Image<Bgr, byte>(queryResults[10]);
                imageBox12.Image = new Image<Bgr, byte>(queryResults[11]);
            }
            else
            {
                imageBox1.Image = null;
                imageBox2.Image = null;
                imageBox3.Image = null;
                imageBox4.Image = null;
                imageBox5.Image = null;
                imageBox6.Image = null;
                imageBox7.Image = null;
                imageBox8.Image = null;
                imageBox9.Image = null;
                imageBox10.Image = null;
                imageBox11.Image = null;
                imageBox12.Image = null;
            }
        }

        private void backgroundWorkerTraining_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            buttonSearch.Enabled = true;
            buttonExtractFeatures.Enabled = true;
        }
    }
}
