using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using System.Linq;

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

        public void AddResource(List<ICompostProducing> seeds)
        {
            foreach (ICompostProducing seed in seeds)
            {
                _rowsOfPlants.Add(seed);
            }
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