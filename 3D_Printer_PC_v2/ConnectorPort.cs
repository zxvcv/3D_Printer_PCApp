using System;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Collections.Concurrent;

namespace _3D_Printer_PC_v2
{
    public class ConnectorPort
    {
        private SerialPort serialPort;
        //private ConcurrentQueue<string> outputMessages;
        public ConcurrentQueue<string> inputMessages { get; set; }

        public ConnectorPort()
        {
            serialPort = new SerialPort();
            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            //outputMessages = new ConcurrentQueue<string>();
            inputMessages = new ConcurrentQueue<string>();
        }

        public string[] getAllPortsNames()
        {
            return SerialPort.GetPortNames();
        }

        public void setPortName(string portName)
        {
            serialPort.PortName = portName;
        }

        public void setBaudRate(int baudRate)
        {
            serialPort.BaudRate = baudRate;
        }

        public void connect()
        {
            if (serialPort.IsOpen)
                throw new IOException();

            serialPort.Open();
        }

        public void disconnect()
        {
            if (!serialPort.IsOpen)
                throw new IOException();

            serialPort.Close();
        }

        public bool isOpen()
        {
            return serialPort.IsOpen;
        }

        public void sendMessage(string message)
        {
            serialPort.Write(message.Replace(',', '.') + '\n');
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string indata = serialPort.ReadLine();
            inputMessages.Enqueue(indata + "\n");
        }
    }
}
