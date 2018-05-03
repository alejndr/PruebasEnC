namespace SpeechSynt
{
    partial class SpeechSynt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnToVoice = new System.Windows.Forms.Button();
            this.txtToVoice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnToVoice
            // 
            this.btnToVoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToVoice.Location = new System.Drawing.Point(12, 125);
            this.btnToVoice.Name = "btnToVoice";
            this.btnToVoice.Size = new System.Drawing.Size(260, 124);
            this.btnToVoice.TabIndex = 0;
            this.btnToVoice.Text = "GO!";
            this.btnToVoice.UseVisualStyleBackColor = true;
            this.btnToVoice.Click += new System.EventHandler(this.btnToVoice_Click);
            // 
            // txtToVoice
            // 
            this.txtToVoice.Location = new System.Drawing.Point(12, 12);
            this.txtToVoice.Multiline = true;
            this.txtToVoice.Name = "txtToVoice";
            this.txtToVoice.Size = new System.Drawing.Size(260, 107);
            this.txtToVoice.TabIndex = 1;
            // 
            // SpeechSynt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtToVoice);
            this.Controls.Add(this.btnToVoice);
            this.Name = "SpeechSynt";
            this.Text = "Loquendo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToVoice;
        private System.Windows.Forms.TextBox txtToVoice;
    }
}

