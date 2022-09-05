using System;
namespace Technology
{
    public class Computer
    {
        public double Ram { get; set; }
        public double Storage { get; set; }
        public readonly bool hasKeyboard;

        public Computer(double ram, double storage, bool hasKeyboard)
        {
            Ram = ram;
            Storage = storage;
            this.hasKeyboard = hasKeyboard;
        }

        public double AddRam(double num)
        {
            return Ram += num;
        }

        public double AddStorage(double num)
        {
            return Storage += num;
        }
    }
}

