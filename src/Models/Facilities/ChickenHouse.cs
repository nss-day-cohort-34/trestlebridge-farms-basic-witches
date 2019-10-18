using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Models.Facilities {
    public class ChickenHouse : IFacility<Chicken>
    {
        private int _capacity = 50;
        private Guid _id = Guid.NewGuid();


        public double Capacity {
            get {
                return _capacity;
            }
        }
        List<Chicken> ChickensList = new List<Chicken>();
        public void AddResource (Chicken chicken)
        {
            // TODO: implement this...
            ChickensList.Add(chicken);
            Console.WriteLine($"{this._id}");
        }

        public void AddResource (List<Chicken> chickens) 
        {
            foreach (Chicken chicken in chickens)
            {
                ChickensList.Add(chicken);
            }
           
        }


        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Chicken House {shortId} has {this.ChickensList.Count} chickens\n");
            this.ChickensList.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }

 
}