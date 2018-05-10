namespace AdivinaNumero
{
    partial class frmMain
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
            this.txtBox = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAdivina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(88, 63);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(100, 20);
            this.txtBox.TabIndex = 0;
            this.txtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(12, 31);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(260, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "He generado un número entre el 1 y el 100, adivinalo.";
            // 
            // btnAdivina
            // 
            this.btnAdivina.Location = new System.Drawing.Point(88, 98);
            this.btnAdivina.Name = "btnAdivina";
            this.btnAdivina.Size = new System.Drawing.Size(100, 23);
            this.btnAdivina.TabIndex = 2;
            this.btnAdivina.Text = "Adivina!";
            this.btnAdivina.UseVisualStyleBackColor = true;
            this.btnAdivina.Click += new System.EventHandler(this.btnAdivina_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 161);
            this.Controls.Add(this.btnAdivina);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtBox);
            this.Name = "frmMain";
            this.Text = "Adivina el número";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAdivina;
    }
}

