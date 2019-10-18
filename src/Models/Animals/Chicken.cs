using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Chicken : IResource, IMeatProducing
    {
        private Guid _id = Guid.NewGuid();
        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        private double _meatProduced = 1.7;
        public string Type { get; } = "Chicken";

        public double Butcher()
        {
            return _meatProduced;
        }
        public override string ToString()
        {
            return $"Chicken {this._shortId}. Cock-a-doodle Doo!";
        }
    }
}
