using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo
{
    class Menu
    {
        static void Main(string[] args)
        {
            String myChoice = "z";

            Menu om = new Menu();

            while (myChoice != "q" && myChoice != "Q")
            {
                myChoice = om.getChoice();

                switch (myChoice)
                {
                    case "A":
                    case "a":
                        Console.WriteLine("Added the address");
                        break;
                    case "D":
                    case "d":
                        Console.WriteLine("Deleted the address");
                        break;
                    case "M":
                    case "m":
                        Console.WriteLine("Modified the address");
                        break;
                    case "Q":
                    case "q":
                        Console.WriteLine("Bye bye.");
                        break;

                    default:
                        Console.WriteLine("{0} is not a valid option, please try again", myChoice);
                        break;
                }

                Console.WriteLine();
                Console.Write("press Enter key to continue...");

                Console.ReadLine();

            }

        }

        String getChoice()
        {
            String myChoice;

            //Print a menu
            Console.WriteLine("A - Add an address");
            Console.WriteLine("D - Delete an address");
            Console.WriteLine("M - Modify an address");
            Console.WriteLine("Q - Quit menu");

            Console.Write("Select a option: A, D, M or Q:");

            myChoice = Console.ReadLine();


            return myChoice;
        }
    }
}
