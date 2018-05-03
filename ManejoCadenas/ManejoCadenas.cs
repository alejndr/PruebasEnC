using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoCadenas
{
    class ManejoCadenas
    {
        static void Main(string[] args)
        {
            string path1 = @"c:\application\demo1\fichero.txt";

            string path2 = "c:\\application\\demo1\\fichero.txt";

            // sustituyamos las dos barras del path2 por una sola
            path2 = path2.Replace("\\", @"\");

            // eliminamos "demo1\\" del path2
            path2 = path2.Replace("demo1\\", string.Empty);

            // eliminamos el c:
            path2 = path2.Remove(0, 2);

            Console.WriteLine(path2);

            // Quiero obtener sólo el nombre del fichero
            string nombreFichero = string.Empty;

            int ultimoIndice = path1.LastIndexOf(@"\");

            nombreFichero = path1.Substring(ultimoIndice + 1);

            //nombreFichero = path1.Substring(path1.LastIndexOf(@"\") + 1);

            Console.WriteLine(nombreFichero);

            // Split
            string listaNombres = "Juan|Pedro|Manuel|Luis|Ana";
            string[] nombres = listaNombres.Split('|');

            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }

            // Trim
            string cadena = "    Cadena    ";
            string concat = "XX";

            Console.WriteLine(cadena + concat);
            Console.WriteLine(cadena.TrimStart() + concat);
            Console.WriteLine(cadena.TrimEnd() + concat);
            Console.WriteLine(cadena.Trim() + concat);

            // ¿Qué devuelve esto?
            Console.WriteLine("   xx   yy  ".Trim());

            // Presentar en pantalla un número de 10 dígitos, rellenando con 0 a la izquierda
            // hasta ocupar todas sus posiciones
            Console.WriteLine("87645".PadLeft(10, '0'));

            // StartWith & EndWith
            string otraCadena = "Hola estoy en clase";

            Console.WriteLine(otraCadena.StartsWith("Holo") ? "SI" : "NO");


            Console.ReadLine();

        }
    }

}
