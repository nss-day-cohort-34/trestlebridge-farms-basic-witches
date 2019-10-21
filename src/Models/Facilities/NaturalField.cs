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
    }
}