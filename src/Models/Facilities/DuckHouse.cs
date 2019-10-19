using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Animals;
using System.Linq;

namespace Trestlebridge.Models.Facilities {
    public class DuckHouse : IFacility<Duck>
    {
        private int _capacity = 50;
        private Guid _id = Guid.NewGuid();


        public double Capacity {
            get {
                return _capacity;
            }
        }

          //method for returning count of ducks
          public int GetDuckCount() {
            return DucksList.Count();
        }

        List<Duck> DucksList = new List<Duck>();
        public void AddResource (Duck duck)
        {
            // TODO: implement this...
            DucksList.Add(duck);
            Console.WriteLine($"{this._id}");
        }

        public void AddResource (List<Duck> ducks) 
        {
            foreach (Duck duck in ducks)
            {
                DucksList.Add(duck);
            }
           
        }


        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Duck House {shortId} has {this.DucksList.Count} ducks\n");
            this.DucksList.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }

 
}