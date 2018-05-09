using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    class Delegados
    {
        
        static void Main(string[] args)
        {

            //Podemos ver que no importa el nombre del método ni de el de los parámetros que recibe. 
            //A partir de ellos se puede instanciar los delegados, para ello debemos utilizar el operador new seguido del nombre de nuestro delegado 
            //y como parámetro el método al que este “apunta”. Para muestra:
            Operacion mas = new Operacion(Suma);
            Operacion menos = new Operacion(Resta);
            Operacion por = new Operacion(Multiplicacion);


            //Para ejecutarlo basta con llamarlo como habitualmente llamaríamos al método al que hace referencia, 
            //es decir, el nombre asignado a la “variable” del tipo delegado y entre paréntesis la lista de parámetros, para este ejemplo los usaríamos de esta manera:
            int r1 = mas(4, 5);

            int r2 = menos(4, 5);

            int r3 = por(4, 5);


            //Otra función útil de los delegados es la posiblidad de combinarlos, lo cual se realiza mediante el operador +=. 
            //Es confuso decir combinarlos, dado que la combinación es en realidad un tipo de encolamiento, haciéndo que se ejecute uno tras de otro, pero de manera independiente.
            Operacion combinado = mas;
            combinado += por; // combinación con el operador +=

            int r4 = combinado(4, 5); // r4 es igual a 20, pero la consola mostrara: Suma ejecutada y multiplicación ejecutada.

        }


        /// <summary>
        /// Delegado.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public delegate int Operacion(int a, int b);

        /// <summary>
        /// Suma.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Suma(int a, int b)
        {
            Console.WriteLine("Ejecutando suma");
            return a + b;
        }
        
        /// <summary>
        /// Resta
        /// </summary>
        /// <param name="r"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static int Resta(int r, int t)
        {
            Console.WriteLine("Ejecutando resta");
            return r - t;
        }

        /// <summary>
        /// Multiplicación.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int Multiplicacion(int x, int y)
        {
            Console.WriteLine("Ejecutando multiplicación");
            return x * y;
        }
    }
}
