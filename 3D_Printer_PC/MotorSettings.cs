using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Printer_PC
{
    public class MotorSettings
    {
        public int motorNumber { get; }

        public double position { get; set; }
        public double speed { get; set; }

        public double maxSpeed { get; set; }
        public double positionZero { get; set; }
        public double positionEnd { get; set; }

        public MotorSettings(int motorNumber)
        {
            this.motorNumber = motorNumber;
        }

        public void dataUpdate()
        {
            switch (motorNumber)
            {
                case 1: if (Form1.motorController1Status) Form1.mc1.updateData(this); break;
                case 2: if (Form1.motorController2Status) Form1.mc2.updateData(this); break;
                case 3: if (Form1.motorController34Status) Form1.mc34.updateMotor3Data(this); break;
                case 4: if (Form1.motorController34Status) Form1.mc34.updateMotor4Data(this); break;
                case 5: if (Form1.motorController5Status) Form1.mc5.updateData(this); break;
            }
        }
    }
}
