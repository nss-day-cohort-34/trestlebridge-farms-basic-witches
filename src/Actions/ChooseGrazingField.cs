using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions {
    public class ChooseGrazingField {
        
        
        public static void CollectInput (Farm farm, IGrazing animal) {
            Console.Clear();

            for (int i = 0; i < farm.GrazingFields.Count; i++)
            {
                if ((farm.GrazingFields[i].Capacity) >= farm.GrazingFields[i].GetGrazingAnimalCount()) {
                    Console.WriteLine ($"{i + 1}. The grazing field currently has {farm.GrazingFields[i].GetGrazingAnimalCount()} grazing animal(s) in stock with a capacity of {farm.GrazingFields[i].Capacity} grazing animals.");   
                }
            }

            Console.WriteLine ();

            // How can I output the type of animal chosen here?
            Console.WriteLine ($"Place the animal where?");

            Console.Write ("> ");
            int choice = Int32.Parse(Console.ReadLine ());
            int realChoice = choice - 1;

            farm.GrazingFields[realChoice].AddResource(animal);
            Console.WriteLine($"A {animal} has been added to the facility. You currently have {farm.GrazingFields[realChoice].GetGrazingAnimalCount()} grazing animal(s) in this house. Press the 'Enter' key to continue.");
            Console.ReadLine();

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}