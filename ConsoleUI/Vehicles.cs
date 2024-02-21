using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "2005";
        public string Make { get; set; } = "Audi";
        public string Model { get; set; } = "RS7";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Here is a list of Vehicles to chose from:");
        }
    }
}

