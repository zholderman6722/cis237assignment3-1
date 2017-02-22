using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Janitor : Utility
    {
        //list of variables
        protected bool _trashCompactor;
        protected bool _vacuum;

        //Constructors: 8 parameter constructor (string, string, string, bool, bool, bool, bool, bool)
        //Uses the base class (Utility) constructor
        public Janitor(string material, string model, string color, bool toolbox, bool computerConnection, bool arm, bool trashCompactor, bool vacuum)
            : base(material, model, color, toolbox, computerConnection, arm)
        {
            _trashCompactor = trashCompactor;
            _vacuum = vacuum;
        }
        //method to calculate cost of options 
        protected override decimal CalculateOptionsCost()
        {
            //Calculate totalCost by calculating the cost of each selected option and adds it to the base totalCost
            decimal OptionsCost = 0;
            OptionsCost += base.CalculateOptionsCost();
            if (_vacuum)
            {
                OptionsCost += CostPerOption;
            }
            if (_trashCompactor)
            {
                OptionsCost += CostPerOption;
            }
            return OptionsCost;
        }
        public override string ToString()
        {
            string janitorialFeatures = base.ToString();
            if (_trashCompactor)
            {
                janitorialFeatures += "trash Compactor: " + _trashCompactor + Environment.NewLine;
            }
            if (_vacuum)
            {
                janitorialFeatures += "vacuum: " + _vacuum + Environment.NewLine;
            }
            return janitorialFeatures;
        }
    }
}
