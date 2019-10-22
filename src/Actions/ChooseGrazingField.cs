using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class ChooseGrazingField {
        
        
        public static void CollectInput (Farm farm, IGrazing animal) {
            Console.Clear();

            List<GrazingField> availableGrazingFields = new List<GrazingField>();
            for (int i = 0; i < farm.GrazingFields.Count; i++)
            {
                if ((farm.GrazingFields[i].Capacity) > farm.GrazingFields[i].GetGrazingAnimalCount())
                {
                    availableGrazingFields.Add(farm.GrazingFields[i]);
                }
            }

            int grazingFieldCount = 1;
            if (availableGrazingFields.Count == 0)
            {
                Console.WriteLine("You do not currently have any houses with enough capacity to add this animal. Please add a new facility. Press ENTER to continue.");
                Console.ReadLine();
            }

            for (int i = 0; i < availableGrazingFields.Count; i++)

            {
                while (grazingFieldCount > 0)
                {
                    // How can I output the type of animal chosen here?
                    Console.WriteLine($"{i + 1}: This grazing field currently has {availableGrazingFields[i].GetGrazingAnimalCount()} animal(s) in stock with a capacity of {availableGrazingFields[i].Capacity} animals.");
                    availableGrazingFields[i].getCows();
                    availableGrazingFields[i].getGoats();
                    availableGrazingFields[i].getOstriches();
                    availableGrazingFields[i].getPigs();
                    availableGrazingFields[i].getSheep();
                    Console.WriteLine($"Enter house number to send animal");
                    Console.Write("> ");
                    int choice = Int32.Parse(Console.ReadLine());
                    int realChoice = choice - 1;
                    availableGrazingFields[realChoice].AddResource(animal);
                    Console.WriteLine($"An animal has been added to the field. You currently have {availableGrazingFields[realChoice].GetGrazingAnimalCount()} animal(s) in this pasture. Press the 'Enter' key to continue.");
                    grazingFieldCount--;
                    Console.ReadLine();
                }
            }
        }
    }
}