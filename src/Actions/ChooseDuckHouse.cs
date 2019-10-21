using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class ChooseDuckHouse
    {
        public static void CollectInput(Farm farm, Duck duck)
        {
            Console.Clear();

            List<DuckHouse> availableHouses = new List<DuckHouse>();
            for (int i = 0; i < farm.DuckHouses.Count; i++)
            {
                if ((farm.DuckHouses[i].Capacity) > farm.DuckHouses[i].GetDuckCount())
                {
                    availableHouses.Add(farm.DuckHouses[i]);
                }
            }

            int duckCount = 1;
            if (availableHouses.Count == 0)
            {
                Console.WriteLine("You do not currently have any houses with enough capacity to add this animal. Please add a new facility. Press ENTER to continue.");
                Console.ReadLine();
            }

            for (int i = 0; i < availableHouses.Count; i++)

            {
                while (duckCount > 0)
                {
                    // How can I output the type of animal chosen here?
                    Console.WriteLine($"{i + 1}: This duck house currently has {availableHouses[i].GetDuckCount()} duck(s) in stock with a capacity of {availableHouses[i].Capacity} ducks.");
                    Console.WriteLine($"Enter house number to send duck");
                    Console.Write("> ");
                    int choice = Int32.Parse(Console.ReadLine());
                    int realChoice = choice - 1;
                    availableHouses[realChoice].AddResource(duck);
                    Console.WriteLine($"A duck has been added to the facility. You currently have {availableHouses[realChoice].GetDuckCount()} duck(s) in this house. Press the 'Enter' key to continue.");
                    duckCount--;
                }
            Console.ReadLine();
            }
        }
    }
}

