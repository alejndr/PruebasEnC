using System;

namespace ForEach
{
    class forEach
    {
        static void Main(string[] args)
        {

            string[] words = {"One", "Two", "Three" };

            foreach (String loquesea in words)
            {
                Console.WriteLine("{0} ", loquesea);
            }

            Console.Read();
        }
    }
}
