using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Printer_PC
{
    public class MotorSettings
    {
        private MotorController controller;

        public double position { get; set; }
        public double speed { get; set; }

        public double maxSpeed { get; set; }
        public double positionZero { get; set; }
        public double positionEnd { get; set; }

        public MotorSettings(MotorController controller)
        {
            this.controller = controller;
        }

        public void update()
        {
            controller.positionVal.Text = this.position.ToString();
            controller.zeroPositionVal.Text = this.positionZero.ToString();
            controller.endPositionVal.Text = this.positionEnd.ToString();
            controller.speedVal.Text = this.speed.ToString();
            controller.maxSpeedVal.Text = this.maxSpeed.ToString();
        }
    }
}
