using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    abstract class Droid : IDroid
    {
        //list of variables required for droid class
        protected string _material;
        protected string _model;
        protected string _color;
        protected decimal _baseCost;
        protected decimal _totalCost;

        //Constructors: 3 parameter constructor (string, string, string)
        public Droid(string material, string model, string color)
        {
            _material = material;
            _model = model;
            _color = color;
        }

        //public property Property: TotalCost to return the cost of the droid (Required by the interface)
        public decimal TotalCost
        {
            get
            {
                return _totalCost;
            }

            set
            {
                _totalCost = value;
            }
        }
        public abstract void CalculateTotalCost();

        //Virtual Method that can be overriden in derived classes.
        //CalculateBaseCost: Determines the baseCost based on material.
        protected virtual void CalculateBaseCost()
        {
            if (_material.Equals("Runite"))
            {
                this._baseCost = 500.00m;
            }
            if (_material.Equals("adamantite"))
            {
                this._baseCost = 350.00m;
            }
            if (_material.Equals("Mithril"))
            {
                this._baseCost = 200.00m;
            }
            else
            {
                this._baseCost = 50.00m;
            }
        }
        public override string ToString()
        {
            return "Material: " + this._material + Environment.NewLine + "Model: " + this._model + Environment.NewLine + "Color: " + this._color + Environment.NewLine;
        }
    }
}


