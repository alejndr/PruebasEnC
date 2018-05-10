using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdivinaNumero
{
    public partial class frmMain : Form
    {
        #region Global variables

        private int _NumeroGenerado;
        private int _Intentos = 6;

        #endregion Global variables

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }


        #endregion Constructor

        #region Events

        /// <summary>
        /// Enable or disable the button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CheckEnableButton();
        }

        /// <summary>
        /// Load formulary.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            InitializeForm();
            GeneraNumero();
        }

        /// <summary>
        /// Click button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdivina_Click(object sender, EventArgs e)
        {
            AdivinaNumero();
        }

        #endregion Eventes

        #region Private methods

        /// <summary>
        /// Check if button can be enabled
        /// </summary>
        private void CheckEnableButton()
        {
            if (_Intentos != 0)
            {
                if (btnAdivina.Text.Length > 0)
                {
                    btnAdivina.Enabled = true;
                }
                else
                {
                    btnAdivina.Enabled = false;
                }
            }
            else
            {
                btnAdivina.Enabled = false;
            }
            
        }

        /// <summary>
        /// Initialize the form.
        /// </summary>
        private void InitializeForm()
        {
            btnAdivina.Enabled = false;
        }

        /// <summary>
        /// guest the number
        /// </summary>
        private void AdivinaNumero()
        {
            int respuesta = Convert.ToInt32(txtBox.Text);
            string intentos = "Lo siento, no era ese. Te quedan: "+_Intentos+" intentos";

            if (_Intentos == 0)
            {
                btnAdivina.Enabled = false;
                lblTitulo.Text = "Lo siento, te has quedado sin intentos.";
            }

            if (respuesta != _NumeroGenerado)
            {
                lblTitulo.Text = intentos;
                _Intentos--;
            }
            else
            {
                lblTitulo.Text = "Felicidades! Ese es el número correcto!";
            }
        }

        /// <summary>
        /// Genera un número aleatorio entre 1 y 100
        /// </summary>
        /// <returns></returns>
        private void GeneraNumero()
        {
            Random rnd = new Random();
            _NumeroGenerado = rnd.Next(1, 100);
            
        }




        #endregion Private methods
        
    }
}
