using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    //Creamos el enum
    public enum Volumen
    {
        Bajo,
        Medio,
        Alto
    }
    class Enum
    {
        static void Main(string[] args)
        {
            //Creamos y inicializamos una instancia del enum que hemos creado
            Volumen miVolumen = Volumen.Bajo;

            //Hacemos una decision en funcion del valor del enum
            switch (miVolumen)
            {
                case Volumen.Bajo:
                    Console.WriteLine("El volumen esta bajo.");
                    break;
                case Volumen.Medio:
                    Console.WriteLine("El volumen esta a la mitad.");
                    break;
                case Volumen.Alto:
                    Console.WriteLine("El volumen esta a tope.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
