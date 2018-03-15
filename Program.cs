using System;

namespace _2rc_awaken_example
{
    class Program
    {
        static void Main(string[] args)
        {
            God god = new God();

            Console.WriteLine();
            Console.WriteLine("Things God can do:");
            Console.WriteLine();
            god.BeHoly();
            god.Comfort();
            god.RaiseTheDead();
            god.BeHumanAndPerfect();

            Jesus jesus = new Jesus();
            Console.WriteLine();
            Console.WriteLine("Things Jesus can do:");
            Console.WriteLine();
            jesus.BeHoly();
            jesus.Comfort();
            jesus.RaiseTheDead();
            jesus.BeHumanAndPerfect();

            Console.WriteLine();
            Console.WriteLine("Things Spencer can do:");
            Console.WriteLine();
            Spencer spencer = new Spencer();
            spencer.BeHuman();
        }
    }
}
