using System;

namespace _2rc_awaken_example
{
    public class Spencer : Jesus, IHuman
    {
        public Spencer (string name = nameof(Spencer)) : base(name) {} 
        public new void BeHuman()
        {
            Console.Write("I am {0} and I ", nameof(Spencer));
            Console.WriteLine("can be human! I can do good, but I'm also sinful because of the fall of man");
        }
    }

}