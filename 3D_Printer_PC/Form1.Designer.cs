namespace _3D_Printer_PC
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sDCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motor1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motor2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motor3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motor4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motor5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headPositionGrp = new System.Windows.Forms.GroupBox();
            this.headPosZ = new System.Windows.Forms.NumericUpDown();
            this.headPosY = new System.Windows.Forms.NumericUpDown();
            this.headPosX = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.headSpeadGrp = new System.Windows.Forms.GroupBox();
            this.headSpdZ = new System.Windows.Forms.NumericUpDown();
            this.headSpdY = new System.Windows.Forms.NumericUpDown();
            this.headSpdX = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.calibrationModeBut = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.RunPrgButt = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this._headTemperature = new System.Windows.Forms.Label();
            this._boardTemperature = new System.Windows.Forms.Label();
            this._headTempVal = new System.Windows.Forms.NumericUpDown();
            this._boardTempVal = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.headPositionGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headPosZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headPosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headPosX)).BeginInit();
            this.headSpeadGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headSpdZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headSpdY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headSpdX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._headTempVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._boardTempVal)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.programToolStripMenuItem,
            this.motorsToolStripMenuItem,
            this.temperatureToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1049, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitApplicationToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(81, 20);
            this.toolStripMenuItem1.Text = "Connection";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.connectionToolStripMenuItem.Text = "Connection";
            this.connectionToolStripMenuItem.Click += new System.EventHandler(this.connectionToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exitApplicationToolStripMenuItem.Text = "Exit Application";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sDCardToolStripMenuItem});
            this.programToolStripMenuItem.Enabled = false;
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // sDCardToolStripMenuItem
            // 
            this.sDCardToolStripMenuItem.Name = "sDCardToolStripMenuItem";
            this.sDCardToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.sDCardToolStripMenuItem.Text = "SD Card";
            // 
            // motorsToolStripMenuItem
            // 
            this.motorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motor1ToolStripMenuItem,
            this.motor2ToolStripMenuItem,
            this.motor3ToolStripMenuItem,
            this.motor4ToolStripMenuItem,
            this.motor5ToolStripMenuItem});
            this.motorsToolStripMenuItem.Name = "motorsToolStripMenuItem";
            this.motorsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.motorsToolStripMenuItem.Text = "Motors";
            // 
            // motor1ToolStripMenuItem
            // 
            this.motor1ToolStripMenuItem.Name = "motor1ToolStripMenuItem";
            this.motor1ToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.motor1ToolStripMenuItem.Text = "Motor1";
            this.motor1ToolStripMenuItem.Click += new System.EventHandler(this.motor1ToolStripMenuItem_Click);
            // 
            // motor2ToolStripMenuItem
            // 
            this.motor2ToolStripMenuItem.Name = "motor2ToolStripMenuItem";
            this.motor2ToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.motor2ToolStripMenuItem.Text = "Motor2";
            this.motor2ToolStripMenuItem.Click += new System.EventHandler(this.motor2ToolStripMenuItem_Click);
            // 
            // motor3ToolStripMenuItem
            // 
            this.motor3ToolStripMenuItem.Name = "motor3ToolStripMenuItem";
            this.motor3ToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.motor3ToolStripMenuItem.Text = "Motor3";
            this.motor3ToolStripMenuItem.Click += new System.EventHandler(this.motor3ToolStripMenuItem_Click);
            // 
            // motor4ToolStripMenuItem
            // 
            this.motor4ToolStripMenuItem.Enabled = false;
            this.motor4ToolStripMenuItem.Name = "motor4ToolStripMenuItem";
            this.motor4ToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.motor4ToolStripMenuItem.Text = "Motor4";
            this.motor4ToolStripMenuItem.Click += new System.EventHandler(this.motor4ToolStripMenuItem_Click);
            // 
            // motor5ToolStripMenuItem
            // 
            this.motor5ToolStripMenuItem.Enabled = false;
            this.motor5ToolStripMenuItem.Name = "motor5ToolStripMenuItem";
            this.motor5ToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.motor5ToolStripMenuItem.Text = "Motor5";
            this.motor5ToolStripMenuItem.Click += new System.EventHandler(this.motor5ToolStripMenuItem_Click);
            // 
            // temperatureToolStripMenuItem
            // 
            this.temperatureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.headToolStripMenuItem,
            this.boardToolStripMenuItem});
            this.temperatureToolStripMenuItem.Enabled = false;
            this.temperatureToolStripMenuItem.Name = "temperatureToolStripMenuItem";
            this.temperatureToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.temperatureToolStripMenuItem.Text = "Temperature";
            // 
            // headToolStripMenuItem
            // 
            this.headToolStripMenuItem.Name = "headToolStripMenuItem";
            this.headToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.headToolStripMenuItem.Text = "Head";
            // 
            // boardToolStripMenuItem
            // 
            this.boardToolStripMenuItem.Name = "boardToolStripMenuItem";
            this.boardToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.boardToolStripMenuItem.Text = "Board";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // headPositionGrp
            // 
            this.headPositionGrp.Controls.Add(this.headPosZ);
            this.headPositionGrp.Controls.Add(this.headPosY);
            this.headPositionGrp.Controls.Add(this.headPosX);
            this.headPositionGrp.Controls.Add(this.label3);
            this.headPositionGrp.Controls.Add(this.label2);
            this.headPositionGrp.Controls.Add(this.label1);
            this.headPositionGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headPositionGrp.Location = new System.Drawing.Point(12, 38);
            this.headPositionGrp.Name = "headPositionGrp";
            this.headPositionGrp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.headPositionGrp.Size = new System.Drawing.Size(200, 134);
            this.headPositionGrp.TabIndex = 6;
            this.headPositionGrp.TabStop = false;
            this.headPositionGrp.Text = "Head Position";
            this.headPositionGrp.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // headPosZ
            // 
            this.headPosZ.DecimalPlaces = 2;
            this.headPosZ.Enabled = false;
            this.headPosZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headPosZ.Location = new System.Drawing.Point(51, 91);
            this.headPosZ.Name = "headPosZ";
            this.headPosZ.Size = new System.Drawing.Size(120, 20);
            this.headPosZ.TabIndex = 5;
            // 
            // headPosY
            // 
            this.headPosY.DecimalPlaces = 2;
            this.headPosY.Enabled = false;
            this.headPosY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headPosY.Location = new System.Drawing.Point(51, 62);
            this.headPosY.Name = "headPosY";
            this.headPosY.Size = new System.Drawing.Size(120, 20);
            this.headPosY.TabIndex = 4;
            // 
            // headPosX
            // 
            this.headPosX.DecimalPlaces = 2;
            this.headPosX.Enabled = false;
            this.headPosX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headPosX.Location = new System.Drawing.Point(51, 33);
            this.headPosX.Name = "headPosX";
            this.headPosX.Size = new System.Drawing.Size(120, 20);
            this.headPosX.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Z";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // headSpeadGrp
            // 
            this.headSpeadGrp.Controls.Add(this.headSpdZ);
            this.headSpeadGrp.Controls.Add(this.headSpdY);
            this.headSpeadGrp.Controls.Add(this.headSpdX);
            this.headSpeadGrp.Controls.Add(this.label4);
            this.headSpeadGrp.Controls.Add(this.label5);
            this.headSpeadGrp.Controls.Add(this.label6);
            this.headSpeadGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headSpeadGrp.Location = new System.Drawing.Point(12, 178);
            this.headSpeadGrp.Name = "headSpeadGrp";
            this.headSpeadGrp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.headSpeadGrp.Size = new System.Drawing.Size(200, 134);
            this.headSpeadGrp.TabIndex = 7;
            this.headSpeadGrp.TabStop = false;
            this.headSpeadGrp.Text = "Head Speed";
            this.headSpeadGrp.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // headSpdZ
            // 
            this.headSpdZ.DecimalPlaces = 2;
            this.headSpdZ.Enabled = false;
            this.headSpdZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headSpdZ.Location = new System.Drawing.Point(51, 91);
            this.headSpdZ.Name = "headSpdZ";
            this.headSpdZ.Size = new System.Drawing.Size(120, 20);
            this.headSpdZ.TabIndex = 5;
            // 
            // headSpdY
            // 
            this.headSpdY.DecimalPlaces = 2;
            this.headSpdY.Enabled = false;
            this.headSpdY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headSpdY.Location = new System.Drawing.Point(51, 62);
            this.headSpdY.Name = "headSpdY";
            this.headSpdY.Size = new System.Drawing.Size(120, 20);
            this.headSpdY.TabIndex = 4;
            // 
            // headSpdX
            // 
            this.headSpdX.DecimalPlaces = 2;
            this.headSpdX.Enabled = false;
            this.headSpdX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headSpdX.Location = new System.Drawing.Point(51, 33);
            this.headSpdX.Name = "headSpdX";
            this.headSpdX.Size = new System.Drawing.Size(120, 20);
            this.headSpdX.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Z";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "X";
            // 
            // calibrationModeBut
            // 
            this.calibrationModeBut.BackColor = System.Drawing.SystemColors.Control;
            this.calibrationModeBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.calibrationModeBut.Location = new System.Drawing.Point(929, 38);
            this.calibrationModeBut.Name = "calibrationModeBut";
            this.calibrationModeBut.Size = new System.Drawing.Size(108, 35);
            this.calibrationModeBut.TabIndex = 8;
            this.calibrationModeBut.Text = "Calibration";
            this.calibrationModeBut.UseVisualStyleBackColor = false;
            this.calibrationModeBut.Click += new System.EventHandler(this.calibrationModeBut_Click);
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(249, 60);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(534, 89);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(249, 200);
            this.chart2.Name = "chart2";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(534, 89);
            this.chart2.TabIndex = 10;
            this.chart2.Text = "chart2";
            // 
            // RunPrgButt
            // 
            this.RunPrgButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RunPrgButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RunPrgButt.Location = new System.Drawing.Point(929, 185);
            this.RunPrgButt.Name = "RunPrgButt";
            this.RunPrgButt.Size = new System.Drawing.Size(108, 41);
            this.RunPrgButt.TabIndex = 11;
            this.RunPrgButt.Text = "Run Program from SD Card";
            this.RunPrgButt.UseVisualStyleBackColor = false;
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stopButton.Location = new System.Drawing.Point(929, 242);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(108, 88);
            this.stopButton.TabIndex = 12;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = false;
            // 
            // _headTemperature
            // 
            this._headTemperature.AutoSize = true;
            this._headTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._headTemperature.Location = new System.Drawing.Point(232, 42);
            this._headTemperature.Name = "_headTemperature";
            this._headTemperature.Size = new System.Drawing.Size(127, 15);
            this._headTemperature.TabIndex = 13;
            this._headTemperature.Text = "Head Temperature";
            // 
            // _boardTemperature
            // 
            this._boardTemperature.AutoSize = true;
            this._boardTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._boardTemperature.Location = new System.Drawing.Point(232, 182);
            this._boardTemperature.Name = "_boardTemperature";
            this._boardTemperature.Size = new System.Drawing.Size(131, 15);
            this._boardTemperature.TabIndex = 14;
            this._boardTemperature.Text = "Board Temperature";
            // 
            // _headTempVal
            // 
            this._headTempVal.DecimalPlaces = 1;
            this._headTempVal.Enabled = false;
            this._headTempVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._headTempVal.Location = new System.Drawing.Point(789, 60);
            this._headTempVal.Name = "_headTempVal";
            this._headTempVal.Size = new System.Drawing.Size(80, 20);
            this._headTempVal.TabIndex = 15;
            // 
            // _boardTempVal
            // 
            this._boardTempVal.DecimalPlaces = 1;
            this._boardTempVal.Enabled = false;
            this._boardTempVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._boardTempVal.Location = new System.Drawing.Point(789, 200);
            this._boardTempVal.Name = "_boardTempVal";
            this._boardTempVal.Size = new System.Drawing.Size(80, 20);
            this._boardTempVal.TabIndex = 16;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(223, 341);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(560, 223);
            this.textBox1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1049, 576);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this._boardTempVal);
            this.Controls.Add(this._headTempVal);
            this.Controls.Add(this._boardTemperature);
            this.Controls.Add(this._headTemperature);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.RunPrgButt);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.calibrationModeBut);
            this.Controls.Add(this.headSpeadGrp);
            this.Controls.Add(this.headPositionGrp);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.headPositionGrp.ResumeLayout(false);
            this.headPositionGrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headPosZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headPosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headPosX)).EndInit();
            this.headSpeadGrp.ResumeLayout(false);
            this.headSpeadGrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headSpdZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headSpdY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headSpdX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._headTempVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._boardTempVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem motorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motor1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motor2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motor3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motor4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motor5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.GroupBox headPositionGrp;
        private System.Windows.Forms.NumericUpDown headPosZ;
        private System.Windows.Forms.NumericUpDown headPosY;
        private System.Windows.Forms.NumericUpDown headPosX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox headSpeadGrp;
        private System.Windows.Forms.NumericUpDown headSpdZ;
        private System.Windows.Forms.NumericUpDown headSpdY;
        private System.Windows.Forms.NumericUpDown headSpdX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button calibrationModeBut;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button RunPrgButt;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sDCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem headToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boardToolStripMenuItem;
        private System.Windows.Forms.Label _headTemperature;
        private System.Windows.Forms.Label _boardTemperature;
        private System.Windows.Forms.NumericUpDown _headTempVal;
        private System.Windows.Forms.NumericUpDown _boardTempVal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

