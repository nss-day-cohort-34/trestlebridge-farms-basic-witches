using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{

    public class Wildflower : IResource, ICompostProducing
    {
        public string Type { get; } = "Wildflower";
        private double _compostKG = 30.3;
        public double HarvestCompost()
        {
            return _compostKG;
        }
    public override string ToString () {
            return $"Here, I picked these for you :)";
        }
    }
}