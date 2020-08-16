using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Printer_PC_v2
{
    public class MotorSettings
    {
        public int motorNumber { get; }
        public string label { get; }

        public double stepSize { get; set; }

        public double position { get; set; }
        public double speed { get; set; }

        public double maxSpeed { get; set; }
        public double positionZero { get; set; }
        public double positionEnd { get; set; }

        public MotorSettings(int motorNumber, string label)
        {
            this.motorNumber = motorNumber;
            this.label = label;
        }
    }
}
