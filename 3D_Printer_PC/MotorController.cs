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
            Connector.outputMessages.Enqueue("M" + motorNumber + " P" + positionSet.Value);
        }

        private void positionZeroSetButt_Click(object sender, EventArgs e)
        {
            Connector.outputMessages.Enqueue("M" + motorNumber + " Z" + positionSet.Value);
        }

        private void positionEndSetButt_Click(object sender, EventArgs e)
        {
            Connector.outputMessages.Enqueue("M" + motorNumber + " E" + positionSet.Value);
        }

        private void distanceMovButt_Click(object sender, EventArgs e)
        {
            Connector.outputMessages.Enqueue("M" + motorNumber + " D" + distanceSet.Value);
        }

        private void speedSetButt_Click(object sender, EventArgs e)
        {
            Connector.outputMessages.Enqueue("M" + motorNumber + " S" + speedSetVal.Value);
        }

        private void maxSpeedSetButt_Click(object sender, EventArgs e)
        {
            Connector.outputMessages.Enqueue("M" + motorNumber + " M" + maxSpeedSet.Value);
        }
    }
}
