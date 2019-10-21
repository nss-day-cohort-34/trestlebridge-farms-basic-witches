using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using System.Linq;
using Trestlebridge.Models.Animals;

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
        public void getCows(){
            List<IGrazing>cowList = _animals.Where(a => a.GetType() == typeof(Cow)).ToList();
            Console.WriteLine($"You have {cowList.Count} cows in this field.");
        }
        public void getGoats(){
            List<IGrazing>goatList = _animals.Where(a => a.GetType() == typeof(Goat)).ToList();
            Console.WriteLine($"You have {goatList.Count} goats in this field.");
        }
        public void getOstriches(){
            List<IGrazing>ostrichList = _animals.Where(a => a.GetType() == typeof(Ostrich)).ToList();
            Console.WriteLine($"You have {ostrichList.Count} ostriches in this field.");
        }
        public void getPigs(){
            List<IGrazing>pigList = _animals.Where(a => a.GetType() == typeof(Pig)).ToList();
            Console.WriteLine($"You have {pigList.Count} pigs in this field.");
        }
        public void getSheep(){
            List<IGrazing>sheepList = _animals.Where(a => a.GetType() == typeof(Sheep)).ToList();
            Console.WriteLine($"You have {sheepList.Count} sheeps in this field.");
        }
    

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