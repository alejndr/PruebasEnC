using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metronomo
{
    class Metronomo
    {


        static void Main(string[] args)
        {
            metronomo metronomo1 = new metronomo();
            escuchado escuchador = new escuchado();

            escuchador.Escuchar(metronomo1);
            metronomo1.Start();
        }
    }

    public class metronomo
    {
        public delegate void TickHandler(metronomo m, EventArgs e);
        public event TickHandler Tick;
        public EventArgs e = null;
        public void Start()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(3000);
                if (Tick != null)
                {
                    Tick(this, e);
                }
            }
        }
    }

    public class escuchado
    {
        public void Escuchar(metronomo m)
        {
            m.Tick += new metronomo.TickHandler(Escuchado);
        }

        private void Escuchado(metronomo m, EventArgs e)
        {
            Console.WriteLine("ESCUCHADO!!");
        }
    }
}
