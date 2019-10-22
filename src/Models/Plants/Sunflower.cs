using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{

    public class Sunflower : IResource, ICompostProducing, ISeedProducing
    {
        public string Type { get; } = "Sunflower";
        private int _seedsProduced = 650;
        private double _compostKG = 21.6;

        public double HarvestCompost()
        {
            return _compostKG;
        }
        public double HarvestSeed()
        {
            return _seedsProduced;
        }
        public string GetName(){
            return Type;
        }
        public override string ToString () {
            return $"Lightly Salted sunflower seeds. Mmmmm";
        }
    }
}