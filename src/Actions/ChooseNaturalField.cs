using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    
    public class ChooseNaturalField {

        public static void CollectInput (Farm farm, ICompostProducing seed){
            Console.Clear();
            
            List<NaturalField> availableNaturalFields = new List<NaturalField>();
            for (int i = 0; i < farm.NaturalFields.Count; i++)
            {
                if ((farm.NaturalFields[i].Capacity) > farm.NaturalFields[i].GetPlantCount())
                {
                    availableNaturalFields.Add(farm.NaturalFields[i]);
                }
            }

            int fieldCount = 1;
            if(availableNaturalFields.Count == 0){
                Console.WriteLine("You do not have any available fields to plant this seed.");
                Console.ReadLine();
            }

            for (int i = 0; i < availableNaturalFields.Count; i++)
            {
                while (fieldCount > 0)
                {
                    Console.WriteLine($"{i + 1}: This field currently has {availableNaturalFields[i].GetPlantCount()} rows of plants with a capacity of {availableNaturalFields[i].Capacity} rows.");
                    availableNaturalFields[i].getSunflowers();
                    availableNaturalFields[i].getWildflowers();
                    Console.WriteLine($"Press 1 to plant your {seed.GetName()} seeds in this field.");
                    Console.Write("> ");
                    int choice = Int32.Parse(Console.ReadLine());
                    int realChoice = choice - 1;
                    availableNaturalFields[realChoice].AddResource(seed);
                    Console.WriteLine($"1 row of plants have been added to this field. You currently have {availableNaturalFields[realChoice].GetPlantCount()} row(s) in this field. Press the 'Enter' key to continue.");
                    fieldCount--;
                }
                Console.ReadLine();
            }
        }
    }
}