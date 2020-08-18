using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3D_Printer_PC_v2
{
    public partial class Form1 : Form
    {
        private const int MOTORS_NUM = 4;
        private static ConnectorPort connector;
        private List<string> commandHistory;
        private int historyCounter;

        private const string CONSOLE_HELP =
            "  AVAILABLE COMMANDS:\r\n" +
            "    clear\r\n" +
            "    data_request -m<motor_number>\r\n" +
            "    position_move -m<motor_number> -v<position>\r\n" +
            "    position_value_set -m<motor_number> -v<position>\r\n" +
            "    position_zero_set -m<motor_number> -v<position>\r\n" +
            "    position_end_set -m<motor_number> -v<position>\r\n" +
            "    distance_move -m<motor_number> -v<distance>\r\n" +
            "    speed_set -m<motor(s)_number> -v<speed>\r\n" +
            "    speed_max_set -m<motor(s)_number> -v<speed>\r\n" +
            "    step_size_request -m<motor_number>\r\n" +
            "    step_size_set -m<motor_number> -v<step_size>\r\n" +
            "    program_run_SD\r\n" +
            "  AVAILABLE ALIASES:\r\n" +
            "    data_request_all\r\n" +
            "    step_size_request_all\r\n";

        public Form1()
        {
            InitializeComponent();

            commandHistory = new List<string>();
            historyCounter = 0;

            connector = new ConnectorPort();
            connector.setPortName("COM3");
            connector.setBaudRate(38400);
            updateDataGUI();
            connector.connect();
            alias_requestDataAll();
            alias_requestStepSizeAll();
            updateDataGUI();
        }

        private void consoleTextInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string command;

                consoleBox.AppendText("> " + consoleTextInput.Text + "\r\n");
                commandHistory.Add(consoleTextInput.Text);
                historyCounter = commandHistory.Count - 1;

                if (OutputParser.parse(consoleTextInput.Text, out command))
                {
                    if(command.Equals("clear"))
                    {
                        consoleBox.Text = "";
                    }
                    else if (command.Equals("help"))
                    {
                        consoleBox.AppendText(CONSOLE_HELP);
                    }
                    else if (command.Equals("data_request_all"))
                    {
                        alias_requestDataAll();
                    }
                    else if (command.Equals("step_size_request_all"))
                    {
                        alias_requestStepSizeAll();
                    }
                    else
                    {
                        connector.sendMessage(command);
                    }
                }
                else
                {
                    consoleBox.AppendText("  [ERR]: incorrect command\r\n");
                }

                consoleTextInput.Text = "";
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Up)
            {
                if (commandHistory.Count == 0)
                    return;
                consoleTextInput.Text = commandHistory[historyCounter--];
                if (historyCounter < 0)
                    historyCounter = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                if (commandHistory.Count == 0)
                    return;
                consoleTextInput.Text = commandHistory[historyCounter++];
                if (historyCounter >= commandHistory.Count)
                    historyCounter = commandHistory.Count - 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (connector.inputMessages.TryDequeue(out string messageIN))
            {
                consoleBox.AppendText("< " + messageIN + "\r\n");
                CommandData commandData = InputParser.parseCommand(messageIN);
                if (commandData.execute != null)
                {
                    InputParser.executeCommand(commandData);
                    updateDataGUI();
                } 
            }
        }

        private void updateDataGUI()
        {
            outputDataBox.Text = String.Format("{0,10}|{1,5}|{2,10}|{3,10}|{4,10}|{5,10}|{6,10}|{7,10}\r\n",
                "","label" ,"posZero", "position", "posEnd", "speed", "maxSpeed", "stepSize");
            outputDataBox.AppendText(String.Format("{0,10}|{1,5}|{0,10}|{0,10}|{0,10}|{0,10}|{0,10}|{0,10}\r\n", "----------", "----"));
            for (int i=0; i<5; ++i)
            {
                outputDataBox.AppendText(String.Format("{0,10}|{1,5}|{2,10:N3}|{3,10:N3}|{4,10:N3}|{5,10:N3}|{6,10:N3}|{7,10:N3}\r\n",
                    "MOTOR " + Settings.motors[i].motorNumber,
                    Settings.motors[i].label,
                    Settings.motors[i].positionZero,
                    Settings.motors[i].position,
                    Settings.motors[i].positionEnd,
                    Settings.motors[i].speed,
                    Settings.motors[i].maxSpeed,
                    Settings.motors[i].stepSize));
            }
            
        }

        private void consoleTextInput_Enter(object sender, EventArgs e)
        {
            historyCounter = commandHistory.Count - 1;
        }

        //aliases
        private void alias_requestDataAll()
        {
            connector.sendMessage("DR M1");
            connector.sendMessage("DR M2");
            connector.sendMessage("DR M3");
            connector.sendMessage("DR M4");
        }

        private void alias_requestStepSizeAll()
        {
            connector.sendMessage("SR M1");
            connector.sendMessage("SR M2");
            connector.sendMessage("SR M3");
            connector.sendMessage("SR M4");
        }
    }
}
