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
            Connector.outputMessages.Enqueue("M1DR");
        }
    }
}
