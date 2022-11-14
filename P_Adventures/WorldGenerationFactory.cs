using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Adventures
{
    public abstract class WorldGenerationFactory
    {
        abstract public string Title { get;}
        public abstract Plant CreatePlant();
        public abstract Herbivorous CreateHerbivorous();
        public abstract Predator CreatePredator();
    }
    public class DesertWorldFactory : WorldGenerationFactory
    {
        public override string Title => "Desert";

        public override Herbivorous CreateHerbivorous()
        {
            return new Camel();
        }

        public override Plant CreatePlant()
        {
            return new Cactus();
        }

        public override Predator CreatePredator()
        {
            return new Varan();
        }
    }
    public class OceanWorldFactory : WorldGenerationFactory
    {
        public override string Title => "Ocean";

        public override Herbivorous CreateHerbivorous()
        {
            return new WhiteAmur();
        }

        public override Plant CreatePlant()
        {
            return new Seaweed();
        }

        public override Predator CreatePredator()
        {
            return new Shark();
        }
    }
    public class ForestWorldFactory : WorldGenerationFactory
    {
        public override string Title => "Forest";

        public override Herbivorous CreateHerbivorous()
        {
            return new Deer();
        }

        public override Plant CreatePlant()
        {
            return new Fern();
        }

        public override Predator CreatePredator()
        {
            return new Wolf();
        }
    }
}
