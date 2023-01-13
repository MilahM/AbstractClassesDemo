using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("Put the car in drive and press gas to accelerate forward.");
        }

        public bool HasATrunk { get; set; } = true;

        public override string Year { get; set; }
        public override string Make { get; set; }
        public override string Model { get; set; }
        
    }
}
