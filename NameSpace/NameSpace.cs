using System;

namespace NameSpace
{
    class NameSpace
    {
        static void Main(string[] args)
        {

            tutorial.Ejemplo1.texto1();
            tutorial.Ejemplo2.texto2();

            Console.Read();

        }
    }

    
}


namespace NameSpace.tutorial
{
    class Ejemplo1
    {
        public static void texto1()
        {
            Console.WriteLine("Texto 1");
        }
    }
}

namespace NameSpace
{

    namespace tutorial
    {

        class Ejemplo2
        {

            public static void texto2()
            {
                Console.WriteLine("Texto 2");
            }

        }

    }

}
