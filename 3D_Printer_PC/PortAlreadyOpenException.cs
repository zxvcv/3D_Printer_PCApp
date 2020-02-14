using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Printer_PC
{
    public class PortAlreadyOpenException : Exception
    {
        public PortAlreadyOpenException()
        {
        }

        public PortAlreadyOpenException(string message) : base(message)
        {

        }

        public PortAlreadyOpenException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
