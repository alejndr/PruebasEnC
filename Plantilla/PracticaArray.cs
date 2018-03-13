using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plantilla
{
    class practicaArray
    {
        static void Main(string[] args)
        {

            //El usuario define el tamaño del array
            String n;

            Console.WriteLine("¿De que tamaño quieres que sea el array?");
            n = Console.ReadLine();
            int tamaño = int.Parse(n);

            double[] arrayNumerico = new double[tamaño];

            //El usuario define los numeros guardados en el array
            Console.WriteLine("introduce el número que quieras (incluso con decimales) en cada posicion del array");
            for (int i=0; i < tamaño ; i++) {
                Console.WriteLine("Introduce el número en la posicion: {0} ", (i + 1));
                n = Console.ReadLine();
                arrayNumerico[i] = double.Parse(n);
            }

            //Se muestra el array
            Console.WriteLine("Aqui esta tu array numerico:");
            for (int e = 0 ; e < tamaño ; e++) {
                Console.WriteLine("{0} ", arrayNumerico[e]);
            }

            Console.ReadLine();

        }
    }
}
