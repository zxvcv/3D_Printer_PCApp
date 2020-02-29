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
            cmds.Add("DT", dataMotor);
        }

        public static CommandData parseCommand(string command)
        {
            string[] splited = command.Split(new char[] { ' ' });
            CommandData data = new CommandData();
            int argPos = 0;

            //command
            CommandData.Executable exe = null;
            cmds.TryGetValue(splited[0], out exe);
            data.execute = exe;

            if(exe != null)
            {
                if (splited[0].Equals("DT"))
                {
                    argPos = 2;
                    data.arguments = new double[5];
                    switch (splited[1][1])
                    {
                        case '1': data.motor = Settings.motor1; break;
                        case '2': data.motor = Settings.motor2; break;
                        case '3': data.motor = Settings.motor3; break;
                        case '4': data.motor = Settings.motor4; break;
                        case '5': data.motor = Settings.motor5; break;
                        default: data.motor = null; break;
                    }
                }
            }

            for (int i = argPos; i < data.arguments.Length + argPos; ++i)
                data.arguments[i - argPos] = Double.Parse(splited[i].Replace('.', ','));

            return data;
        }

        public static void executeCommand(CommandData data)
        {
            data.execute(data);
        }

        //commands
        private static void dataMotor(CommandData args)
        {
            args.motor.position = args.arguments[0];
            args.motor.positionZero = args.arguments[1];
            args.motor.positionEnd = args.arguments[2];
            args.motor.speed = args.arguments[3];
            args.motor.maxSpeed = args.arguments[4];
            
            args.motor.dataUpdate();
        }
    }
}
