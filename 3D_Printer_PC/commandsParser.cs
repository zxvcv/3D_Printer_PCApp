using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Printer_PC
{
    public static class CommandsParser
    {
        private static Dictionary<string, CommandData.Executable> cmds;

        static CommandsParser()
        {
            cmds = new Dictionary<string, CommandData.Executable>();
            cmds.Add("M1D", dataMotor1);
        }

        public static CommandData parseCommand(string command)
        {
            string[] splited = command.Split(new char[] { ' ' });
            double[] args = new double[splited.Length - 1];
            for (int i = 1; i < CommandData.MAX_ARGS_NUM || i < splited.Length; ++i)
                args[i - 1] = Double.Parse(splited[i].Replace('.', ','));

            CommandData data = new CommandData();
            data.arguments = args;
            CommandData.Executable exe;
            cmds.TryGetValue(splited[0], out exe);
            data.execute = exe;
            return data;
        }

        public static void executeCommand(CommandData data)
        {
            data.execute(data.arguments);
        }

        //commands
        private static void dataMotor1(double[] args)
        {
            Settings.motor1.position = args[0];
            Settings.motor1.positionZero = args[1];
            Settings.motor1.positionEnd = args[2];
            Settings.motor1.speed = args[3];
            Settings.motor1.maxSpeed = args[4];
            Settings.motor1.update();
        }
    }
}
