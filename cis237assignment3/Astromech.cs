using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Astromech : Utility
    {
        //List of Variables
        protected bool _fireExtinguisher;
        protected int _numberShips;

        protected decimal CostPerShip = 1000.00m;

        //Constructors: 8 parameter constructor (string, string, string, bool, bool, bool, bool, int)
        //Uses the base class (Utility) constructor
        public Astromech(string material, string model, string color, bool toolbox, bool computerConnection, bool arm, bool fireExtinguisher, int numberships)
            : base(material, model, color, toolbox, computerConnection, arm)
        {
            _fireExtinguisher = fireExtinguisher;
            _numberShips = numberships;
        }
        //Method to calculate total cost of ships

        //Method to concat strings
        public override string ToString()
        {
            String tempString = base.ToString();
            if (_fireExtinguisher)
            {
                tempString += "Fire Extinguisher";
            }
            tempString += "Number of Ships: " + _numberShips;
            return tempString;
        }
        protected virtual decimal CalculateCostOfAllShips()
        {
            return CostPerShip * _numberShips;
        }
        public override void CalculateTotalCost()
        {
            //Calculate totalCost by calculating the cost of each selected option and the cost based on the number of ships 
            //and adds both to the base CalculateTotalCost
            this.CalculateBaseCost();
            this.TotalCost = this._baseCost + this.CalculateCostOfAllShips() + this.CalculateOptionsCost();

        }
    }
}

