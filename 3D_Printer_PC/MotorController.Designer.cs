namespace _3D_Printer_PC
{
    partial class MotorController
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
            this.endPositionGrp = new System.Windows.Forms.GroupBox();
            this.endPositionVal = new System.Windows.Forms.Label();
            this.zeroPositionGrp = new System.Windows.Forms.GroupBox();
            this.zeroPositionVal = new System.Windows.Forms.Label();
            this.positionGrp = new System.Windows.Forms.GroupBox();
            this.positionVal = new System.Windows.Forms.TextBox();
            this.positionSet = new System.Windows.Forms.NumericUpDown();
            this.positionEndSetButt = new System.Windows.Forms.Button();
            this.positionZeroSetButt = new System.Windows.Forms.Button();
            this.positionSetButt = new System.Windows.Forms.Button();
            this.maxspeedGrp = new System.Windows.Forms.GroupBox();
            this.maxSpeedSetButt = new System.Windows.Forms.Button();
            this.maxSpeedVal = new System.Windows.Forms.TextBox();
            this.maxSpeedSet = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.speedGrp = new System.Windows.Forms.GroupBox();
            this.speedSetButt = new System.Windows.Forms.Button();
            this.speedVal = new System.Windows.Forms.TextBox();
            this.speedSetVal = new System.Windows.Forms.NumericUpDown();
            this._M1_X_Speed = new System.Windows.Forms.Label();
            this.distanceGrp = new System.Windows.Forms.GroupBox();
            this.distanceMovButt = new System.Windows.Forms.Button();
            this.distanceSet = new System.Windows.Forms.NumericUpDown();
            this.ExitButton = new System.Windows.Forms.Button();
            this.endPositionGrp.SuspendLayout();
            this.zeroPositionGrp.SuspendLayout();
            this.positionGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionSet)).BeginInit();
            this.maxspeedGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxSpeedSet)).BeginInit();
            this.speedGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedSetVal)).BeginInit();
            this.distanceGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distanceSet)).BeginInit();
            this.SuspendLayout();
            // 
            // endPositionGrp
            // 
            this.endPositionGrp.Controls.Add(this.endPositionVal);
            this.endPositionGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endPositionGrp.Location = new System.Drawing.Point(23, 86);
            this.endPositionGrp.Name = "endPositionGrp";
            this.endPositionGrp.Size = new System.Drawing.Size(99, 36);
            this.endPositionGrp.TabIndex = 32;
            this.endPositionGrp.TabStop = false;
            this.endPositionGrp.Text = "End Position";
            // 
            // endPositionVal
            // 
            this.endPositionVal.AutoSize = true;
            this.endPositionVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endPositionVal.Location = new System.Drawing.Point(33, 16);
            this.endPositionVal.Name = "endPositionVal";
            this.endPositionVal.Size = new System.Drawing.Size(31, 15);
            this.endPositionVal.TabIndex = 20;
            this.endPositionVal.Text = "0.00";
            // 
            // zeroPositionGrp
            // 
            this.zeroPositionGrp.Controls.Add(this.zeroPositionVal);
            this.zeroPositionGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zeroPositionGrp.Location = new System.Drawing.Point(23, 45);
            this.zeroPositionGrp.Name = "zeroPositionGrp";
            this.zeroPositionGrp.Size = new System.Drawing.Size(99, 35);
            this.zeroPositionGrp.TabIndex = 31;
            this.zeroPositionGrp.TabStop = false;
            this.zeroPositionGrp.Text = "Zero Position";
            // 
            // zeroPositionVal
            // 
            this.zeroPositionVal.AutoSize = true;
            this.zeroPositionVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zeroPositionVal.Location = new System.Drawing.Point(33, 15);
            this.zeroPositionVal.Name = "zeroPositionVal";
            this.zeroPositionVal.Size = new System.Drawing.Size(31, 15);
            this.zeroPositionVal.TabIndex = 20;
            this.zeroPositionVal.Text = "0.00";
            // 
            // positionGrp
            // 
            this.positionGrp.Controls.Add(this.positionVal);
            this.positionGrp.Controls.Add(this.endPositionGrp);
            this.positionGrp.Controls.Add(this.positionSet);
            this.positionGrp.Controls.Add(this.zeroPositionGrp);
            this.positionGrp.Controls.Add(this.positionEndSetButt);
            this.positionGrp.Controls.Add(this.positionZeroSetButt);
            this.positionGrp.Controls.Add(this.positionSetButt);
            this.positionGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.positionGrp.Location = new System.Drawing.Point(12, 12);
            this.positionGrp.Name = "positionGrp";
            this.positionGrp.Size = new System.Drawing.Size(279, 131);
            this.positionGrp.TabIndex = 28;
            this.positionGrp.TabStop = false;
            this.positionGrp.Text = "position";
            // 
            // positionVal
            // 
            this.positionVal.Enabled = false;
            this.positionVal.Location = new System.Drawing.Point(23, 19);
            this.positionVal.Name = "positionVal";
            this.positionVal.Size = new System.Drawing.Size(68, 20);
            this.positionVal.TabIndex = 12;
            // 
            // positionSet
            // 
            this.positionSet.DecimalPlaces = 2;
            this.positionSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.positionSet.Location = new System.Drawing.Point(188, 19);
            this.positionSet.Name = "positionSet";
            this.positionSet.Size = new System.Drawing.Size(78, 20);
            this.positionSet.TabIndex = 11;
            // 
            // positionEndSetButt
            // 
            this.positionEndSetButt.Location = new System.Drawing.Point(134, 97);
            this.positionEndSetButt.Name = "positionEndSetButt";
            this.positionEndSetButt.Size = new System.Drawing.Size(132, 20);
            this.positionEndSetButt.TabIndex = 10;
            this.positionEndSetButt.Text = "Set End Position";
            this.positionEndSetButt.UseVisualStyleBackColor = true;
            this.positionEndSetButt.Click += new System.EventHandler(this.positionEndSetButt_Click);
            // 
            // positionZeroSetButt
            // 
            this.positionZeroSetButt.Location = new System.Drawing.Point(134, 55);
            this.positionZeroSetButt.Name = "positionZeroSetButt";
            this.positionZeroSetButt.Size = new System.Drawing.Size(132, 20);
            this.positionZeroSetButt.TabIndex = 9;
            this.positionZeroSetButt.Text = "Set Zero Position";
            this.positionZeroSetButt.UseVisualStyleBackColor = true;
            this.positionZeroSetButt.Click += new System.EventHandler(this.positionZeroSetButt_Click);
            // 
            // positionSetButt
            // 
            this.positionSetButt.Location = new System.Drawing.Point(97, 19);
            this.positionSetButt.Name = "positionSetButt";
            this.positionSetButt.Size = new System.Drawing.Size(85, 20);
            this.positionSetButt.TabIndex = 7;
            this.positionSetButt.Text = "<--- Set ---";
            this.positionSetButt.UseVisualStyleBackColor = true;
            this.positionSetButt.Click += new System.EventHandler(this.positionSetButt_Click);
            // 
            // maxspeedGrp
            // 
            this.maxspeedGrp.Controls.Add(this.maxSpeedSetButt);
            this.maxspeedGrp.Controls.Add(this.maxSpeedVal);
            this.maxspeedGrp.Controls.Add(this.maxSpeedSet);
            this.maxspeedGrp.Controls.Add(this.label1);
            this.maxspeedGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maxspeedGrp.Location = new System.Drawing.Point(12, 263);
            this.maxspeedGrp.Name = "maxspeedGrp";
            this.maxspeedGrp.Size = new System.Drawing.Size(279, 48);
            this.maxspeedGrp.TabIndex = 27;
            this.maxspeedGrp.TabStop = false;
            this.maxspeedGrp.Text = "max speed";
            // 
            // maxSpeedSetButt
            // 
            this.maxSpeedSetButt.Location = new System.Drawing.Point(97, 19);
            this.maxSpeedSetButt.Name = "maxSpeedSetButt";
            this.maxSpeedSetButt.Size = new System.Drawing.Size(85, 20);
            this.maxSpeedSetButt.TabIndex = 18;
            this.maxSpeedSetButt.Text = "<--- Set ---";
            this.maxSpeedSetButt.UseVisualStyleBackColor = true;
            this.maxSpeedSetButt.Click += new System.EventHandler(this.maxSpeedSetButt_Click);
            // 
            // maxSpeedVal
            // 
            this.maxSpeedVal.Enabled = false;
            this.maxSpeedVal.Location = new System.Drawing.Point(19, 19);
            this.maxSpeedVal.Name = "maxSpeedVal";
            this.maxSpeedVal.Size = new System.Drawing.Size(68, 20);
            this.maxSpeedVal.TabIndex = 17;
            // 
            // maxSpeedSet
            // 
            this.maxSpeedSet.DecimalPlaces = 2;
            this.maxSpeedSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maxSpeedSet.Location = new System.Drawing.Point(188, 19);
            this.maxSpeedSet.Name = "maxSpeedSet";
            this.maxSpeedSet.Size = new System.Drawing.Size(78, 20);
            this.maxSpeedSet.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 16;
            // 
            // speedGrp
            // 
            this.speedGrp.Controls.Add(this.speedSetButt);
            this.speedGrp.Controls.Add(this.speedVal);
            this.speedGrp.Controls.Add(this.speedSetVal);
            this.speedGrp.Controls.Add(this._M1_X_Speed);
            this.speedGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.speedGrp.Location = new System.Drawing.Point(12, 209);
            this.speedGrp.Name = "speedGrp";
            this.speedGrp.Size = new System.Drawing.Size(279, 48);
            this.speedGrp.TabIndex = 26;
            this.speedGrp.TabStop = false;
            this.speedGrp.Text = "speed";
            // 
            // speedSetButt
            // 
            this.speedSetButt.Location = new System.Drawing.Point(97, 19);
            this.speedSetButt.Name = "speedSetButt";
            this.speedSetButt.Size = new System.Drawing.Size(85, 20);
            this.speedSetButt.TabIndex = 14;
            this.speedSetButt.Text = "<--- Set ---";
            this.speedSetButt.UseVisualStyleBackColor = true;
            this.speedSetButt.Click += new System.EventHandler(this.speedSetButt_Click);
            // 
            // speedVal
            // 
            this.speedVal.Enabled = false;
            this.speedVal.Location = new System.Drawing.Point(19, 19);
            this.speedVal.Name = "speedVal";
            this.speedVal.Size = new System.Drawing.Size(68, 20);
            this.speedVal.TabIndex = 13;
            // 
            // speedSetVal
            // 
            this.speedSetVal.DecimalPlaces = 2;
            this.speedSetVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.speedSetVal.Location = new System.Drawing.Point(188, 19);
            this.speedSetVal.Name = "speedSetVal";
            this.speedSetVal.Size = new System.Drawing.Size(78, 20);
            this.speedSetVal.TabIndex = 0;
            // 
            // _M1_X_Speed
            // 
            this._M1_X_Speed.AutoSize = true;
            this._M1_X_Speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this._M1_X_Speed.Location = new System.Drawing.Point(17, 21);
            this._M1_X_Speed.Name = "_M1_X_Speed";
            this._M1_X_Speed.Size = new System.Drawing.Size(0, 13);
            this._M1_X_Speed.TabIndex = 2;
            // 
            // distanceGrp
            // 
            this.distanceGrp.Controls.Add(this.distanceMovButt);
            this.distanceGrp.Controls.Add(this.distanceSet);
            this.distanceGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.distanceGrp.Location = new System.Drawing.Point(12, 149);
            this.distanceGrp.Name = "distanceGrp";
            this.distanceGrp.Size = new System.Drawing.Size(190, 54);
            this.distanceGrp.TabIndex = 25;
            this.distanceGrp.TabStop = false;
            this.distanceGrp.Text = "distance";
            // 
            // distanceMovButt
            // 
            this.distanceMovButt.Location = new System.Drawing.Point(102, 19);
            this.distanceMovButt.Name = "distanceMovButt";
            this.distanceMovButt.Size = new System.Drawing.Size(75, 20);
            this.distanceMovButt.TabIndex = 10;
            this.distanceMovButt.Text = "Move";
            this.distanceMovButt.UseVisualStyleBackColor = true;
            this.distanceMovButt.Click += new System.EventHandler(this.distanceMovButt_Click);
            // 
            // distanceSet
            // 
            this.distanceSet.DecimalPlaces = 2;
            this.distanceSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.distanceSet.Location = new System.Drawing.Point(19, 19);
            this.distanceSet.Name = "distanceSet";
            this.distanceSet.Size = new System.Drawing.Size(77, 20);
            this.distanceSet.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(220, 317);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 29;
            this.ExitButton.Text = "CLOSE";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MotorController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(307, 349);
            this.ControlBox = false;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.positionGrp);
            this.Controls.Add(this.maxspeedGrp);
            this.Controls.Add(this.speedGrp);
            this.Controls.Add(this.distanceGrp);
            this.MaximizeBox = false;
            this.Name = "MotorController";
            this.Text = "Motor";
            this.endPositionGrp.ResumeLayout(false);
            this.endPositionGrp.PerformLayout();
            this.zeroPositionGrp.ResumeLayout(false);
            this.zeroPositionGrp.PerformLayout();
            this.positionGrp.ResumeLayout(false);
            this.positionGrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionSet)).EndInit();
            this.maxspeedGrp.ResumeLayout(false);
            this.maxspeedGrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxSpeedSet)).EndInit();
            this.speedGrp.ResumeLayout(false);
            this.speedGrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedSetVal)).EndInit();
            this.distanceGrp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.distanceSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox endPositionGrp;
        private System.Windows.Forms.GroupBox zeroPositionGrp;
        private System.Windows.Forms.GroupBox positionGrp;
        private System.Windows.Forms.Button positionEndSetButt;
        private System.Windows.Forms.Button positionZeroSetButt;
        private System.Windows.Forms.Button positionSetButt;
        private System.Windows.Forms.GroupBox maxspeedGrp;
        private System.Windows.Forms.GroupBox speedGrp;
        private System.Windows.Forms.NumericUpDown speedSetVal;
        private System.Windows.Forms.Label _M1_X_Speed;
        private System.Windows.Forms.GroupBox distanceGrp;
        private System.Windows.Forms.Button distanceMovButt;
        private System.Windows.Forms.NumericUpDown positionSet;
        private System.Windows.Forms.Button maxSpeedSetButt;
        private System.Windows.Forms.NumericUpDown maxSpeedSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button speedSetButt;
        public System.Windows.Forms.Label endPositionVal;
        public System.Windows.Forms.Label zeroPositionVal;
        public System.Windows.Forms.NumericUpDown distanceSet;
        public System.Windows.Forms.TextBox positionVal;
        public System.Windows.Forms.TextBox maxSpeedVal;
        public System.Windows.Forms.TextBox speedVal;
        private System.Windows.Forms.Button ExitButton;
    }
}