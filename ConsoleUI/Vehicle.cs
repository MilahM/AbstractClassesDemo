using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public abstract string Year { get; set; }
        public abstract string Make { get; set; }
        public abstract string Model { get; set; }

        
        public bool HasWheels { get; set; } = true;
        public bool HasEngine { get; set; } = true;

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("Put the car in drive to accelerate forward.");
        }
    }


}
