using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqShowLargeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows";
            ShowLargeFilesWithLinq(path);

            Console.ReadLine();
        }

        /// <summary>
        /// Con Linq obtenemos los 5 archivos mas grandes del path que le metamos
        /// </summary>
        /// <param name="path"></param>
        private static void ShowLargeFilesWithLinq(string path)
        {
            var query = new DirectoryInfo(path).GetFiles()
                        .OrderByDescending(f => f.Length)
                        .Take(5);

            foreach (var file in query) //cogemos solo los 5 primeros
            {
                Console.WriteLine($"{file.Name,-15} : {file.Length}");
            }

            


        }
    }
}
