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
                if ((farm.ChickenHouses[i].Capacity) > farm.ChickenHouses[i].GetChickenCount()) {
                    Console.WriteLine ($"{i + 1}. Chicken House currently has {farm.ChickenHouses[i].GetChickenCount()} chicken(s) in stock with a capacity of {farm.ChickenHouses[i].Capacity} chickens."); 

                    // How can I output the type of animal chosen here?
                    Console.WriteLine ($"Place the chicken where?");

                    Console.Write ("> ");
                    int choice = Int32.Parse(Console.ReadLine ());
                    int realChoice = choice - 1;

                    farm.ChickenHouses[realChoice].AddResource(chix);
                    Console.WriteLine($"A chicken has been added to the facility. You now have {farm.ChickenHouses[realChoice].GetChickenCount()} chicken(s) in this house. Press the 'Enter' key to continue");
                    Console.ReadLine();

                } else {
                     Console.WriteLine("You do not currently have the capacity to add this animal. Please add a new facility. Press ENTER to continue.");
                     Console.ReadLine();

                }
            }

           


            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}