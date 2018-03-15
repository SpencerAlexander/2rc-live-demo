using System;

namespace _2rc_awaken_example
{
    public class God : IHolySpirit, IJesus, IHuman
    {
        public God(string name = nameof(God))
        {
            m_name = name;
        }
        public void Comfort()
        {
            Console.Write("I am {0} and I ", m_name);
            Console.WriteLine("am comforted!");
        }

        public void RaiseTheDead()
        {
            Console.Write("I am {0} and I ", m_name);
            Console.WriteLine("can raise the dead!");
        }

        public void BeHoly()
        {
            Console.Write("I am {0} and I ", m_name);
            Console.WriteLine("am holy!");
        }

        public void SpeakInTongues()
        {
            Console.Write("I am {0} and I ", m_name);
            Console.WriteLine("speak in tongues!");
        }

        public void BeHuman()
        {
            Console.Write("I am {0} and I ", m_name);
            Console.WriteLine("can be human!");
        }

        private string m_name = nameof(God);
    }
}