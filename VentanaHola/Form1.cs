using System;
using System.Windows.Forms;

namespace VentanaHola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listaCiudades_SelectedIndexChanged(object sender, EventArgs e)
        {
            String texto = listaCiudades.GetItemText(listaCiudades.SelectedItem);

            MessageBox.Show(texto);
        }

        private void buttonENVIAR_Click(object sender, EventArgs e)
        {
            string genero ="";

            //Capturamos el texto que se a introducido en los textbox nombre y direccion
            string nombre = textoNombre.Text;
            string direccion = textoDireccion.Text;

            //Controlamos que el usuario rellene los 2 campos.
            if (string.IsNullOrEmpty(textoNombre.Text) || string.IsNullOrEmpty(textoDireccion.Text))
            {
                MessageBox.Show("Por favor introduce tu nombre y dirección");
            } else {
                //Comprobamos que radiobutton esta seleccionado
            if (rdHombre.Checked)
            {
                genero = "El señor";
            }

            if (rdMujer.Checked)
            {
                genero = "La señora";
            }

            MessageBox.Show(genero+" "+nombre+" vive en la dirección: "+direccion+".");
        }
        }

        void resultadoFormulario() {

        }
    }
}
