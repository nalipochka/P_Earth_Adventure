using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Adventures
{
    public abstract class Herbivorous
    {
        public abstract void Eating();
    }
    public class Camel : Herbivorous
    {
        public override void Eating()
        {
            Console.WriteLine("Camel eating Cactus");
        }
    }
    public class WhiteAmur : Herbivorous
    {
        public override void Eating()
        {
            Console.WriteLine("White Amur eating Seaweed");
        }
    }
    public class Deer : Herbivorous
    {
        public override void Eating()
        {
            Console.WriteLine("Deer eating Fern");
        }
    }
}
