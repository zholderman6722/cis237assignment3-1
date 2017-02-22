using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates a new collection of droids and sets it to a size of 50
            DroidCollection droids = new DroidCollection(50);
            //Display the menu for droid builder
            //instanciates a new userinterface and since all the work is being done in 
            //userinterface pass the droidcollection into it...
            UserInterface ui = new UserInterface(droids);
            //Display Menu and begin work...
            ui.DisplayMenu();
        }
    }
}
