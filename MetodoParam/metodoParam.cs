using System;

namespace MetodoParam
{


    class metodoParam
    {
        static void Main(string[] args)
        {
            metodoParam mp = new metodoParam();


            String eleccion = "";

            while (eleccion != "q" && eleccion != "Q")
            {
                eleccion = mp.getChoice();

                mp.makeDecision(eleccion);

                Console.WriteLine();
                Console.Write("press Enter key to continue...");

                Console.ReadLine();

            }
        }



        //Declaramos la clase Address
        class Address
        {

            public String name;
            public String address;

        }

        //Seleccionador de opciones para el menu
        String getChoice()
        {
            String myChoice;

            //Print a menu
            Console.WriteLine("A - Add an address");
            Console.WriteLine("D - Delete an address");
            Console.WriteLine("V - View an address");
            Console.WriteLine("Q - Quit menu");

            Console.Write("Select a option: A, D, V or Q:");

            myChoice = Console.ReadLine();


            return myChoice;
        }

        //Menu
        void makeDecision(string myChoice) {

            Address addr = new Address();

            switch (myChoice)
                {
                case "A":
                case "a":
                    addr.name = "Joe";
                    addr.address = "C# Station";
                    this.addAddress(ref addr);
                    break;
                case "D":
                case "d":
                    addr.name = "Robert";
                    this.deleteAddress(addr.name);
                    break;
                case "M":
                case "m":
                    addr.name = "Matt";
                    this.modifyAddress(out addr);
                    Console.WriteLine("Name is now {0}.", addr.name);
                    break;
                case "V":
                case "v":
                    this.viewAddresses("Cheryl", "Joe", "Matt", "Robert");
                    break;
                case "Q":
                case "q":
                    Console.WriteLine("Bye.");
                    break;
                default:
                    Console.WriteLine("{0} is not a valid choice", myChoice);
                    break;
            }

        }

        // insert an address
        void addAddress(ref Address addr)
        {
            Console.WriteLine("Name: {0}, Address: {1} added.", addr.name, addr.address);
        }

        // remove an address
        void deleteAddress(string name)
        {
            Console.WriteLine("You wish to delete {0}'s address.", name);
        }

        // change an address
        void modifyAddress(out Address addr)
        {
            //Console.WriteLine("Name: {0}.", addr.name); // causes error!
            addr = new Address();
            addr.name = "Joe";
            addr.address = "C# Station";
        }

        // show addresses
        void viewAddresses(params string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine("Name: {0}", name);
            }
        }
    }

}
