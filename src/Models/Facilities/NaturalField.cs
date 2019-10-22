using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using System.Linq;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Models.Facilities {

    public class NaturalField : IFacility<ICompostProducing>
    {   
        private double _capacity = 10;
        public double Capacity {
            get {
                return _capacity;
            }
        }

        private Guid _id = Guid.NewGuid();
        private List<ICompostProducing> _rowsOfPlants = new List<ICompostProducing>();
        public void AddResource(ICompostProducing seed)
        {
            _rowsOfPlants.Add(seed);
        }

        public int GetPlantCount(){
            return _rowsOfPlants.Count();
        }
        public void AddResource(List<ICompostProducing> seeds)
        {
            foreach (ICompostProducing seed in seeds)
            {
                _rowsOfPlants.Add(seed);
            }
        }

        //get count per plant type for natural fields (sunflower and wildflower)
         public void getSunflowers(){
            List<ICompostProducing>sunflowerList = _rowsOfPlants.Where(p => p.GetType() == typeof(Sunflower)).ToList();
            Console.WriteLine($"You have {sunflowerList.Count} sunflower row(s) in this field.");
        }

        public void getWildflowers(){
            List<ICompostProducing>wildflowerList = _rowsOfPlants.Where(p => p.GetType() == typeof(Wildflower)).ToList();
            Console.WriteLine($"You have {wildflowerList.Count} wildflower row(s) in this field.");
        }

         public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Natural field {shortId} has {this._rowsOfPlants.Count} plants\n");
            this._rowsOfPlants.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}