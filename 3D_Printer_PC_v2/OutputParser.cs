using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Printer_PC_v2
{
    class OutputParser
    {
        private const int MOTORS_NUM = 4;

        public static bool parse(string input, out string output)
        {
            output = "";
            if (input == "")
                return false;

            string[] splitted = input.Split(' ');
            string temp = "";

            Dictionary<string, string> args = new Dictionary<string, string>();

            //getting all args into dictionary
            for (int i=1; i<splitted.Length; ++i)
            {
                if(String.Compare(splitted[i].Substring(0, 2).ToLower(), "-m") == 0)
                {
                    for(int j=2; j<splitted[i].Length; ++j)
                    {
                        if ((int)Char.GetNumericValue(splitted[i][j]) <= MOTORS_NUM && (int)Char.GetNumericValue(splitted[i][j]) >= 1)
                        {
                            temp += splitted[i][j];
                        }
                        else return false;
                    }
                    args.Add("M", temp);
                    temp = "";
                }
                else if(String.Compare(splitted[i].Substring(0, 2).ToLower(), "-v") == 0)
                {
                    if (Double.TryParse(splitted[2].Substring(2), out double arg))
                    {
                        temp += arg.ToString();
                    }
                    else return false;
                    args.Add("V", temp);
                    temp = "";
                }
                else return false;
            }

            string m, v;
            //check args number
            switch(splitted[0])
            {
                case "clear":
                    if (!args.TryGetValue("M", out m) && !args.TryGetValue("V", out v) && splitted.Length == 1)
                    {
                        output = splitted[0];
                        break;
                    }
                    else return false;

                case "help":
                    if (!args.TryGetValue("M", out m) && !args.TryGetValue("V", out v) && splitted.Length == 1)
                    {
                        output = splitted[0];
                        break;
                    }
                    else return false;

                case "data_request":
                    if (args.TryGetValue("M", out m) && !args.TryGetValue("V", out v) && splitted.Length == 2 && m.Length == 1)
                    {
                        output = "DR M" + m;
                        break;
                    }
                    else return false;

                case "position_move":
                    if (args.TryGetValue("M", out m) && args.TryGetValue("V", out v) && splitted.Length == 3 && m.Length == 1)
                    {
                        output = "PM M" + m + " " + v;
                        break;
                    }
                    else return false;

                case "position_value_set":
                    if (args.TryGetValue("M", out m) && args.TryGetValue("V", out v) && splitted.Length == 3 && m.Length == 1)
                    {
                        output = "PV M" + m + " " + v;
                        break;
                    }
                    else return false;

                case "position_zero_set":
                    if (args.TryGetValue("M", out m) && args.TryGetValue("V", out v) && splitted.Length == 3 && m.Length == 1)
                    {
                        output = "PZ M" + m + " " + v;
                        break;
                    }
                    else return false;

                case "position_end_set":
                    if (args.TryGetValue("M", out m) && args.TryGetValue("V", out v) && splitted.Length == 3 && m.Length == 1)
                    {
                        output = "PE M" + m + " " + v;
                        break;
                    }
                    else return false;

                case "distance_move":
                    if (args.TryGetValue("M", out m) && args.TryGetValue("V", out v) && splitted.Length == 3 && m.Length >= 1 && m.Length <= 2)
                    {
                        output = "DM M" + m + " " + v;
                        break;
                    }
                    else return false;

                case "speed_set":
                    if (args.TryGetValue("M", out m) && args.TryGetValue("V", out v) && splitted.Length == 3 && m.Length >= 1 && m.Length <= 2)
                    {
                        output = "SS M" + m + " " + v;
                        break;
                    }
                    else return false;

                case "speed_max_set":
                    if (args.TryGetValue("M", out m) && args.TryGetValue("V", out v) && splitted.Length == 3 && m.Length >= 1 && m.Length <= 2)
                    {
                        output = "SM M" + m + " " + v;
                        break;
                    }
                    else return false;

                case "step_size_request":
                    if (args.TryGetValue("M", out m) && !args.TryGetValue("V", out v) && splitted.Length == 2 && m.Length == 1)
                    {
                        output = "SR M" + m;
                        break;
                    }
                    else return false;

                case "step_size_set":
                    if (args.TryGetValue("M", out m) && args.TryGetValue("V", out v) && splitted.Length == 3 && m.Length == 1)
                    {
                        output = "SP M" + m + " " + v;
                        break;
                    }
                    else return false;

                case "program_run_SD":
                    if (!args.TryGetValue("M", out m) && !args.TryGetValue("V", out v) && splitted.Length == 1)
                    {
                        output = "CR";
                        break;
                    }
                    else return false;

                //aliases
                case "data_request_all":
                case "step_size_request_all":
                    if (!args.TryGetValue("M", out m) && !args.TryGetValue("V", out v) && splitted.Length == 1)
                    {
                        output = splitted[0];
                        break;
                    }
                    else return false;

                default: 
                    return false;
            }
            return true;
        }
    }
}
