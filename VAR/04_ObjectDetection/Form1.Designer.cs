namespace _05_ObjectDetection
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDetect = new System.Windows.Forms.Button();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.buttonLoadProduct = new System.Windows.Forms.Button();
            this.imageBoxProduct = new Emgu.CV.UI.ImageBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownDistanceThr = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStepPercentage = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownScaleIncrementStep = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxScale = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownMinSCale = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.imageBoxTestImage = new Emgu.CV.UI.ImageBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxTestImagePath = new System.Windows.Forms.TextBox();
            this.buttonLoadTestImage = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistanceThr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStepPercentage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScaleIncrementStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinSCale)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxTestImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1046, 652);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.imageBoxProduct, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.78019F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.0031F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.06192F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(203, 646);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDetect);
            this.panel1.Controls.Add(this.textBoxProductName);
            this.panel1.Controls.Add(this.buttonLoadProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 583);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 60);
            this.panel1.TabIndex = 0;
            // 
            // buttonDetect
            // 
            this.buttonDetect.Location = new System.Drawing.Point(103, 6);
            this.buttonDetect.Name = "buttonDetect";
            this.buttonDetect.Size = new System.Drawing.Size(90, 23);
            this.buttonDetect.TabIndex = 2;
            this.buttonDetect.Text = "Detect";
            this.buttonDetect.UseVisualStyleBackColor = true;
            this.buttonDetect.Click += new System.EventHandler(this.buttonDetect_Click);
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductName.Location = new System.Drawing.Point(3, 35);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.ReadOnly = true;
            this.textBoxProductName.Size = new System.Drawing.Size(191, 20);
            this.textBoxProductName.TabIndex = 1;
            // 
            // buttonLoadProduct
            // 
            this.buttonLoadProduct.Location = new System.Drawing.Point(3, 6);
            this.buttonLoadProduct.Name = "buttonLoadProduct";
            this.buttonLoadProduct.Size = new System.Drawing.Size(94, 23);
            this.buttonLoadProduct.TabIndex = 0;
            this.buttonLoadProduct.Text = "Load Product";
            this.buttonLoadProduct.UseVisualStyleBackColor = true;
            this.buttonLoadProduct.Click += new System.EventHandler(this.buttonLoadProduct_Click);
            // 
            // imageBoxProduct
            // 
            this.imageBoxProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBoxProduct.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.PanAndZoom;
            this.imageBoxProduct.Location = new System.Drawing.Point(3, 176);
            this.imageBoxProduct.Name = "imageBoxProduct";
            this.imageBoxProduct.Size = new System.Drawing.Size(197, 401);
            this.imageBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBoxProduct.TabIndex = 2;
            this.imageBoxProduct.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownDistanceThr);
            this.groupBox1.Controls.Add(this.numericUpDownStepPercentage);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDownScaleIncrementStep);
            this.groupBox1.Controls.Add(this.numericUpDownMaxScale);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDownMinSCale);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 167);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Params";
            // 
            // numericUpDownDistanceThr
            // 
            this.numericUpDownDistanceThr.DecimalPlaces = 2;
            this.numericUpDownDistanceThr.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDownDistanceThr.Location = new System.Drawing.Point(123, 108);
            this.numericUpDownDistanceThr.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownDistanceThr.Name = "numericUpDownDistanceThr";
            this.numericUpDownDistanceThr.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownDistanceThr.TabIndex = 16;
            this.numericUpDownDistanceThr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownDistanceThr.Value = new decimal(new int[] {
            11,
            0,
            0,
            65536});
            // 
            // numericUpDownStepPercentage
            // 
            this.numericUpDownStepPercentage.DecimalPlaces = 2;
            this.numericUpDownStepPercentage.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownStepPercentage.Location = new System.Drawing.Point(123, 135);
            this.numericUpDownStepPercentage.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownStepPercentage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownStepPercentage.Name = "numericUpDownStepPercentage";
            this.numericUpDownStepPercentage.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownStepPercentage.TabIndex = 15;
            this.numericUpDownStepPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownStepPercentage.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "StepPercentage:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "DistanceThr:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "ScaleIncrementStep:";
            // 
            // numericUpDownScaleIncrementStep
            // 
            this.numericUpDownScaleIncrementStep.DecimalPlaces = 2;
            this.numericUpDownScaleIncrementStep.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownScaleIncrementStep.Location = new System.Drawing.Point(123, 77);
            this.numericUpDownScaleIncrementStep.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownScaleIncrementStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownScaleIncrementStep.Name = "numericUpDownScaleIncrementStep";
            this.numericUpDownScaleIncrementStep.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownScaleIncrementStep.TabIndex = 11;
            this.numericUpDownScaleIncrementStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownScaleIncrementStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // numericUpDownMaxScale
            // 
            this.numericUpDownMaxScale.DecimalPlaces = 2;
            this.numericUpDownMaxScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownMaxScale.Location = new System.Drawing.Point(123, 51);
            this.numericUpDownMaxScale.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownMaxScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownMaxScale.Name = "numericUpDownMaxScale";
            this.numericUpDownMaxScale.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownMaxScale.TabIndex = 10;
            this.numericUpDownMaxScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownMaxScale.Value = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "MaxScale:";
            // 
            // numericUpDownMinSCale
            // 
            this.numericUpDownMinSCale.DecimalPlaces = 2;
            this.numericUpDownMinSCale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownMinSCale.Location = new System.Drawing.Point(123, 24);
            this.numericUpDownMinSCale.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownMinSCale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownMinSCale.Name = "numericUpDownMinSCale";
            this.numericUpDownMinSCale.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownMinSCale.TabIndex = 8;
            this.numericUpDownMinSCale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownMinSCale.Value = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "MinScale:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.imageBoxTestImage, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(212, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(831, 646);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // imageBoxTestImage
            // 
            this.imageBoxTestImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxTestImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBoxTestImage.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.PanAndZoom;
            this.imageBoxTestImage.Location = new System.Drawing.Point(3, 3);
            this.imageBoxTestImage.Name = "imageBoxTestImage";
            this.imageBoxTestImage.Size = new System.Drawing.Size(825, 575);
            this.imageBoxTestImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBoxTestImage.TabIndex = 2;
            this.imageBoxTestImage.TabStop = false;
            this.imageBoxTestImage.Paint += new System.Windows.Forms.PaintEventHandler(this.imageBoxTestImage_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxTestImagePath);
            this.panel2.Controls.Add(this.buttonLoadTestImage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 584);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 59);
            this.panel2.TabIndex = 3;
            // 
            // textBoxTestImagePath
            // 
            this.textBoxTestImagePath.Location = new System.Drawing.Point(4, 34);
            this.textBoxTestImagePath.Name = "textBoxTestImagePath";
            this.textBoxTestImagePath.Size = new System.Drawing.Size(685, 20);
            this.textBoxTestImagePath.TabIndex = 1;
            // 
            // buttonLoadTestImage
            // 
            this.buttonLoadTestImage.Location = new System.Drawing.Point(695, 32);
            this.buttonLoadTestImage.Name = "buttonLoadTestImage";
            this.buttonLoadTestImage.Size = new System.Drawing.Size(124, 23);
            this.buttonLoadTestImage.TabIndex = 0;
            this.buttonLoadTestImage.Text = "Load image";
            this.buttonLoadTestImage.UseVisualStyleBackColor = true;
            this.buttonLoadTestImage.Click += new System.EventHandler(this.buttonLoadTestImage_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 652);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Product detection";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistanceThr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStepPercentage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScaleIncrementStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinSCale)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxTestImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private Emgu.CV.UI.ImageBox imageBoxProduct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Emgu.CV.UI.ImageBox imageBoxTestImage;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Button buttonLoadProduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxTestImagePath;
        private System.Windows.Forms.Button buttonLoadTestImage;
        private System.Windows.Forms.Button buttonDetect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownDistanceThr;
        private System.Windows.Forms.NumericUpDown numericUpDownStepPercentage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownScaleIncrementStep;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxScale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownMinSCale;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

