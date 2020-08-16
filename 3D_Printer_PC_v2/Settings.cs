using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Printer_PC_v2
{
    public static class Settings
    {
        public static bool areMotors34Coupled { get; set; } = true;
        public static MotorSettings motor1 { get; set; } = new MotorSettings(1, " oX  ");
        public static MotorSettings motor2 { get; set; } = new MotorSettings(2, " oY  ");
        public static MotorSettings motor3 { get; set; } = new MotorSettings(3, " oZ1 ");
        public static MotorSettings motor4 { get; set; } = new MotorSettings(4, " oZ2 ");
        public static MotorSettings motor5 { get; set; } = new MotorSettings(5, " oE  ");

        public static MotorSettings[] motors = { motor1, motor2, motor3, motor4, motor5 };
    }
}
