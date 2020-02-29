using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Printer_PC
{
    public static class CommandsManager
    {
        public static void getDataMotor1()
        {
            Connector.outputMessages.Enqueue("DR M1");
        }

        public static void getDataMotor2()
        {
            Connector.outputMessages.Enqueue("DR M2");
        }

        public static void getDataMotor3()
        {
            Connector.outputMessages.Enqueue("DR M3");
        }

        public static void getDataMotor4()
        {
            Connector.outputMessages.Enqueue("DR M4");
        }

        public static void getDataMotor5()
        {
            Connector.outputMessages.Enqueue("DR M5");
        }
    }
}
