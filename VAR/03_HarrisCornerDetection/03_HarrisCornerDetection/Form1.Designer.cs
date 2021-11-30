namespace _03_HarrisCornerDetection
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imageBoxResult = new Emgu.CV.UI.ImageBox();
            this.imageBoxInputImage = new Emgu.CV.UI.ImageBox();
            this.imageBoxCornernessMap = new Emgu.CV.UI.ImageBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDetect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownSigma = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownR = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFilterSize = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCornernessThr = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAlfa = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxInputImagePath = new System.Windows.Forms.TextBox();
            this.backgroundWorkerDetection = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxInputImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxCornernessMap)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilterSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCornernessThr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlfa)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1284, 603);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.imageBoxResult, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.imageBoxInputImage, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.imageBoxCornernessMap, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 78);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1278, 522);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // imageBoxResult
            // 
            this.imageBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBoxResult.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.PanAndZoom;
            this.imageBoxResult.Location = new System.Drawing.Point(429, 3);
            this.imageBoxResult.Name = "imageBoxResult";
            this.imageBoxResult.Size = new System.Drawing.Size(420, 516);
            this.imageBoxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBoxResult.TabIndex = 8;
            this.imageBoxResult.TabStop = false;
            this.imageBoxResult.Paint += new System.Windows.Forms.PaintEventHandler(this.imageBoxResult_Paint);
            // 
            // imageBoxInputImage
            // 
            this.imageBoxInputImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxInputImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBoxInputImage.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.PanAndZoom;
            this.imageBoxInputImage.Location = new System.Drawing.Point(3, 3);
            this.imageBoxInputImage.Name = "imageBoxInputImage";
            this.imageBoxInputImage.Size = new System.Drawing.Size(420, 516);
            this.imageBoxInputImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBoxInputImage.TabIndex = 2;
            this.imageBoxInputImage.TabStop = false;
            // 
            // imageBoxCornernessMap
            // 
            this.imageBoxCornernessMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxCornernessMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBoxCornernessMap.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.PanAndZoom;
            this.imageBoxCornernessMap.Location = new System.Drawing.Point(855, 3);
            this.imageBoxCornernessMap.Name = "imageBoxCornernessMap";
            this.imageBoxCornernessMap.Size = new System.Drawing.Size(420, 516);
            this.imageBoxCornernessMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBoxCornernessMap.TabIndex = 2;
            this.imageBoxCornernessMap.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDetect);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.buttonBrowse);
            this.panel1.Controls.Add(this.textBoxInputImagePath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 69);
            this.panel1.TabIndex = 0;
            // 
            // buttonDetect
            // 
            this.buttonDetect.Location = new System.Drawing.Point(297, 34);
            this.buttonDetect.Name = "buttonDetect";
            this.buttonDetect.Size = new System.Drawing.Size(75, 23);
            this.buttonDetect.TabIndex = 3;
            this.buttonDetect.Text = "Detect";
            this.buttonDetect.UseVisualStyleBackColor = true;
            this.buttonDetect.Click += new System.EventHandler(this.buttonDetect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownSigma);
            this.groupBox1.Controls.Add(this.numericUpDownR);
            this.groupBox1.Controls.Add(this.numericUpDownFilterSize);
            this.groupBox1.Controls.Add(this.numericUpDownCornernessThr);
            this.groupBox1.Controls.Add(this.numericUpDownAlfa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(671, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Params";
            // 
            // numericUpDownSigma
            // 
            this.numericUpDownSigma.DecimalPlaces = 1;
            this.numericUpDownSigma.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownSigma.Location = new System.Drawing.Point(440, 22);
            this.numericUpDownSigma.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownSigma.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownSigma.Name = "numericUpDownSigma";
            this.numericUpDownSigma.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownSigma.TabIndex = 9;
            this.numericUpDownSigma.Value = new decimal(new int[] {
            14,
            0,
            0,
            65536});
            // 
            // numericUpDownR
            // 
            this.numericUpDownR.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownR.Location = new System.Drawing.Point(522, 22);
            this.numericUpDownR.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownR.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownR.Name = "numericUpDownR";
            this.numericUpDownR.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownR.TabIndex = 8;
            this.numericUpDownR.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numericUpDownFilterSize
            // 
            this.numericUpDownFilterSize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownFilterSize.Location = new System.Drawing.Point(338, 22);
            this.numericUpDownFilterSize.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownFilterSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownFilterSize.Name = "numericUpDownFilterSize";
            this.numericUpDownFilterSize.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownFilterSize.TabIndex = 7;
            this.numericUpDownFilterSize.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // numericUpDownCornernessThr
            // 
            this.numericUpDownCornernessThr.Location = new System.Drawing.Point(199, 22);
            this.numericUpDownCornernessThr.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownCornernessThr.Name = "numericUpDownCornernessThr";
            this.numericUpDownCornernessThr.Size = new System.Drawing.Size(72, 20);
            this.numericUpDownCornernessThr.TabIndex = 6;
            this.numericUpDownCornernessThr.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // numericUpDownAlfa
            // 
            this.numericUpDownAlfa.DecimalPlaces = 2;
            this.numericUpDownAlfa.Increment = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.numericUpDownAlfa.Location = new System.Drawing.Point(42, 22);
            this.numericUpDownAlfa.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            131072});
            this.numericUpDownAlfa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownAlfa.Name = "numericUpDownAlfa";
            this.numericUpDownAlfa.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownAlfa.TabIndex = 5;
            this.numericUpDownAlfa.Value = new decimal(new int[] {
            4,
            0,
            0,
            131072});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sigma:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "R:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Filter size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cornerness thr:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alfa:";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(590, 5);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxInputImagePath
            // 
            this.textBoxInputImagePath.Location = new System.Drawing.Point(4, 8);
            this.textBoxInputImagePath.Name = "textBoxInputImagePath";
            this.textBoxInputImagePath.Size = new System.Drawing.Size(580, 20);
            this.textBoxInputImagePath.TabIndex = 1;
            // 
            // backgroundWorkerDetection
            // 
            this.backgroundWorkerDetection.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerDetection_DoWork);
            this.backgroundWorkerDetection.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerDetection_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 603);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxInputImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxCornernessMap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilterSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCornernessThr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlfa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxInputImagePath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDetect;
        private Emgu.CV.UI.ImageBox imageBoxInputImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownSigma;
        private System.Windows.Forms.NumericUpDown numericUpDownR;
        private System.Windows.Forms.NumericUpDown numericUpDownFilterSize;
        private System.Windows.Forms.NumericUpDown numericUpDownCornernessThr;
        private System.Windows.Forms.NumericUpDown numericUpDownAlfa;
        private Emgu.CV.UI.ImageBox imageBoxResult;
        private System.ComponentModel.BackgroundWorker backgroundWorkerDetection;
        private Emgu.CV.UI.ImageBox imageBoxCornernessMap;
    }
}

