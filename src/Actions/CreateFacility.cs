using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class CreateFacility {
        public static void CollectInput (Farm farm) {
            Console.WriteLine ("1. Grazing field");
            // Console.WriteLine ("2. Plowed field");
            Console.WriteLine ("2. Chicken House");
            Console.WriteLine ("3. Duck House");
            Console.WriteLine ("4. Natural Field");
            Console.WriteLine ("5. Plowed Field");
            Console.WriteLine ("6. Return");

            Console.WriteLine ();
            Console.WriteLine ("Choose what you want to create");

            Console.Write ("> ");
            string input = Console.ReadLine ();

            switch (Int32.Parse(input))
            {
                case 1:
                    farm.AddGrazingField(new GrazingField());
                    Console.WriteLine($"You have successfully added a new grazing field! You now have {farm.GrazingFields.Count()} grazing fields. Press ENTER to continue.");
                    Console.ReadLine();
                    break;

                case 2:
                    farm.AddChickenHouse(new ChickenHouse());  
                    Console.WriteLine($"You have successfully added a new chicken house! You now have {farm.ChickenHouses.Count()} chicken house(s)' Press ENTER to continue.");
                    Console.ReadLine(); 
                    break; 
                case 3:
                    farm.AddDuckHouse(new DuckHouse());   
                    Console.WriteLine($"You have successfully added a new duck house! You now have {farm.DuckHouses.Count()} duck house(s). Press ENTER to continue.");
                    Console.ReadLine();
                    break; 
                 case 4:
                    farm.AddNaturalField(new NaturalField());   
                    Console.WriteLine($"You have successfully added a new natural field! You now have {farm.NaturalFields.Count()} natural field(s). Press ENTER to continue.");
                    Console.ReadLine();
                    break;  
                 case 5:
                    farm.AddPlowedField(new PlowedField());   
                    Console.WriteLine($"You have successfully added a new plowed field! You now have {farm.PlowedFields.Count()} plowed field(s). Press ENTER to continue.");
                    Console.ReadLine();
                    break;     
                case 6:
                    break;    
            }

            
        }
    }
}