using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3D_Printer_PC
{
    public partial class DoubleMotorController : Form
    { 
        public int motor1Number { set; get; }
        public int motor2Number { set; get; }


        public DoubleMotorController()
        {
            InitializeComponent();
        }

        public DoubleMotorController(int motorNum1, int motorNum2)
        {
            InitializeComponent();
            this.motor1Number = motorNum1;
            this.motor2Number = motorNum2;
        }

        //motor 3 buttons
        private void positionSetButt_Click(object sender, EventArgs e)
        {
            Connector.outputMessages.Enqueue("PM M3 " + positionSet.Value.ToString().Replace(',', '.'));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connector.outputMessages.Enqueue("PV M3 " + positionSet.Value.ToString().Replace(',', '.'));
        }

        private void positionZeroSetButt_Click(object sender, EventArgs e)
        {
            Connector.outputMessages.Enqueue("PZ M3 " + positionSet.Value.ToString().Replace(',', '.'));
        }
        private void positionEndSetButt_Click(object sender, EventArgs e)
        {
            Connector.outputMessages.Enqueue("PE M3 " + positionSet.Value.ToString().Replace(',', '.'));
        }
        private void distanceMovButt_Click(object sender, EventArgs e)
        {
            Connector.outputMessages.Enqueue("DM M3 " + distanceSet.Value.ToString().Replace(',', '.'));
        }
        private void speedSetButt_Click(object sender, EventArgs e)
        {
            Connector.outputMessages.Enqueue("SS M3 " + speedSetVal.Text.Replace(',', '.'));
        }
        private void maxSpeedSetButt_Click(object sender, EventArgs e)
        {
            Connector.outputMessages.Enqueue("SM M3 " + maxSpeedSet.Value.ToString().Replace(',', '.'));
        }

        //motor 4 buttons
        private void positionSetButt2_Click(object sender, EventArgs e)
        {
            Connector.outputMessages.Enqueue("PM M4 " + positionSet2.Value.ToString().Replace(',', '.'));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Connector.outputMessages.Enqueue("PV M4 " + positionSet2.Value.ToString().Replace(',', '.'));
        }
        private void positionZeroSetButt2_Click(object sender, EventArgs e)
        {
            Connector.outputMessages.Enqueue("PZ M4 " + positionSet2.Value.ToString().Replace(',', '.'));
        }
        private void positionEndSetButt2_Click(object sender, EventArgs e)
        {
            Connector.outputMessages.Enqueue("PE M4 " + positionSet2.Value.ToString().Replace(',', '.'));
        }
        private void distanceMovButt2_Click(object sender, EventArgs e)
        {
            Connector.outputMessages.Enqueue("DM M4 " + distanceSet2.Value.ToString().Replace(',', '.'));
        }
        private void speedSetButt2_Click(object sender, EventArgs e)
        {
            Connector.outputMessages.Enqueue("SS M4 " + speedSetVal2.Text.Replace(',', '.'));
        }
        private void maxSpeedSetButt2_Click(object sender, EventArgs e)
        {
            Connector.outputMessages.Enqueue("SM M4 " + maxSpeedSet2.Value.ToString().Replace(',', '.'));
        }

        //motor 34 buttons
        private void distanceMovButt3_Click(object sender, EventArgs e)
        {
            if(Settings.motor3.speed != Settings.motor4.speed)
            {
                var result = MessageBox.Show("Motor speed values are unequal!\nThis operation may damege the device!\nDo you want to move motors anyway?", "Warning", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                    Connector.outputMessages.Enqueue("DM M34 " + distanceSet3.Value.ToString().Replace(',', '.'));
            }
            else
            {
                Connector.outputMessages.Enqueue("DM M34 " + distanceSet3.Value.ToString().Replace(',', '.'));
            }
        }
        private void speedSetButt3_Click(object sender, EventArgs e)
        {
            Connector.outputMessages.Enqueue("SS M34 " + speedSetVal3.Text.Replace(',', '.'));
        }
        private void maxSpeedSetButt3_Click(object sender, EventArgs e)
        {
            Connector.outputMessages.Enqueue("SM M34 " + maxSpeedSet3.Value.ToString().Replace(',', '.'));
        }

        public void updateMotor3Data(MotorSettings settings)
        {
            positionVal.Text = settings.position.ToString();
            zeroPositionVal.Text = settings.positionZero.ToString();
            endPositionVal.Text = settings.positionEnd.ToString();
            speedVal.Text = settings.speed.ToString();
            maxSpeedVal.Text = settings.maxSpeed.ToString();
        }

        public void updateMotor4Data(MotorSettings settings)
        {
            positionVal2.Text = settings.position.ToString();
            zeroPositionVal2.Text = settings.positionZero.ToString();
            endPositionVal2.Text = settings.positionEnd.ToString();
            speedVal2.Text = settings.speed.ToString();
            maxSpeedVal2.Text = settings.maxSpeed.ToString();
        }

        private void DoubleMotorController_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.motorController34Status = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Settings.areMotors34Coupled)
            {
                var result = MessageBox.Show("Are you sure, you want to unlink 3 and 4 engine?\n", "Warning", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    Settings.areMotors34Coupled = false;
                    groupBox1.Enabled = true;
                    groupBox2.Enabled = true;
                    groupBox9.Enabled = false;
                    button7.Text = "LINK MOTORS";
                }
            }
            else
            {
                var result = MessageBox.Show("Are you sure, you want to link 3 and 4 engine?\n", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Settings.areMotors34Coupled = true;
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    groupBox9.Enabled = true;
                    button7.Text = "UNLINK MOTORS";
                }
            }
        }
    }
}
