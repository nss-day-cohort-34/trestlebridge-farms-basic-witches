using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {

    public class PurchaseSeed{
        public static void CollectInput (Farm farm){
            Console.WriteLine ("1. Sesame");
            Console.WriteLine ("2. Sunflower");
            Console.WriteLine ("3. Wildflower");
            Console.WriteLine ("4. Return");
            Console.WriteLine ();
            Console.WriteLine ("What seed are you buying today?");
            Console.Write (">");
            string choice = Console.ReadLine();

            try {
                switch (Int32.Parse(choice))
                {
                    case 1: 
                        ChoosePlowedField.CollectInput(farm, new Sesame());
                        break;
                    case 2:
                        SeedOrCompost.CollectInput(farm);
                        break;
                    case 3:
                        ChooseNaturalField.CollectInput(farm, new Wildflower());
                        break;        
                    case 4: 
                        break;   
                    default:
                    Console.WriteLine("You entered an invalid entry. Please press ENTER to try again.");
                    Console.ReadLine();
                    Console.Clear();
                    CollectInput(farm);
                    break;    
                }
            } catch {

                Console.WriteLine("You entered an invalid entry. Press ENTER and try again.");
                Console.ReadLine();
                Console.Clear();
                CollectInput(farm);
            }
            
        }
    }
}