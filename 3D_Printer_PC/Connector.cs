using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Printer_PC
{
    public static class Connector
    {
        private static SerialPort serialPort = new SerialPort();
        public static ConcurrentQueue<string> outputMessages { get; set; } = new ConcurrentQueue<string>();

        public static string[] getAllPorstNames()
        {
            return SerialPort.GetPortNames();
        }

        public static void setPortName(string portName)
        {
            serialPort.PortName = portName;
        }

        public static void setBaudRate(int baudRate)
        {
            serialPort.BaudRate = baudRate;
        }

        public static void setParity(Parity parity)
        {
            serialPort.Parity = parity;
        }

        public static void setPortStopBits(StopBits stopBits)
        {
            serialPort.StopBits = stopBits;
        }

        public static void setPortHandshake(Handshake handshake)
        {
            serialPort.Handshake = handshake;
        }

        public static void connect()
        {
            if (serialPort.IsOpen)
                throw new PortAlreadyOpenException();

            serialPort.Open();
        }

        public static void disconnect()
        {
            if (!serialPort.IsOpen)
                throw new PortAlreadyClosedException();

            serialPort.Close();
        }

        public static bool isOpen()
        {
            return serialPort.IsOpen;
        }

        public static void sendMessage(string message)
        {
            serialPort.Write(message);
        }
    }
}
