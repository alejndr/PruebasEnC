using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecuenciaFibonacci
{
    class SecuenciaFibonacci
    {
        static void Main(string[] args)
        {
            int prev = -1;
            int next = 1;

            for (int i = 0; i < 20; i++)
            {
                int sum = prev + next;
                prev = next;
                next = sum;
                Console.WriteLine(sum);
            }

            Console.Read();
        }
    }
}
