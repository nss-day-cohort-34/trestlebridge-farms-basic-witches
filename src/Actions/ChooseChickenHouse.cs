using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions {
    public class ChooseChickenHouse {
        public static void CollectInput (Farm farm, Chicken chix) {
            Console.Clear();

            for (int i = 0; i < farm.ChickenHouses.Count; i++)
            {
                Console.WriteLine ($"{i + 1}. Chicken House");
            }

            Console.WriteLine ();

            // How can I output the type of animal chosen here?
            Console.WriteLine ($"Place the chicken where?");

            Console.Write ("> ");
            int choice = Int32.Parse(Console.ReadLine ());
            int realChoice = choice - 1;

            farm.ChickenHouses[realChoice].AddResource(chix);
             Console.WriteLine($"A chicken has been added to the facility. You now have {farm.ChickenHouses[realChoice].GetChickenCount()} chicken(s) in this house. Press the 'Enter' key to continue");
            Console.ReadLine();

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}