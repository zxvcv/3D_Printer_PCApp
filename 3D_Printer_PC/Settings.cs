using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Printer_PC
{
    public static class Settings
    {
        private static bool calibrationMode = false;
        public static MotorSettings motor1 { get; set; } = new MotorSettings(Form1.mc1);
        public static MotorSettings motor2 { get; set; } = new MotorSettings(Form1.mc2);
        public static MotorSettings motor3 { get; set; } = new MotorSettings(Form1.mc3);
        public static MotorSettings motor4 { get; set; } = new MotorSettings(Form1.mc4);

        public static bool isCalibrationMode()
        {
            return calibrationMode;
        }

        public static void setCalibrationMode()
        {
            calibrationMode = true;
        }
        
        public static void exitCalibrationMode()
        {
            calibrationMode = false;
        }
    }
}
