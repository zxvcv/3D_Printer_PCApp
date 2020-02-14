using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Printer_PC
{
    public class PortAlreadyClosedException : Exception
    {
        public PortAlreadyClosedException()
        {
        }

        public PortAlreadyClosedException(string message) : base(message)
        {

        }

        public PortAlreadyClosedException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
