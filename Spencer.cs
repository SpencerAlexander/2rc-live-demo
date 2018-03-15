using System;

namespace _2rc_awaken_example
{
    public class Spencer : IHuman
    {
        public Spencer (string name = nameof(Spencer)) {} 
        public void BeHuman()
        {
            Console.Write("I am {0} and I ", nameof(Spencer));
            Console.WriteLine("can be human! I can do good, but I'm also sinful because of the fall of man");
        }
    }

}