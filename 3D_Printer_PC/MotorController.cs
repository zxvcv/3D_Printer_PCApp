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
    public partial class MotorController : Form
    {
        public int motorNumber { set; get; }

        public MotorController()
        {
            InitializeComponent();
        }

        public MotorController(int number)
        {
            InitializeComponent();
            this.motorNumber = number;
            this.Text += number.ToString();
        }

        private void positionSetButt_Click(object sender, EventArgs e)
        {
            Connector.outputMessages.Enqueue("PM M" + motorNumber + " " + positionSet.Value.ToString().Replace(',', '.'));
        }

        private void positionZeroSetButt_Click(object sender, EventArgs e)
        {
            Connector.outputMessages.Enqueue("PZ M" + motorNumber + " " + positionSet.Value.ToString().Replace(',', '.'));
        }

        private void positionEndSetButt_Click(object sender, EventArgs e)
        {
            Connector.outputMessages.Enqueue("PE M" + motorNumber + " " + positionSet.Value.ToString().Replace(',', '.'));
        }

        private void distanceMovButt_Click(object sender, EventArgs e)
        {
            Connector.outputMessages.Enqueue("DM M" + motorNumber + " " + distanceSet.Value.ToString().Replace(',', '.'));
        }

        private void speedSetButt_Click(object sender, EventArgs e)
        {
            Connector.outputMessages.Enqueue("SS M" + motorNumber + " " + speedSetVal.Text.Replace(',', '.'));
        }

        private void maxSpeedSetButt_Click(object sender, EventArgs e)
        {
            Connector.outputMessages.Enqueue("SM M" + motorNumber + " " + maxSpeedSet.Value.ToString().Replace(',', '.'));
        }

        public void updateData(MotorSettings settings)
        {
            positionVal.Text = settings.position.ToString();
            zeroPositionVal.Text = settings.positionZero.ToString();
            endPositionVal.Text = settings.positionEnd.ToString();
            speedVal.Text = settings.speed.ToString();
            maxSpeedVal.Text = settings.maxSpeed.ToString();
        }

        private void MotorController_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (motorNumber)
            {
                case 1: Form1.motorController1Status = false; break;
                case 2: Form1.motorController2Status = false; break;
                case 5: Form1.motorController5Status = false; break;
                default: break;
            }
        }
    }
}
