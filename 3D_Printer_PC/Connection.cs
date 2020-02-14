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
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                Connector.disconnect();
                progressBar1.Value = 0;
            }
            catch(PortAlreadyClosedException)
            {
                MessageBox.Show("Port is already closed!");
            }
        }

        private void comPortPicker_Click(object sender, EventArgs e)
        {
            comPortPicker.Items.Clear();
            comPortPicker.Items.AddRange(Connector.getAllPorstNames());
        }

        private void connectButoon_Click(object sender, EventArgs e)
        {
            if (Connector.isOpen())
            {
                MessageBox.Show("Port is alredy open, close it before retrying");
                return;
            }
            if (comPortPicker.Text.Equals("") || baudRatePicker.Text.Equals(""))
            {
                MessageBox.Show("Wrong values");
                return;
            }

            this.timer1.Start();

            Connector.setPortName(comPortPicker.Text);
            Connector.setBaudRate(Int32.Parse(baudRatePicker.Text));
            try
            {
                Connector.connect();
            }
            catch(PortAlreadyOpenException)
            {
                MessageBox.Show("Port is alredy open, close it before retrying");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Unauthorized access to the port");
            }
            catch(Exception)
            {
                MessageBox.Show("Unknown Error");
            }
            this.timer1.Stop();
            progressBar1.Value = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(10);
        }

        private void Connection_Load(object sender, EventArgs e)
        {

        }
    }
}
