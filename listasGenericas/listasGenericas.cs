using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listasGenericas
{
    class listasGenericas
    {
        static void Main(string[] args)
        {

            List<String> frutas = new List<String>();

            frutas.Add("Manzana");
            frutas.Add("Fresa");
            frutas.Add("Aguacate");
            frutas.Add("Cereza");

            frutas.RemoveAt(2);

            foreach (var item in frutas)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------");




            Console.Read();
        }
    }
}
