using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Switch
    {
        static void Main(string[] args)
        {

            String input;
            int condition;

            Console.Write("Please introduce a number between 1 and 3: ");
            input = Console.ReadLine();
            condition = int.Parse(input);


            switch (condition)
            {
                case 1:
                    Console.WriteLine("Your number is {0}", condition);
                    break;
                case 2:
                    Console.WriteLine("Your number is {0}", condition);
                    break;
                case 3:
                    Console.WriteLine("Your number is {0}", condition);
                    break;

                default:
                    Console.WriteLine("Your number \"{0}\" is not between 1 and 3", condition);
                    break;
            }

            Console.Read();

        }
    }
}
