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
        public static SerialPort serialPort { get; set; }
        public static ConcurrentQueue<string> outputMessages { get; set; }
        public static ConcurrentQueue<string> inputMessages { get; set; }

        static Connector()
        {
            serialPort = new SerialPort();
            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            outputMessages = new ConcurrentQueue<string>();
            inputMessages = new ConcurrentQueue<string>();
        }

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
            serialPort.Write(message + '\n');
        }

        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string indata = Connector.serialPort.ReadLine();
            Connector.inputMessages.Enqueue(indata + "\n");
        }
    }
}
