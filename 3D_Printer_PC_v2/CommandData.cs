﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Printer_PC_v2
{
    public class CommandData
    {
        public const int MAX_ARGS_NUM = 6;
        public delegate void Executable(CommandData args);

        public double[] arguments { get; set; } = new double[MAX_ARGS_NUM];
        public Executable execute { get; set; }
        public MotorSettings motor { get; set; }
    }
}
