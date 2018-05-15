using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class GetterAndSetter
    {

        /// <summary>
        /// Clase persona
        /// La propiedad ID solo es accesible desde la msima clase.
        /// La propiedad nombre completo sera de solo lectura y estara formada por los valores de Nombre, PrimerApellido y SegundoApellido.
        /// </summary>
        public class Person
        {
            public  int ID { get; private set; }
            public string Nombre { get; set; }
            public string PrimerApellido { get; set; }
            public string SegundoApellido { get; set; }
            public string NombreCompleto
            {
                get
                {
                    return Nombre + ", " + PrimerApellido + " " + SegundoApellido;
                }
            }
        }

        static void Main(string[] args)
        {

        }
    }
}