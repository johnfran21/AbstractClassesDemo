using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("You get a Motorcycle to drive.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("You get a Motorcycle to drive with override.");
        }
    }
}

