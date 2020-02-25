using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3D_Printer_PC
{
    public partial class Form1 : Form
    {
        public static MotorController mc1 { get; set; } = new MotorController();
        public static MotorController mc2 { get; set; } = new MotorController();
        public static MotorController mc3 { get; set; } = new MotorController();
        public static MotorController mc4 { get; set; } = new MotorController();
        public static MotorController mc5 { get; set; } = new MotorController();


        public Form1()
        {
            InitializeComponent();
            this.timer1.Start();
            //motor1
            mc1.motorNumber = 1;
            mc1.Text += "1";
            //motor2
            mc2.motorNumber = 2;
            mc2.Text += "2";
            //motor3
            mc3.motorNumber = 3;
            mc3.Text += "3";
            //motor4
            mc4.motorNumber = 4;
            mc4.Text += "4";
            //motor5
            mc5.motorNumber = 5;
            mc5.Text += "5";
        }

        private void motor1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommandsManager.getDataMotor1();
            mc1.Show();
        }

        private void motor2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommandsManager.getDataMotor2();
            mc2.Show();
        }

        private void motor3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mc3.Show();
        }

        private void motor4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mc4.Show();
        }

        private void motor5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mc5.Show();
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

        static int num = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            string message;
            
            bool result = Connector.outputMessages.TryDequeue(out message);
            if (result)
                Connector.sendMessage(message);

            
            if(Connector.inputMessages.TryDequeue(out message))
            {
                CommandData commandData = CommandsParser.parseCommand(message);
                if(commandData.execute != null)
                    CommandsParser.executeCommand(commandData);
            }
        }
    }
}
