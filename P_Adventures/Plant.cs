using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Adventures
{
    public abstract class Plant
    {
        abstract public string Season { get;}
        abstract public bool Toxicity { get;}

        public abstract void LifePeriodPlant();

    }
    public class Cactus : Plant
    {
        public override string Season => "Summer";

        public override bool Toxicity => false;

        public override void LifePeriodPlant()
        {
            Console.WriteLine("Cactus grows  in Summer");
            Console.WriteLine("Cactus increased in Summer");
        }
    }
    public class Seaweed : Plant
    {
        public override string Season => "Spring, Summer, Autumn";

        public override bool Toxicity => true;

        public override void LifePeriodPlant()
        {
            Console.WriteLine("Seaweed grows in spring and summer");
            Console.WriteLine("Seaweed increased in Autumn");
        }
    }
    public class Fern : Plant
    {
        public override string Season => "Spring";

        public override bool Toxicity => false;

        public override void LifePeriodPlant()
        {
            Console.WriteLine("Fern grows  in Winter and Spring");
            Console.WriteLine("Fern increased in Spring");
        }
    }
}
