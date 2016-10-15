using ZedGraph;

namespace SignalAnalysis
{
    partial class MainForm
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
            this.FrequencySample = new ZedGraphControl();
            this.generateData = new System.Windows.Forms.Timer(this.components);
            this.graphUpdate = new System.Windows.Forms.Timer(this.components);
            this.FFToutput = new ZedGraphControl();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ampUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.ampUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.ampUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.ampUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.ampUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.ampUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ampUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.ampUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.displayFrequency = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ampUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ampUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ampUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ampUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ampUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ampUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ampUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ampUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayFrequency)).BeginInit();
            this.SuspendLayout();
            // 
            // FrequencySample
            // 
            this.FrequencySample.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FrequencySample.Location = new System.Drawing.Point(6, 19);
            this.FrequencySample.Name = "FrequencySample";
            this.FrequencySample.ScrollGrace = 0D;
            this.FrequencySample.ScrollMaxX = 0D;
            this.FrequencySample.ScrollMaxY = 0D;
            this.FrequencySample.ScrollMaxY2 = 0D;
            this.FrequencySample.ScrollMinX = 0D;
            this.FrequencySample.ScrollMinY = 0D;
            this.FrequencySample.ScrollMinY2 = 0D;
            this.FrequencySample.Size = new System.Drawing.Size(353, 272);
            this.FrequencySample.TabIndex = 0;
            // 
            // generateData
            // 
            this.generateData.Enabled = true;
            this.generateData.Interval = 10;
            this.generateData.Tick += new System.EventHandler(this.generateData_Tick);
            // 
            // graphUpdate
            // 
            this.graphUpdate.Enabled = true;
            this.graphUpdate.Tick += new System.EventHandler(this.graphUpdate_Tick);
            // 
            // FFToutput
            // 
            this.FFToutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FFToutput.Location = new System.Drawing.Point(6, 19);
            this.FFToutput.Name = "FFToutput";
            this.FFToutput.ScrollGrace = 0D;
            this.FFToutput.ScrollMaxX = 0D;
            this.FFToutput.ScrollMaxY = 0D;
            this.FFToutput.ScrollMaxY2 = 0D;
            this.FFToutput.ScrollMinX = 0D;
            this.FFToutput.ScrollMinY = 0D;
            this.FFToutput.ScrollMinY2 = 0D;
            this.FFToutput.Size = new System.Drawing.Size(353, 272);
            this.FFToutput.TabIndex = 1;
            this.FFToutput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FFToutput_MouseClick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(10, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.InputChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(31, 35);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.InputChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Location = new System.Drawing.Point(31, 61);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown2.TabIndex = 5;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown2.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.InputChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(10, 64);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.InputChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown3.Location = new System.Drawing.Point(31, 87);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown3.TabIndex = 7;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown3.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.InputChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(10, 90);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.InputChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ampUpDown8);
            this.groupBox1.Controls.Add(this.ampUpDown7);
            this.groupBox1.Controls.Add(this.ampUpDown4);
            this.groupBox1.Controls.Add(this.ampUpDown6);
            this.groupBox1.Controls.Add(this.ampUpDown5);
            this.groupBox1.Controls.Add(this.ampUpDown1);
            this.groupBox1.Controls.Add(this.ampUpDown3);
            this.groupBox1.Controls.Add(this.ampUpDown2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown8);
            this.groupBox1.Controls.Add(this.checkBox8);
            this.groupBox1.Controls.Add(this.numericUpDown7);
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.numericUpDown4);
            this.groupBox1.Controls.Add(this.numericUpDown5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.numericUpDown6);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 246);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Signals";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Amplitude";
            // 
            // ampUpDown8
            // 
            this.ampUpDown8.Location = new System.Drawing.Point(98, 217);
            this.ampUpDown8.Name = "ampUpDown8";
            this.ampUpDown8.Size = new System.Drawing.Size(61, 20);
            this.ampUpDown8.TabIndex = 26;
            this.ampUpDown8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ampUpDown8.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ampUpDown7
            // 
            this.ampUpDown7.Location = new System.Drawing.Point(98, 191);
            this.ampUpDown7.Name = "ampUpDown7";
            this.ampUpDown7.Size = new System.Drawing.Size(61, 20);
            this.ampUpDown7.TabIndex = 25;
            this.ampUpDown7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ampUpDown7.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ampUpDown4
            // 
            this.ampUpDown4.Location = new System.Drawing.Point(98, 113);
            this.ampUpDown4.Name = "ampUpDown4";
            this.ampUpDown4.Size = new System.Drawing.Size(61, 20);
            this.ampUpDown4.TabIndex = 22;
            this.ampUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ampUpDown4.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ampUpDown6
            // 
            this.ampUpDown6.Location = new System.Drawing.Point(98, 165);
            this.ampUpDown6.Name = "ampUpDown6";
            this.ampUpDown6.Size = new System.Drawing.Size(61, 20);
            this.ampUpDown6.TabIndex = 24;
            this.ampUpDown6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ampUpDown6.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ampUpDown5
            // 
            this.ampUpDown5.Location = new System.Drawing.Point(98, 139);
            this.ampUpDown5.Name = "ampUpDown5";
            this.ampUpDown5.Size = new System.Drawing.Size(61, 20);
            this.ampUpDown5.TabIndex = 23;
            this.ampUpDown5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ampUpDown5.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ampUpDown1
            // 
            this.ampUpDown1.Location = new System.Drawing.Point(98, 35);
            this.ampUpDown1.Name = "ampUpDown1";
            this.ampUpDown1.Size = new System.Drawing.Size(61, 20);
            this.ampUpDown1.TabIndex = 19;
            this.ampUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ampUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ampUpDown3
            // 
            this.ampUpDown3.Location = new System.Drawing.Point(98, 87);
            this.ampUpDown3.Name = "ampUpDown3";
            this.ampUpDown3.Size = new System.Drawing.Size(61, 20);
            this.ampUpDown3.TabIndex = 21;
            this.ampUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ampUpDown3.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // ampUpDown2
            // 
            this.ampUpDown2.Location = new System.Drawing.Point(98, 61);
            this.ampUpDown2.Name = "ampUpDown2";
            this.ampUpDown2.Size = new System.Drawing.Size(61, 20);
            this.ampUpDown2.TabIndex = 20;
            this.ampUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ampUpDown2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Frequency";
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown8.Location = new System.Drawing.Point(31, 217);
            this.numericUpDown8.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown8.TabIndex = 17;
            this.numericUpDown8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown8.Value = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numericUpDown8.ValueChanged += new System.EventHandler(this.InputChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Checked = true;
            this.checkBox8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox8.Location = new System.Drawing.Point(10, 220);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(15, 14);
            this.checkBox8.TabIndex = 16;
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.InputChanged);
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown7.Location = new System.Drawing.Point(31, 191);
            this.numericUpDown7.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown7.TabIndex = 15;
            this.numericUpDown7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown7.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown7.ValueChanged += new System.EventHandler(this.InputChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Checked = true;
            this.checkBox7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox7.Location = new System.Drawing.Point(10, 194);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(15, 14);
            this.checkBox7.TabIndex = 14;
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.InputChanged);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown4.Location = new System.Drawing.Point(31, 113);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown4.TabIndex = 9;
            this.numericUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown4.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.InputChanged);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown5.Location = new System.Drawing.Point(31, 165);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown5.TabIndex = 13;
            this.numericUpDown5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown5.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.InputChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(10, 116);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 8;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.InputChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(10, 168);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 12;
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.InputChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(10, 142);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(15, 14);
            this.checkBox6.TabIndex = 10;
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.InputChanged);
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown6.Location = new System.Drawing.Point(31, 139);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown6.TabIndex = 11;
            this.numericUpDown6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown6.Value = new decimal(new int[] {
            1250,
            0,
            0,
            0});
            this.numericUpDown6.ValueChanged += new System.EventHandler(this.InputChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FrequencySample);
            this.groupBox2.Location = new System.Drawing.Point(186, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 297);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Signal Input";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FFToutput);
            this.groupBox3.Location = new System.Drawing.Point(557, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(365, 297);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Frequency Analysis";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.displayFrequency);
            this.groupBox4.Location = new System.Drawing.Point(12, 264);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(168, 48);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Display Frequency";
            // 
            // displayFrequency
            // 
            this.displayFrequency.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.displayFrequency.Location = new System.Drawing.Point(10, 19);
            this.displayFrequency.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.displayFrequency.Name = "displayFrequency";
            this.displayFrequency.Size = new System.Drawing.Size(149, 20);
            this.displayFrequency.TabIndex = 28;
            this.displayFrequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.displayFrequency.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 318);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Signal Analysis by John Vickers: Powered by ZedGraph and AForge";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ampUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ampUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ampUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ampUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ampUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ampUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ampUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ampUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.displayFrequency)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraphControl FrequencySample;
        private System.Windows.Forms.Timer generateData;
        private System.Windows.Forms.Timer graphUpdate;
        private ZedGraphControl FFToutput;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ampUpDown8;
        private System.Windows.Forms.NumericUpDown ampUpDown7;
        private System.Windows.Forms.NumericUpDown ampUpDown4;
        private System.Windows.Forms.NumericUpDown ampUpDown6;
        private System.Windows.Forms.NumericUpDown ampUpDown5;
        private System.Windows.Forms.NumericUpDown ampUpDown1;
        private System.Windows.Forms.NumericUpDown ampUpDown3;
        private System.Windows.Forms.NumericUpDown ampUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown displayFrequency;
    }
}

