using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Utility : Droid
    {

        protected bool _toolbox;
        protected bool _computerConnection;
        protected bool _arm;
        //Constant variable that can be used in  this class or any child class
        protected const decimal CostPerOption = 25.00m;


        //Constructors: 6 parameter constructor (string, string, string, bool, bool, bool)
        //Uses the base class (Droid) constructor
        public Utility(String material, string model, string color, bool toolbox, bool computerConnection, bool arm)
            : base(material, model, color)
        {
            _toolbox = toolbox;
            _computerConnection = computerConnection;
            _arm = arm;
        }
        //protected virtual method to calculate cost if user chooses to add options to utility.
        protected virtual decimal CalculateOptionsCost()
        {
            decimal optionsCost = 0;
            if (_arm)
            {
                optionsCost += CostPerOption;
            }
            if (_computerConnection)
            {
                optionsCost += CostPerOption;
            }
            return optionsCost;
        }
        //Tostring method to concatenate list of available options to the utility droid
        public override string ToString()
        {
            String tempString = base.ToString();
            //If it has a toolbox add it to list of options.
            if (_toolbox)
            {
                tempString += "Tool Box: " + _toolbox + Environment.NewLine;
            }
            if (_computerConnection)
            {
                tempString += "Computer Connection: " + _computerConnection + Environment.NewLine;
            }
            if (_arm)
            {
                tempString += "Arm: " + _arm + Environment.NewLine;
            }
            return tempString;
        }

        public override void CalculateTotalCost()
        {
            this.CalculateBaseCost();
            this.TotalCost = this._baseCost + this.CalculateOptionsCost();
        }

    }
}

