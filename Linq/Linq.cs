using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Linq
    {
        static void Main(string[] args)
        {
            // La lista con vendedores sera la "Base de datos"
            var vendors = new List<Vendor>()
            {
                { new Vendor()
                {id = 1, name = "AB", company = "AABB" } },
                { new Vendor()
                {id = 2, name = "CD", company = "CCDD clave" } },
                { new Vendor()
                {id = 3, name = "EF", company = "EEFF" } },
                { new Vendor()
                {id = 4, name = "GH", company = "GGHH" } },
                { new Vendor()
                {id = 5, name = "IJ", company = "IIJJ" } },
                { new Vendor()
                {id = 6, name = "KL", company = "KKLL clave" } },
                { new Vendor()
                {id = 7, name = "MN", company = "MMNN" } },
                { new Vendor()
                {id = 8, name = "OP", company = "OOPP" } },
                { new Vendor()
                {id = 9, name = "QR", company = "QQRR clave" } },
            };

            //Esta consulta nos devolvera los registros que tengan la palabra "clave" en company.
            //var vendorQuery = from v in vendors
            //                  where v.company.Contains("clave")
            //                  select v;

            // Otra forma de hacerlo, esta vez con expresiones lambda
            var vendorQuery = vendors.Where(v => v.company.Contains("clave"))
                                     .OrderBy(v => v.company);

            // otros operadores que podriamos usar:
            // vendors.where(v => v.company.contains("clave")) -- Filtra por el criterio
            // vendors.Select(v => v.Email) -- Da forma a la consulta por la propiedad seleccionada
            // vendors.OrderBy(v => v.company) -- Ordena por el string definido
            // vendors.Average(v => v.NoOfProducts) -- Aggregate elements
            // vendors.First(v => v.VendorId == 22) -- Devuelve el primer elemento encontrado
            // vendors.FirstOrDefault(v => v.VendorId == 22) -- Devuelve el primer elemento o null
            


            vendorQuery.ToList();

            foreach (Vendor vend in vendorQuery)
            {
                Console.WriteLine(vend.ToString());
            }

            Console.ReadLine();
        }
    }

    internal class Vendor
    {
        public int id { get; set; }
        public string name { get; set; }
        public string company { get; set; }
    }
}
