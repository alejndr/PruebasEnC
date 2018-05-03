using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Hijo.mensajePadreHeredado();

            Hijo.Print();

            Console.Read();


        }

        public class Padre {

            public static void mensajePadre() {
                Console.WriteLine("Soy el mensaje padre");

            }

            public static void Print()
            {
                Console.WriteLine("Soy el print del padre");

            }

        }

        public class Hijo : Padre {
            public static void mensajePadreHeredado() {
                mensajePadre();
            }


        }
    }
}
