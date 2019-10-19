using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions {
    public class ChooseDuckHouse {
        public static void CollectInput (Farm farm, Duck duck) {
            Console.Clear();

            for (int i = 0; i < farm.DuckHouses.Count; i++)
            {
                if ((farm.DuckHouses[i].Capacity) >= farm.DuckHouses[i].GetDuckCount()) {
                   Console.WriteLine ($"{i + 1}. Duck House currently has {farm.DuckHouses[i].GetDuckCount()} duck(s) in stock with a capacity of {farm.DuckHouses[i].Capacity} ducks."); 
                }
                
            }

            Console.WriteLine ();

            // How can I output the type of animal chosen here?
            Console.WriteLine ($"Place the duck where?");

            Console.Write ("> ");
            int choice = Int32.Parse(Console.ReadLine ());
            int realChoice = choice - 1;

            farm.DuckHouses[realChoice].AddResource(duck);
            Console.WriteLine($"A duck has been added to the facility. You currently have {farm.DuckHouses[realChoice].GetDuckCount()} duck(s) in this house. Press the 'Enter' key to continue.");
            Console.ReadLine();

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}