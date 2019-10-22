using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    
    public class ChoosePlowedField {

        public static void CollectInput (Farm farm, ISeedProducing seed){
            Console.Clear();
            
            List<PlowedField> availablePlowedFields = new List<PlowedField>();
            for (int i = 0; i < farm.PlowedFields.Count; i++)
            {
                if ((farm.PlowedFields[i].Capacity) > farm.PlowedFields[i].GetPlantCount())
                {
                    availablePlowedFields.Add(farm.PlowedFields[i]);
                }
            }

            int fieldCount = 1;
            if(availablePlowedFields.Count == 0){
                Console.WriteLine("You do not have any available fields to plant this seed.");
                Console.ReadLine();
            }

            for (int i = 0; i < availablePlowedFields.Count; i++)
            {
                while (fieldCount > 0)
                {
                    Console.WriteLine($"{i + 1}: This field currently has {availablePlowedFields[i].GetPlantCount()} rows of plants with a capacity of {availablePlowedFields[i].Capacity} rows.");
                    availablePlowedFields[i].getSesameSeeds();
                    availablePlowedFields[i].getSunflowerSeed();
                    Console.WriteLine($"Press 1 to plant your {seed.GetName()} seeds in this field.");
                    Console.Write("> ");
                    int choice = Int32.Parse(Console.ReadLine());
                    int realChoice = choice - 1;
                    availablePlowedFields[realChoice].AddResource(seed);
                    Console.WriteLine($"1 row of plants have been added to this field. You currently have {availablePlowedFields[realChoice].GetPlantCount()} row(s) in this field. Press the 'Enter' key to continue.");
                    fieldCount--;
                }
                Console.ReadLine();
            }
        }
    }
}