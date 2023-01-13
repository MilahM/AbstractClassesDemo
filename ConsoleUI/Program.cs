using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle - DONE
             * The vehicle class shall have three string properties Year, Make, and Model - DONE
             * Set the defaults to something generic in the Vehicle class - DONE
             * Vehicle shall have an abstract method called DriveAbstract with no implementation - DONE
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation. - DONE
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle - DONE
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle - DONE
             * Provide the implementations for the abstract methods - DONE
             * Only in the Motorcycle class will you override the virtual drive method - DONE
            */

            // Create a list of Vehicle called vehicles - DONE

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes - DONE
             * 
             * Set the properties with object initializer syntax - DONE
             */

            /*
             * Add the 4 vehicles to the list - DONE
             * Using a foreach loop iterate over each of the properties - DONE
             */

            // Call each of the drive methods for one car and one motorcycle - DONE


            var vehicles = new List<Vehicle>();

            var car = new Car()
            {
                Year = "2022",
                Make = "Hyundai",
                Model = "Sonata"
            };
            var motorcycle = new Motorcycle()
            {
                Year = "2022",
                Make = "Ducati",
                Model = "Model X"
            };
            Vehicle vehicle1 = new Car()
            {
                Year = "2020",
                Make = "Honda",
                Model = "Civic"
            };
            Vehicle vehicle2 = new Motorcycle()
            {
                Year = "2023",
                Make = "Harley Davidson",
                Model = "Sportster"
            };

            vehicles.Add(car);
            vehicles.Add(motorcycle);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}");
                Console.WriteLine($"Make: {vehicle.Make}");
                Console.WriteLine($"Model: {vehicle.Model}");
                vehicle.DriveVirtual();
                vehicle.DriveAbstract();
                Console.WriteLine();
            }

            #endregion            
            Console.ReadLine();
        }
    }
}
