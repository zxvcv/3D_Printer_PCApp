using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Printer_PC
{
    public static class Settings
    {
        public static bool areMotors34Coupled { get; set; } = true;
        public static MotorSettings motor1 { get; set; } = new MotorSettings(1);
        public static MotorSettings motor2 { get; set; } = new MotorSettings(2);
        public static MotorSettings motor3 { get; set; } = new MotorSettings(3);
        public static MotorSettings motor4 { get; set; } = new MotorSettings(4);
        public static MotorSettings motor5 { get; set; } = new MotorSettings(5);
    }
}
