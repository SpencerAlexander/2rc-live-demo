using System;

namespace _2rc_awaken_example
{
    class Program
    {
        static void Main(string[] args)
        {
            God god = new God();
            Console.WriteLine("\nThings God can do:\n");
            god.BeHoly();
            god.Comfort();
            god.RaiseTheDead();
            god.BeHumanAndPerfect();

            Jesus jesus = new Jesus();
            Console.WriteLine("\nThings Jesus can do:\n");
            jesus.BeHoly();
            jesus.Comfort();
            jesus.RaiseTheDead();
            jesus.BeHumanAndPerfect();

            Spencer spencer = new Spencer();
            Console.WriteLine("\nThings Spencer can do:\n");
            spencer.BeHuman();
        }
    }
}
