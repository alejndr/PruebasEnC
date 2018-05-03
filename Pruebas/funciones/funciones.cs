using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebas.funciones
{
    class funciones
    {
        public static void suma(int a, int b)
        {
            int c = a + b;
            MessageBox.Show(Properties.Resources.MESSAGE_RESULT + c);
        }

    }
}
