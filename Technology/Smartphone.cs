using System;
namespace Technology
{
    public class Smartphone : Computer
    {
        public double NumOfSelfies { get; set; }

        public Smartphone(double ram, double storage, bool hasKeyboard, double NumOfSelfies) : base(ram, storage, hasKeyboard)
        {
            this.NumOfSelfies = NumOfSelfies;
        }

        public double TakeSelfie()
        {
            return NumOfSelfies++;
        }
    }
}

