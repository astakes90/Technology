using System;

namespace Technology
{
    class Program
    {
        static void Main()
        {
            Computer test = new Computer(2, 3, true);
            Console.WriteLine(test.Storage);
        }
    }
}