using System;

namespace _2rc_awaken_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            God god = new God();

            god.BeHoly();
            god.Comfort();
            god.RaiseTheDead();
            god.BeHuman();

            Spencer spencer = new Spencer();
            spencer.BeHuman();
        }
    }
}
