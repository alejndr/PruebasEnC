using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diccionarios
{
    class Diccionarios
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Estados = new Dictionary<string, string>();

            Estados.Add("CA", "California");
            Estados.Add("WA", "Washington");
            Estados.Add("NY", "Nueva York");

            // Otra forma de inicializar un diccionario:
            //var Estados = new Dictionary<string, string>()
            //{
            //    {"CA", "California"},
            //    {"WA", "Washington"},
            //    {"NY", "Nueva York"},

            //};

            // Obtenemos el valor de cada posición por su KEY
            Console.WriteLine(Estados["CA"]);

            // Iteración entre los elementos

            // 1º forma 
            //foreach (var NombreEstados in Estados)
            //{
            //    Console.WriteLine(NombreEstados);
            //}

            foreach (var NombreEstados in Estados)
            {
                var NombreDelEstado = NombreEstados.Value;
                var Abreviatura = NombreEstados.Key;

                Console.WriteLine($"Key: {Abreviatura} Value: {NombreDelEstado} ");


            }


            

            Console.ReadLine();

        }
    }
}
