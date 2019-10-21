using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using System.Linq;

namespace Trestlebridge.Models.Facilities {

    public class PlowedField : IFacility<ISeedProducing>
    {   
        private double _capacity = 13;
        public double Capacity {
            get {
                return _capacity;
            }
        }
        private List<ISeedProducing> _rowsOfPlants = new List<ISeedProducing>();
        public void AddResource(ISeedProducing seed)
        {
            _rowsOfPlants.Add(seed);
        }

        public void AddResource(List<ISeedProducing> seeds)
        {
            foreach (ISeedProducing seed in seeds)
            {
                _rowsOfPlants.Add(seed);
            }
        }
    }
}