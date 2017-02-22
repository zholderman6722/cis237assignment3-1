using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Protocol : Droid
    {
        protected int _numofLanguages;
        protected const decimal _costperLanguage = 10;

        //Constructors: 4 parameter constructor (string, string, string, int)
        //Uses the base class (Droid) constructor
        public Protocol(string material, string model, string color, int numofLanguages)
            : base(material, model, color)
        {
            _numofLanguages = numofLanguages;
        }
        public override void CalculateTotalCost()
        {
            //Calculate the totalCost based on the number of languages and adds it to the base totalCost
            this.CalculateBaseCost();
            this.TotalCost = this._baseCost + (_numofLanguages * _costperLanguage);
        }
        public override string ToString()
        {
            String tempString = base.ToString();
            tempString += "Number of Languages " + _numofLanguages + Environment.NewLine;
            return tempString;
        }
    }
}
