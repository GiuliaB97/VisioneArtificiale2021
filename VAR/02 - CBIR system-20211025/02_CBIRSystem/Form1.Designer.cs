namespace _02_CBIRSystem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDetector = new System.Windows.Forms.ComboBox();
            this.buttonExtractFeatures = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDBFolder = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.imageBoxQuery = new Emgu.CV.UI.ImageBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownWShape = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownWColor = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownWBoW = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonLoadQuery = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.imageBox12 = new Emgu.CV.UI.ImageBox();
            this.imageBox11 = new Emgu.CV.UI.ImageBox();
            this.imageBox10 = new Emgu.CV.UI.ImageBox();
            this.imageBox9 = new Emgu.CV.UI.ImageBox();
            this.imageBox8 = new Emgu.CV.UI.ImageBox();
            this.imageBox7 = new Emgu.CV.UI.ImageBox();
            this.imageBox6 = new Emgu.CV.UI.ImageBox();
            this.imageBox5 = new Emgu.CV.UI.ImageBox();
            this.imageBox4 = new Emgu.CV.UI.ImageBox();
            this.imageBox3 = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.backgroundWorkerTraining = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerSearch = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxQuery)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWShape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWBoW)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.21659F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.78341F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1084, 651);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxDetector);
            this.panel1.Controls.Add(this.buttonExtractFeatures);
            this.panel1.Controls.Add(this.buttonBrowse);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxDBFolder);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 54);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(772, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descriptor:";
            // 
            // comboBoxDetector
            // 
            this.comboBoxDetector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDetector.FormattingEnabled = true;
            this.comboBoxDetector.Items.AddRange(new object[] {
            "SIFT",
            "SURF"});
            this.comboBoxDetector.Location = new System.Drawing.Point(775, 24);
            this.comboBoxDetector.Name = "comboBoxDetector";
            this.comboBoxDetector.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDetector.TabIndex = 4;
            // 
            // buttonExtractFeatures
            // 
            this.buttonExtractFeatures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExtractFeatures.Location = new System.Drawing.Point(912, 24);
            this.buttonExtractFeatures.Name = "buttonExtractFeatures";
            this.buttonExtractFeatures.Size = new System.Drawing.Size(117, 22);
            this.buttonExtractFeatures.TabIndex = 3;
            this.buttonExtractFeatures.Text = "Extract Features";
            this.buttonExtractFeatures.UseVisualStyleBackColor = true;
            this.buttonExtractFeatures.Click += new System.EventHandler(this.buttonExtractFeatures_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(681, 22);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DB Folder:";
            // 
            // textBoxDBFolder
            // 
            this.textBoxDBFolder.Location = new System.Drawing.Point(15, 24);
            this.textBoxDBFolder.Name = "textBoxDBFolder";
            this.textBoxDBFolder.Size = new System.Drawing.Size(660, 20);
            this.textBoxDBFolder.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.93237F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.06763F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 63);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1078, 585);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.imageBoxQuery, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.68394F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.31606F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(230, 579);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // imageBoxQuery
            // 
            this.imageBoxQuery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBoxQuery.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.PanAndZoom;
            this.imageBoxQuery.Location = new System.Drawing.Point(3, 3);
            this.imageBoxQuery.Name = "imageBoxQuery";
            this.imageBoxQuery.Size = new System.Drawing.Size(224, 437);
            this.imageBoxQuery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBoxQuery.TabIndex = 2;
            this.imageBoxQuery.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownWShape);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDownWColor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDownWBoW);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.buttonLoadQuery);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 446);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 130);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Params";
            // 
            // numericUpDownWShape
            // 
            this.numericUpDownWShape.DecimalPlaces = 1;
            this.numericUpDownWShape.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownWShape.Location = new System.Drawing.Point(154, 104);
            this.numericUpDownWShape.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWShape.Name = "numericUpDownWShape";
            this.numericUpDownWShape.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownWShape.TabIndex = 8;
            this.numericUpDownWShape.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Shape";
            // 
            // numericUpDownWColor
            // 
            this.numericUpDownWColor.DecimalPlaces = 1;
            this.numericUpDownWColor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownWColor.Location = new System.Drawing.Point(80, 104);
            this.numericUpDownWColor.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWColor.Name = "numericUpDownWColor";
            this.numericUpDownWColor.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownWColor.TabIndex = 6;
            this.numericUpDownWColor.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Color";
            // 
            // numericUpDownWBoW
            // 
            this.numericUpDownWBoW.DecimalPlaces = 1;
            this.numericUpDownWBoW.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownWBoW.Location = new System.Drawing.Point(6, 104);
            this.numericUpDownWBoW.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWBoW.Name = "numericUpDownWBoW";
            this.numericUpDownWBoW.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownWBoW.TabIndex = 4;
            this.numericUpDownWBoW.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "BoW";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 2;
            // 
            // buttonLoadQuery
            // 
            this.buttonLoadQuery.Location = new System.Drawing.Point(6, 44);
            this.buttonLoadQuery.Name = "buttonLoadQuery";
            this.buttonLoadQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadQuery.TabIndex = 1;
            this.buttonLoadQuery.Text = "Load query";
            this.buttonLoadQuery.UseVisualStyleBackColor = true;
            this.buttonLoadQuery.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Enabled = false;
            this.buttonSearch.Location = new System.Drawing.Point(134, 44);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tableLayoutPanel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(239, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(836, 579);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel4.Controls.Add(this.imageBox12, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.imageBox11, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.imageBox10, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.imageBox9, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.imageBox8, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.imageBox7, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.imageBox6, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.imageBox5, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.imageBox4, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.imageBox3, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.imageBox2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.imageBox1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(834, 577);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // imageBox12
            // 
            this.imageBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox12.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.PanAndZoom;
            this.imageBox12.Location = new System.Drawing.Point(561, 435);
            this.imageBox12.Name = "imageBox12";
            this.imageBox12.Size = new System.Drawing.Size(270, 139);
            this.imageBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox12.TabIndex = 13;
            this.imageBox12.TabStop = false;
            // 
            // imageBox11
            // 
            this.imageBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox11.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.PanAndZoom;
            this.imageBox11.Location = new System.Drawing.Point(278, 435);
            this.imageBox11.Name = "imageBox11";
            this.imageBox11.Size = new System.Drawing.Size(277, 139);
            this.imageBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox11.TabIndex = 12;
            this.imageBox11.TabStop = false;
            // 
            // imageBox10
            // 
            this.imageBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox10.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.PanAndZoom;
            this.imageBox10.Location = new System.Drawing.Point(3, 435);
            this.imageBox10.Name = "imageBox10";
            this.imageBox10.Size = new System.Drawing.Size(269, 139);
            this.imageBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox10.TabIndex = 11;
            this.imageBox10.TabStop = false;
            // 
            // imageBox9
            // 
            this.imageBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox9.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.PanAndZoom;
            this.imageBox9.Location = new System.Drawing.Point(561, 291);
            this.imageBox9.Name = "imageBox9";
            this.imageBox9.Size = new System.Drawing.Size(270, 138);
            this.imageBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox9.TabIndex = 10;
            this.imageBox9.TabStop = false;
            // 
            // imageBox8
            // 
            this.imageBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox8.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.PanAndZoom;
            this.imageBox8.Location = new System.Drawing.Point(278, 291);
            this.imageBox8.Name = "imageBox8";
            this.imageBox8.Size = new System.Drawing.Size(277, 138);
            this.imageBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox8.TabIndex = 9;
            this.imageBox8.TabStop = false;
            // 
            // imageBox7
            // 
            this.imageBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox7.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.PanAndZoom;
            this.imageBox7.Location = new System.Drawing.Point(3, 291);
            this.imageBox7.Name = "imageBox7";
            this.imageBox7.Size = new System.Drawing.Size(269, 138);
            this.imageBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox7.TabIndex = 8;
            this.imageBox7.TabStop = false;
            // 
            // imageBox6
            // 
            this.imageBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox6.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.PanAndZoom;
            this.imageBox6.Location = new System.Drawing.Point(561, 147);
            this.imageBox6.Name = "imageBox6";
            this.imageBox6.Size = new System.Drawing.Size(270, 138);
            this.imageBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox6.TabIndex = 7;
            this.imageBox6.TabStop = false;
            // 
            // imageBox5
            // 
            this.imageBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox5.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.PanAndZoom;
            this.imageBox5.Location = new System.Drawing.Point(278, 147);
            this.imageBox5.Name = "imageBox5";
            this.imageBox5.Size = new System.Drawing.Size(277, 138);
            this.imageBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox5.TabIndex = 6;
            this.imageBox5.TabStop = false;
            // 
            // imageBox4
            // 
            this.imageBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox4.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.PanAndZoom;
            this.imageBox4.Location = new System.Drawing.Point(3, 147);
            this.imageBox4.Name = "imageBox4";
            this.imageBox4.Size = new System.Drawing.Size(269, 138);
            this.imageBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox4.TabIndex = 5;
            this.imageBox4.TabStop = false;
            // 
            // imageBox3
            // 
            this.imageBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox3.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.PanAndZoom;
            this.imageBox3.Location = new System.Drawing.Point(561, 3);
            this.imageBox3.Name = "imageBox3";
            this.imageBox3.Size = new System.Drawing.Size(270, 138);
            this.imageBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox3.TabIndex = 4;
            this.imageBox3.TabStop = false;
            // 
            // imageBox2
            // 
            this.imageBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox2.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.PanAndZoom;
            this.imageBox2.Location = new System.Drawing.Point(278, 3);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(277, 138);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox2.TabIndex = 3;
            this.imageBox2.TabStop = false;
            // 
            // imageBox1
            // 
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox1.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.PanAndZoom;
            this.imageBox1.Location = new System.Drawing.Point(3, 3);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(269, 138);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // backgroundWorkerTraining
            // 
            this.backgroundWorkerTraining.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerTraining_DoWork);
            this.backgroundWorkerTraining.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerTraining_RunWorkerCompleted);
            // 
            // backgroundWorkerSearch
            // 
            this.backgroundWorkerSearch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSearch_DoWork);
            this.backgroundWorkerSearch.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerSearch_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 651);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1100, 690);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxQuery)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWShape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWBoW)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDBFolder;
        private System.Windows.Forms.ComboBox comboBoxDetector;
        private System.Windows.Forms.Button buttonExtractFeatures;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Emgu.CV.UI.ImageBox imageBoxQuery;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonLoadQuery;
        private System.ComponentModel.BackgroundWorker backgroundWorkerTraining;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Emgu.CV.UI.ImageBox imageBox12;
        private Emgu.CV.UI.ImageBox imageBox11;
        private Emgu.CV.UI.ImageBox imageBox10;
        private Emgu.CV.UI.ImageBox imageBox9;
        private Emgu.CV.UI.ImageBox imageBox8;
        private Emgu.CV.UI.ImageBox imageBox7;
        private Emgu.CV.UI.ImageBox imageBox6;
        private Emgu.CV.UI.ImageBox imageBox5;
        private Emgu.CV.UI.ImageBox imageBox4;
        private Emgu.CV.UI.ImageBox imageBox3;
        private Emgu.CV.UI.ImageBox imageBox2;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownWShape;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownWColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownWBoW;
        private System.Windows.Forms.Label label3;
    }
}

