using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("Squeeze handle to accelerate forward.");
        }

        public int NumberOfWheels { get; set; } = 2;

        public override void DriveVirtual()
        {
            Console.WriteLine("Squeeze the accelerator to move forward.");
        }

        public override string Year { get; set; }
        public override string Make { get; set; }
        public override string Model { get; set; }

    }
}
