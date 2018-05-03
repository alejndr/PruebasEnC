using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            String mensaje = "frfrfrfrfrfrfrf";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e, String mensaje)
        {
            MessageBox.Show("Hello {0}", mensaje);
        }

        private void textBox1_TextChanged(object sender, EventArgs e, )
        {
            
        }
    }
}
