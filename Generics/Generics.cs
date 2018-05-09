using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Generics
    {
        static void Main(string[] args)
        {
            int numeros = 123;

            String Palabras = "blablabla";

            double Decimales = 1.56;


            // Prueba con int
            MetodoGenerico<int>(numeros); // entre <> podemos indicar el tipo que queremos que use el metodo.
                                          // Intellisense nos indica que podemos simplificarlo, como se muestra en lso siguientes.
            // Prueba con string
            MetodoGenerico(Palabras);

            // Prueba con double
            MetodoGenerico(Decimales);

            Console.Read();


        }

        /// <summary>
        /// Metodo generico que imprime lo que se le pase, independientemente de su tipo
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="mensaje"></param>
        public static void MetodoGenerico<T>(T mensaje)
        {
            
           Console.WriteLine(mensaje);
            
        }
    }
}
