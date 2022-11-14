using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Adventures
{
    public class World
    {
        private string title;
        public string Title
        {
            get { return title; }
        }

        private Plant plant;
        private Herbivorous herbivorous;
        private Predator predator;
        public World(WorldGenerationFactory factory)
        {
            title = factory.Title;
            plant = factory.CreatePlant();
            herbivorous = factory.CreateHerbivorous();
            predator = factory.CreatePredator();
        }
        public void PlantLife()
        {
            plant.LifePeriodPlant();
        }
        public void HerbivorusLife()
        {
            herbivorous.Eating();
        }
        public void PredatorLife()
        {
            predator.EatAnimal();
        }
    }
}
