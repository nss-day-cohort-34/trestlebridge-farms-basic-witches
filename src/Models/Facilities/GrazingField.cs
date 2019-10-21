using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using System.Linq;

namespace Trestlebridge.Models.Facilities {
    public class GrazingField : IFacility<IGrazing>
    {
        private int _capacity = 50;
        private Guid _id = Guid.NewGuid();

        private List<IGrazing> _animals = new List<IGrazing>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

          //method for returning count of grazing animals
          public int GetGrazingAnimalCount() {
            return _animals.Count();
        }

        public void AddResource (IGrazing animal)
        {
            // TODO: implement this...
            _animals.Add(animal);
            
        }

        public void AddResource (List<IGrazing> animals) 
        {
            foreach (IGrazing animal in animals)
            {
                _animals.Add(animal);
            }
           
        }

        //get animals by type
    

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Grazing field {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}