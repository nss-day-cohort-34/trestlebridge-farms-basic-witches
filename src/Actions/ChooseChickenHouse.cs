using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class ChooseChickenHouse
    {
        public static void CollectInput(Farm farm, Chicken chicken)
        {
            Console.Clear();

            List<ChickenHouse> availableChickenHouses = new List<ChickenHouse>();
            for (int i = 0; i < farm.ChickenHouses.Count; i++)
            {
                if ((farm.ChickenHouses[i].Capacity) > farm.ChickenHouses[i].GetChickenCount())
                {
                    availableChickenHouses.Add(farm.ChickenHouses[i]);
                }
            }

            int chickenCount = 1;
            if (availableChickenHouses.Count == 0)
            {
                Console.WriteLine("You do not currently have any houses with enough capacity to add this animal. Please add a new facility. Press ENTER to continue.");
                Console.ReadLine();
            }

            for (int i = 0; i < availableChickenHouses.Count; i++)

            {
                while (chickenCount > 0)
                {
                    // How can I output the type of animal chosen here?
                    Console.WriteLine($"{i + 1}: This chicken house currently has {availableChickenHouses[i].GetChickenCount()} chicken(s) in stock with a capacity of {availableChickenHouses[i].Capacity} chickens.");
                    Console.WriteLine($"Enter house number to send chicken");
                    Console.Write("> ");
                    int choice = Int32.Parse(Console.ReadLine());
                    int realChoice = choice - 1;
                    availableChickenHouses[realChoice].AddResource(chicken);
                    Console.WriteLine($"A chicken has been added to the facility. You currently have {availableChickenHouses[realChoice].GetChickenCount()} chicken(s) in this house. Press the 'Enter' key to continue.");
                    chickenCount--;
                    Console.ReadLine();
                }
            }
        }
    }
}

