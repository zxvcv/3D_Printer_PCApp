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
        public static bool motorController1Status;
        public static bool motorController2Status;
        public static bool motorController34Status;
        public static bool motorController5Status;
        public static MotorController mc1;
        public static MotorController mc2;
        public static DoubleMotorController mc34;
        public static MotorController mc5;

        public Form1()
        {
            InitializeComponent();
            this.timer1.Start();
            motorController1Status = false;
            motorController1Status = false;
            motorController34Status = false;
            motorController5Status = false;
        }

        private void motor1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!motorController1Status)
            {
                CommandsManager.getDataMotor1();
                mc1 = new MotorController(1);
                mc1.Show();
                motorController1Status = true;
            }
        }

        private void motor2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!motorController2Status)
            {
                CommandsManager.getDataMotor2();
                mc2 = new MotorController(2);
                mc2.Show();
                motorController2Status = true;
            }
        }

        private void motor34ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!motorController2Status)
            {
                CommandsManager.getDataMotor3();
                CommandsManager.getDataMotor4();
                mc34 = new DoubleMotorController(3, 4);
                mc34.Show();
                motorController34Status = true;
            }
        }

        private void motor5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!motorController2Status)
            {
                //CommandsManager.getDataMotor5();
                mc5 = new MotorController(5);
                mc5.Show();
                motorController5Status = true;
            }
        }

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Connection mc = new Connection();
            mc.ShowDialog();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            string message;
            
            bool result = Connector.outputMessages.TryDequeue(out message);
            if (result)
                Connector.sendMessage(message);

            
            if(Connector.inputMessages.TryDequeue(out message))
            {
                textBox1.Text += message;
                CommandData commandData = CommandsParser.parseCommand(message);
                if(commandData.execute != null)
                    CommandsParser.executeCommand(commandData);
            }
        }
    }
}
