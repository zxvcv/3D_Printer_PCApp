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
    public partial class MotorsCoupling : Form
    {
        public MotorsCoupling()
        {
            InitializeComponent();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are u sure?", "Message", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                checkBox1.Checked = !checkBox1.Checked;
            }
            else
            {
                if (checkBox1.Checked)
                {
                    Program.form.motor3ToolStripMenuItem.Visible = false;
                    Program.form.motor4ToolStripMenuItem.Visible = false;
                    Program.form.motor34ToolStripMenuItem.Visible = true;
                }
                else
                {
                    Program.form.motor3ToolStripMenuItem.Visible = true;
                    Program.form.motor4ToolStripMenuItem.Visible = true;
                    Program.form.motor34ToolStripMenuItem.Visible = false;
                }
            }
        }
    }
}
