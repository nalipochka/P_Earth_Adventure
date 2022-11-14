using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Adventures
{
    public abstract class Predator
    {
        public abstract void EatAnimal();
    }
    public class Varan : Predator
    {
        public override void EatAnimal()
        {
            Console.WriteLine("Varan eating Camel");
        }
    }
    public class Shark : Predator
    {
        public override void EatAnimal()
        {
            Console.WriteLine("Shark eating White Amur");
        }
    }
    public class Wolf : Predator
    {
        public override void EatAnimal()
        {
            Console.WriteLine("Wolf eating Deer");
        }
    }
}
