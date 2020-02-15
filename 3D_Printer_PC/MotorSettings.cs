using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Printer_PC
{
    public class MotorSettings
    {
        public double position { get; set; }
        public double speed { get; set; }

        public double maxSpeed { get; set; }
        public double positionZero { get; set; }
        public double positionEnd { get; set; }
    }
}
