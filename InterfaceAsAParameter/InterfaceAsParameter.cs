using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAsAParameter
{
    class InterfaceAsParameter
    {
        /// <summary>
        /// Clase Vendors
        /// </summary>
        public class Vendors
        {
            public string name { get; set; }
            public string corp { get; set; }
        }

        /// <summary>
        /// Main.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            InterfaceAsParameter p = new InterfaceAsParameter();
            Vendors[] Array = new Vendors[5];
            List<Vendors> ListaGenerica = new List<Vendors>();
            
            // El metodo funciona tanto con el array como con la lista generica
            p.SendEmail(Array, "hola");

            p.SendEmail(ListaGenerica, "hola");
             
        }

        /// <summary>
        /// Usamos la interfaz collections en lugar de el tipo especifico List.
        /// </summary>
        /// <param name="vendors"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public List<string> SendEmail(IEnumerable<Vendors> vendors, string message)
        {
            List<string> list = new List<string>();

            return list;
        }
        
    }
}
