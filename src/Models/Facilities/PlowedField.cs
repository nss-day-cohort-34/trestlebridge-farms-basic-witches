using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using System.Linq;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Models.Facilities {

    public class PlowedField : IFacility<ISeedProducing>
    {   
        private double _capacity = 13;
        public double Capacity {
            get {
                return _capacity;
            }
        }
        private Guid _id = Guid.NewGuid();
        private List<ISeedProducing> _rowsOfPlants = new List<ISeedProducing>();
        public void AddResource(ISeedProducing seed)
        {
            _rowsOfPlants.Add(seed);
        }

        public int GetPlantCount(){
            return _rowsOfPlants.Count();
        }

        public void AddResource(List<ISeedProducing> seeds)
        {
            foreach (ISeedProducing seed in seeds)
            {
                _rowsOfPlants.Add(seed);
            }
        }

        //seed count for sesame
          public void getSesameSeeds(){
            List<ISeedProducing>sesameSeedList = _rowsOfPlants.Where(p => p.GetType() == typeof(Sesame)).ToList();
            Console.WriteLine($"You have {sesameSeedList.Count} sesame seed row(s) in this field.");
        }

           public void getSunflowerSeed(){
            List<ISeedProducing>sunFlowerSeedList = _rowsOfPlants.Where(p => p.GetType() == typeof(Sunflower)).ToList();
            Console.WriteLine($"You have {sunFlowerSeedList.Count} sunflower seed row(s) in this field.");
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Plowed field {shortId} has {this._rowsOfPlants.Count} row(s)\n");
            this._rowsOfPlants.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();   
        }
    }
}