using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionesRecursivas
{
    class Program
    {
        static void Main(string[] args)
        {
            Program miPrograma = new Program();

            // Función recursiva
            Console.WriteLine(miPrograma.Potencia(2, 4));

            Console.ReadLine();
        }

        public int Potencia(int numero, int exponente)
        {
            // Caso Base
            if (exponente == 0)
            {
                return 1;
            }
            else
            {
                return numero * Potencia(numero, exponente - 1);
            }
        }
    }

}
