using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UserInterface
    {
        IDroidCollection droidCollection;
        public UserInterface(IDroidCollection DroidCollection)
        {
            this.droidCollection = DroidCollection;
        }
        //method to display options for program
        public void DisplayMenu()
        {
            Console.WriteLine("Welcome to Droid Builder! What would you like to do?");
            Console.WriteLine("1. Build a New Droid" + Environment.NewLine + "2: Print List of Droids" + Environment.NewLine + "3: Exit");
            string MenuChoice = Console.ReadLine().Trim();
            Console.WriteLine();

            switch (MenuChoice)
            {
                case "1":
                    Console.WriteLine("Entering Droid Builder");
                    //Methods to create a droid with options and that calculates total cost.
                    break;
                case "2":
                    Console.WriteLine("Printing droid List...");
                    PrintListOfDroids();
                    break;
                case "3":
                    Console.WriteLine("Good Bye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }

        }
        //Too clunky adding in all the descriptions for everything need to create methods for displaying menus of different choices...

        //Print out list of Droids
        public void PrintListOfDroids()
        {
            Console.WriteLine(this.droidCollection.printDroids());
        }
    }
}

