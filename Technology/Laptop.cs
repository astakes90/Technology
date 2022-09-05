using System;
namespace Technology
{
    public class Laptop : Computer
    {
        public double Weight { get; set; }
        
        public Laptop(double ram, double storage, bool hasKeyboard, double weight) : base(ram, storage, hasKeyboard)
        {
            Weight = weight;
        }

        public string CheckWeight()
        {
            return $"The laptop weighs {this.Weight} oz.";
        }
    }
}

