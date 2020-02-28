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
        public static MotorController mc1 { get; set; } = new MotorController(1);
        public static MotorController mc2 { get; set; } = new MotorController(2);
        public static MotorController mc34 { get; set; } = new MotorController(3);
        public static MotorController mc3 { get; set; } = new MotorController(3);
        public static MotorController mc4 { get; set; } = new MotorController(4);
        public static MotorController mc5 { get; set; } = new MotorController(5);
        public static MotorsCoupling motorsCoupling { get; set; } = new MotorsCoupling();

        public Form1()
        {
            InitializeComponent();
            this.timer1.Start();
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

        private void motor34ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mc34.Show();
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

        private void motorsCouplingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            motorsCoupling.ShowDialog();
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
