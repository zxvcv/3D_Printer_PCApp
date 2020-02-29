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
    public partial class Configurations : Form
    {
        public Configurations()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Connector.outputMessages.Enqueue("SP M1 " + numericUpDown1.Value.ToString().Replace(',', '.'));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connector.outputMessages.Enqueue("SP M2 " + numericUpDown4.Value.ToString().Replace(',', '.'));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connector.outputMessages.Enqueue("SP M3 " + numericUpDown2.Value.ToString().Replace(',', '.'));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Connector.outputMessages.Enqueue("SP M4 " + numericUpDown3.Value.ToString().Replace(',', '.'));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Connector.outputMessages.Enqueue("SP M5 " + numericUpDown5.Value.ToString().Replace(',', '.'));
        }

        public void updateData()
        {
            textBox1.Text = Settings.motor1.stepSize.ToString();
            textBox4.Text = Settings.motor2.stepSize.ToString();
            textBox2.Text = Settings.motor3.stepSize.ToString();
            textBox3.Text = Settings.motor4.stepSize.ToString();
            textBox5.Text = Settings.motor5.stepSize.ToString();
        }

        private void Configurations_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.configurationMenuStatus = false;
        }
    }
}
