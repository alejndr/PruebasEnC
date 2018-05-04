using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadenas
{
    public partial class frmCadenas : Form
    {

        #region Global variables

        private bool _FortyCharacters;

        #endregion Global variables

        #region Constructor

        public frmCadenas()
        {
            InitializeComponent();
        }

        #endregion Constructor

        #region Events

        /// <summary>
        /// Event on Load.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCadenas_Load(object sender, EventArgs e)
        {
            InitializeControls();
        }

        /// <summary>
        /// Event on text changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtString_TextChanged(object sender, EventArgs e)
        {
           _FortyCharacters = CheckNumberOfCharacters();
            EnableControls();
        }

        /// <summary>
        /// Search changed text.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch.Text = "Search!";
        }

        /// <summary>
        /// Search button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        /// <summary>
        /// Change text button event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangeText_Click(object sender, EventArgs e)
        {
            ChangeText();
        }

        /// <summary>
        /// Initial text button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchInitialText_Click(object sender, EventArgs e)
        {
            Find();
        }

        private void txtInitialText_TextChanged(object sender, EventArgs e)
        {
            btnSearchInitialText.Text = "Search!";
        }

        #endregion Events

        #region Methods

        /// <summary>
        /// Check the textbox to contain forty characters.
        /// </summary>
        /// <returns></returns>
        private bool CheckNumberOfCharacters()
        {
            bool fortyCharacters = false;
           
            if (txtString.Text.Length == 0)
            {
                lblTextbox.Text = "Write a text of 40 characters minimun.";

            }
            else
            {  
                lblTextbox.Text = "Keep writing until 40 characters";
                if (txtString.Text.Length >= 40)
                {
                    lblTextbox.Text = "Ok, now we can work with that.";
                    fortyCharacters = true;
                }
            }
            
            return fortyCharacters;
        }

        /// <summary>
        /// Enable controls.
        /// </summary>
        private void EnableControls()
        {
            if (_FortyCharacters)
            {
                // Change.
                txtChangeFor.Enabled = true;
                txtChangeTo.Enabled = true;
                btnChangeText.Enabled = true;

                // Search.
                txtSearch.Enabled = true;
                btnSearch.Enabled = true;

                // Search initial text.
                txtInitialText.Enabled = true;
                btnSearchInitialText.Enabled = true;
            }
            else
            {
                // Change.
                txtChangeFor.Enabled = false;
                txtChangeTo.Enabled = false;
                btnChangeText.Enabled = false;

                // Search.
                txtSearch.Enabled = false;
                btnSearch.Enabled = false;

                // Search initial text.
                txtInitialText.Enabled = false;
                btnSearchInitialText.Enabled = false;
            }
        }

        /// <summary>
        /// Initialize the controls on false.
        /// </summary>
        private void InitializeControls()
        {
            // Change.
            txtChangeFor.Enabled = false;
            txtChangeTo.Enabled = false;
            btnChangeText.Enabled = false;

            // Search.
            txtSearch.Enabled = false;
            btnSearch.Enabled = false;

            // Search initial text.
            txtInitialText.Enabled = false;
            btnSearchInitialText.Enabled = false;
        }

        /// <summary>
        /// Search function.
        /// </summary>
        private void Search()
        {
            string searchText = txtString.Text;

            if (searchText.Contains(txtSearch.Text))
            {
                btnSearch.Text = "I've found it, Its in!";
            }
            else
            {
                btnSearch.Text = "I can't found it :(";
            }
        }

        /// <summary>
        /// Change text if found.
        /// </summary>
        private void ChangeText()
        {
            string textFrom = txtChangeFor.Text;
            string textTo = txtChangeTo.Text;
            string textChanged = txtString.Text;

            if (textFrom.Length > 0 && textTo.Length > 0)
            {

                if (txtString.Text.Contains(textFrom))
                {
                    txtString.Text = textChanged.Replace(textFrom, textTo);
                }
                else
                {
                    MessageBox.Show("One of the fields are empty, please try again.");
                }
                
            }
            else
            {
                MessageBox.Show("I can't find the word you want to change, please try again. ");
            }
        }

        /// <summary>
        /// Find initial text.
        /// </summary>
        private void Find()
        {
            string textBox = txtString.Text;
            
            if (txtInitialText.Text.Length > 0)
            {
                if (textBox.StartsWith(txtInitialText.Text))
                {
                    btnSearchInitialText.Text = "Yeah";
                }
                else
                {
                    btnSearchInitialText.Text = "Nope";
                }

            }
            else
            {
                MessageBox.Show("The search field are empty, please try again.");
            }
        }
        
        #endregion Methods

        
    }
}
