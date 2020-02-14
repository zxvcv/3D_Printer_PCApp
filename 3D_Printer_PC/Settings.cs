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
