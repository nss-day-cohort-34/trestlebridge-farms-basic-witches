using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class CreateFacility {
        public static void CollectInput (Farm farm) {
            Console.WriteLine ("1. Grazing field");
            Console.WriteLine ("2. Plowed field");
            Console.WriteLine ("3. Chicken House");
            Console.WriteLine ("4. Duck House");

            Console.WriteLine ();
            Console.WriteLine ("Choose what you want to create");

            Console.Write ("> ");
            string input = Console.ReadLine ();

            switch (Int32.Parse(input))
            {
                case 1:
                    farm.AddGrazingField(new GrazingField());
                    Console.WriteLine($"You have successfully added a new grazing field! Press ENTER to continue.");
                    Console.ReadLine();
                    break;

                case 2:
                    farm.AddGrazingField(new GrazingField());
                    Console.WriteLine($"You have successfully added a new grazing field! Press ENTER to continue.");
                    Console.ReadLine();
                    break;

                case 3:
                    farm.AddChickenHouse(new ChickenHouse());  
                    Console.WriteLine($"You have successfully added a new chicken house! Press ENTER to continue.");
                    Console.ReadLine(); 
                    break; 
                case 4:
                    farm.AddDuckHouse(new DuckHouse());   
                    Console.WriteLine($"You have successfully added a new duck house! Press ENTER to continue.");
                    Console.ReadLine();
                    break; 
            }

            
        }
    }
}