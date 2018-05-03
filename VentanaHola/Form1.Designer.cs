namespace VentanaHola
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textoNombre = new System.Windows.Forms.TextBox();
            this.textoDireccion = new System.Windows.Forms.TextBox();
            this.listaCiudades = new System.Windows.Forms.ListBox();
            this.rdHombre = new System.Windows.Forms.RadioButton();
            this.rdMujer = new System.Windows.Forms.RadioButton();
            this.checkBoxC = new System.Windows.Forms.CheckBox();
            this.checkBoxASP = new System.Windows.Forms.CheckBox();
            this.buttonENVIAR = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hola mundo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textoDireccion);
            this.groupBox1.Controls.Add(this.textoNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 84);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dirección";
            // 
            // textoNombre
            // 
            this.textoNombre.Location = new System.Drawing.Point(68, 22);
            this.textoNombre.Name = "textoNombre";
            this.textoNombre.Size = new System.Drawing.Size(100, 20);
            this.textoNombre.TabIndex = 2;
            // 
            // textoDireccion
            // 
            this.textoDireccion.Location = new System.Drawing.Point(68, 47);
            this.textoDireccion.Name = "textoDireccion";
            this.textoDireccion.Size = new System.Drawing.Size(100, 20);
            this.textoDireccion.TabIndex = 3;
            // 
            // listaCiudades
            // 
            this.listaCiudades.FormattingEnabled = true;
            this.listaCiudades.Items.AddRange(new object[] {
            "Málaga",
            "Madrid",
            "Granada",
            "Sevilla",
            "Barcelona",
            "Jaen",
            "Badajoz"});
            this.listaCiudades.Location = new System.Drawing.Point(12, 115);
            this.listaCiudades.Name = "listaCiudades";
            this.listaCiudades.Size = new System.Drawing.Size(188, 69);
            this.listaCiudades.TabIndex = 3;
            this.listaCiudades.SelectedIndexChanged += new System.EventHandler(this.listaCiudades_SelectedIndexChanged);
            // 
            // rdHombre
            // 
            this.rdHombre.AutoSize = true;
            this.rdHombre.Location = new System.Drawing.Point(223, 46);
            this.rdHombre.Name = "rdHombre";
            this.rdHombre.Size = new System.Drawing.Size(62, 17);
            this.rdHombre.TabIndex = 4;
            this.rdHombre.TabStop = true;
            this.rdHombre.Text = "Hombre";
            this.rdHombre.UseVisualStyleBackColor = true;
            // 
            // rdMujer
            // 
            this.rdMujer.AutoSize = true;
            this.rdMujer.Location = new System.Drawing.Point(223, 71);
            this.rdMujer.Name = "rdMujer";
            this.rdMujer.Size = new System.Drawing.Size(51, 17);
            this.rdMujer.TabIndex = 5;
            this.rdMujer.TabStop = true;
            this.rdMujer.Text = "Mujer";
            this.rdMujer.UseVisualStyleBackColor = true;
            // 
            // checkBoxC
            // 
            this.checkBoxC.AutoSize = true;
            this.checkBoxC.Location = new System.Drawing.Point(221, 135);
            this.checkBoxC.Name = "checkBoxC";
            this.checkBoxC.Size = new System.Drawing.Size(40, 17);
            this.checkBoxC.TabIndex = 6;
            this.checkBoxC.Text = "C#";
            this.checkBoxC.UseVisualStyleBackColor = true;
            // 
            // checkBoxASP
            // 
            this.checkBoxASP.AutoSize = true;
            this.checkBoxASP.Location = new System.Drawing.Point(221, 158);
            this.checkBoxASP.Name = "checkBoxASP";
            this.checkBoxASP.Size = new System.Drawing.Size(75, 17);
            this.checkBoxASP.TabIndex = 7;
            this.checkBoxASP.Text = "ASP .NET";
            this.checkBoxASP.UseVisualStyleBackColor = true;
            // 
            // buttonENVIAR
            // 
            this.buttonENVIAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonENVIAR.Location = new System.Drawing.Point(322, 25);
            this.buttonENVIAR.Name = "buttonENVIAR";
            this.buttonENVIAR.Size = new System.Drawing.Size(226, 159);
            this.buttonENVIAR.TabIndex = 8;
            this.buttonENVIAR.Text = "Enviar";
            this.buttonENVIAR.UseVisualStyleBackColor = true;
            this.buttonENVIAR.Click += new System.EventHandler(this.buttonENVIAR_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Conocimientos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 211);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonENVIAR);
            this.Controls.Add(this.checkBoxASP);
            this.Controls.Add(this.checkBoxC);
            this.Controls.Add(this.rdMujer);
            this.Controls.Add(this.rdHombre);
            this.Controls.Add(this.listaCiudades);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textoDireccion;
        private System.Windows.Forms.TextBox textoNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listaCiudades;
        private System.Windows.Forms.RadioButton rdHombre;
        private System.Windows.Forms.RadioButton rdMujer;
        private System.Windows.Forms.CheckBox checkBoxC;
        private System.Windows.Forms.CheckBox checkBoxASP;
        private System.Windows.Forms.Button buttonENVIAR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

