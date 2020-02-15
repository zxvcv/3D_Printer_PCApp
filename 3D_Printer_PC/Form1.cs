using System;
using System.Collections.Concurrent;
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
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            this.timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void motor1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MotorController mc = new MotorController();
            mc.motorNumber = 1;
            mc.Text += "1";
            //Connector.outputMessages.Enqueue("M1DR");
            //string[] data = Connector.readLine().Split(' ');
            string[] data = { "aaa", "12.5", "15.4", "18.3", "11.0", "3.8" };
            Settings.motor1.position = Double.Parse(data[1].Replace('.', ','));
            Settings.motor1.positionZero = Double.Parse(data[2].Replace('.', ','));
            Settings.motor1.positionEnd = Double.Parse(data[3].Replace('.', ','));
            Settings.motor1.speed = Double.Parse(data[4].Replace('.', ','));
            Settings.motor1.maxSpeed = Double.Parse(data[5].Replace('.', ','));
            mc.Controls.Find("positionVal", true)[0].Text = Settings.motor1.position.ToString();
            mc.Controls.Find("zeroPositionVal", true)[0].Text = Settings.motor1.positionZero.ToString();
            mc.Controls.Find("endPositionVal", true)[0].Text = Settings.motor1.positionEnd.ToString();
            mc.Controls.Find("speedVal", true)[0].Text = Settings.motor1.speed.ToString();
            mc.Controls.Find("maxSpeedVal", true)[0].Text = Settings.motor1.maxSpeed.ToString();
            mc.Show();
            
        }

        private void motor2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MotorController mc = new MotorController();
            mc.motorNumber = 2;
            mc.Text += "2";
            mc.Show();
        }

        private void motor3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MotorController mc = new MotorController();
            mc.motorNumber = 3;
            mc.Text += "3";
            mc.Show();
        }

        private void motor4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MotorController mc = new MotorController();
            mc.motorNumber = 4;
            mc.Text += "4";
            mc.Show();
        }

        private void motor5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MotorController mc = new MotorController();
            mc.motorNumber = 5;
            mc.Text += "5";
            mc.Show();
        }

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Connection mc = new Connection();
            mc.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Connector.isOpen())
            {
                Connector.sendMessage("testowa wiadomość");
            }
            else
            {
                MessageBox.Show("nie ma polaczenia z uC");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void calibrationModeBut_Click(object sender, EventArgs e)
        { 
            if (Settings.isCalibrationMode())
            {
                Settings.exitCalibrationMode();
                calibrationModeBut.BackColor = Color.White;

                connectionToolStripMenuItem.Enabled = true;
            }
            else
            {
                if (!Connector.isOpen())
                {
                    MessageBox.Show("No connection to the uC");
                    return;
                }

                Settings.setCalibrationMode();
                calibrationModeBut.BackColor = Color.Red;

                connectionToolStripMenuItem.Enabled = false;
            }
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string message;
            
            bool result = Connector.outputMessages.TryDequeue(out message);

            if (result)
                Connector.sendMessage(message);
        }
    }
}
