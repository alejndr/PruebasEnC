using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeechSynt
{
    public partial class SpeechSynt : Form
    {
        #region Constructor

        public SpeechSynt()
        {
            InitializeComponent();
        }

        #endregion Constructor

        #region Events

        /// <summary>
        /// speak button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnToVoice_Click(object sender, EventArgs e)
        {
            Speak(txtToVoice.Text);
        }

        #endregion Events

        #region Method

        /// <summary>
        /// Text to speech.
        /// </summary>
        /// <param name="text"></param>
        public void Speak(String text)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();

            synth.Rate = -10;

            synth.Speak(text);
            
        }

        #endregion Method
        
    }
}
