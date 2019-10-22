using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions{

    public class SeedOrCompost{
        public static void CollectInput (Farm farm){
            Console.Clear();
            Console.WriteLine("1. Seed");
            Console.WriteLine("2. Compost");
            Console.WriteLine("3. Return");
            Console.WriteLine();
            Console.WriteLine("What will these sunflowers be producing?");
            Console.Write ("> ");
            string choice = Console.ReadLine();
            switch (Int32.Parse(choice))
                {
                    case 1:
                        ChoosePlowedField.CollectInput(farm, new Sunflower());
                        break;
                    case 2:
                        ChooseNaturalField.CollectInput(farm, new Sunflower());
                        break;
                    case 3:
                        break;        
                }
        }
    }
}