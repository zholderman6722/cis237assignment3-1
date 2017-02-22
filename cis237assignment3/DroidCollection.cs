using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class DroidCollection : IDroidCollection
    {
        //private variable of type array to hold collection.
        private IDroid[] droidCollection;
        //Length of collection
        private int length;

        //method that passes in a size parameter for DroidCollection 
        public DroidCollection(int index)
        {
            droidCollection = new IDroid[index];
            length = 0;
        }
        //method to add a new astromech droid passing in all of its parameters and adding it to the collection
        public bool Add(string material, string model, string color, bool toolbox, bool computerConnection, bool arm, bool fireExtinguisher, int numberships)
        {
            //Check to see if there is room for a droid.
            if (length < (droidCollection.Length - 1))
            {
                droidCollection[length] = new Astromech(material, model, color, toolbox, computerConnection, arm, fireExtinguisher, numberships);
                length++;
                return true;
            }
            else
            {
                return false;
            }
        }
        //method to add a new janitor droid passing in all of its parameters and adding it to the collection
        public bool Add(string material, string model, string color, bool toolbox, bool computerConnection, bool arm, bool trashCompactor, bool vacuum)
        {
            //Check to see if there is room for a droid.
            if (length < (droidCollection.Length - 1))
            {
                droidCollection[length] = new Janitor(material, model, color, toolbox, computerConnection, arm, trashCompactor, vacuum);
                length++;
                return true;
            }
            else
            {
                return false;
            }
        }
        //method to add a new protocol droid passing in all of its paramters and adding it to the collection
        public bool Add(string material, string model, string color, int numofLanguages)
        {
            //Check to see if there is room for a droid.
            if (length < (droidCollection.Length - 1))
            {
                droidCollection[length] = new Protocol(material, model, color, numofLanguages);
                length++;
                return true;
            }
            else
            {
                return false;
            }
        }

        //method to add a new utility droid passing in all of its parameters and adding it to the collection
        public bool Add(String material, string model, string color, bool toolbox, bool computerConnection, bool arm)
        {
            //Check to see if there is room for a droid.
            if (length < (droidCollection.Length - 1))
            {
                droidCollection[length] = new Utility(material, model, color, toolbox, computerConnection, arm);
                length++;
                return true;
            }
            else
            {
                return false;
            }
        }



        //print method to print out droids as long as they are not null. Size may not be filled.
        public string printDroids()
        {
            String listOfDroids = "";
            foreach (IDroid droids in droidCollection)
            {
                if (droids != null)
                {
                    listOfDroids += droids.ToString() + Environment.NewLine + droids.TotalCost.ToString();
                }
            }
            return listOfDroids;
        }
    }
}
