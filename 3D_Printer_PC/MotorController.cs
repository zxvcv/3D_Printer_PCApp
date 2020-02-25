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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MotorController_Load(object sender, EventArgs e)
        {

        }
    }
}
