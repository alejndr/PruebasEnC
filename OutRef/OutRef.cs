using System;

namespace OutRef
{
    public class Humano
    {
        public String nombre;
        public String apellido;
    }

    class OutRef
    {
        static void Main(string[] args)
        {

            Humano humano1 = new Humano();

            Console.WriteLine("humano1 antes de darIdentidad: {0} {1}", humano1.nombre, humano1.apellido);

            darIdentidad(out humano1);

            Console.WriteLine("Identidad de humano1: {0} {1}", humano1.nombre, humano1.apellido);

            modificarIdentidad(ref humano1);

            Console.WriteLine("humano1 despues de modificarIdentidad: {0} {1}", humano1.nombre, humano1.apellido);

            Console.Read();
        }

        /// <summary>
        /// Con Out hay que crear una nueva instancia del objeto dentro del metodo
        /// </summary>
        /// <param name="humano1"></param>
        static void darIdentidad(out Humano humano1)
        {
            
            humano1 = new Humano();
            humano1.nombre = "John";
            humano1.apellido = "Doe";
        }

        /// <summary>
        /// Con ref pasamos por referencia el objeto, no tendriamos que instanciarlo otra vez dentro del metodo
        /// </summary>
        /// <param name="humano1"></param>
        static void modificarIdentidad(ref Humano humano1)
        {
            humano1.nombre = "Paco";
            humano1.apellido = "Perez";
        }
        
    }

    
}
