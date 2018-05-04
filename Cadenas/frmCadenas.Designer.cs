namespace Cadenas
{
    partial class frmCadenas
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
            this.txtString = new System.Windows.Forms.TextBox();
            this.lblTextbox = new System.Windows.Forms.Label();
            this.txtChangeFor = new System.Windows.Forms.TextBox();
            this.txtChangeTo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangeText = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInitialText = new System.Windows.Forms.TextBox();
            this.btnSearchInitialText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(15, 42);
            this.txtString.Multiline = true;
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(413, 62);
            this.txtString.TabIndex = 0;
            this.txtString.TextChanged += new System.EventHandler(this.txtString_TextChanged);
            // 
            // lblTextbox
            // 
            this.lblTextbox.AutoSize = true;
            this.lblTextbox.Location = new System.Drawing.Point(12, 26);
            this.lblTextbox.Name = "lblTextbox";
            this.lblTextbox.Size = new System.Drawing.Size(185, 13);
            this.lblTextbox.TabIndex = 1;
            this.lblTextbox.Text = "Write a text of 40 characters minimun.";
            // 
            // txtChangeFor
            // 
            this.txtChangeFor.Location = new System.Drawing.Point(65, 141);
            this.txtChangeFor.Name = "txtChangeFor";
            this.txtChangeFor.Size = new System.Drawing.Size(100, 20);
            this.txtChangeFor.TabIndex = 2;
            // 
            // txtChangeTo
            // 
            this.txtChangeTo.Location = new System.Drawing.Point(196, 141);
            this.txtChangeTo.Name = "txtChangeTo";
            this.txtChangeTo.Size = new System.Drawing.Size(100, 20);
            this.txtChangeTo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Change a word of your text for another.";
            // 
            // btnChangeText
            // 
            this.btnChangeText.Location = new System.Drawing.Point(326, 139);
            this.btnChangeText.Name = "btnChangeText";
            this.btnChangeText.Size = new System.Drawing.Size(102, 23);
            this.btnChangeText.TabIndex = 5;
            this.btnChangeText.Text = "Change!";
            this.btnChangeText.UseVisualStyleBackColor = true;
            this.btnChangeText.Click += new System.EventHandler(this.btnChangeText_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Change:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "for";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Search for a word or a extrat in your text.";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 197);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(284, 20);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(326, 195);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search!";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Find if your text start with a given text ";
            // 
            // txtInitialText
            // 
            this.txtInitialText.Location = new System.Drawing.Point(15, 253);
            this.txtInitialText.Name = "txtInitialText";
            this.txtInitialText.Size = new System.Drawing.Size(281, 20);
            this.txtInitialText.TabIndex = 12;
            this.txtInitialText.TextChanged += new System.EventHandler(this.txtInitialText_TextChanged);
            // 
            // btnSearchInitialText
            // 
            this.btnSearchInitialText.Location = new System.Drawing.Point(326, 251);
            this.btnSearchInitialText.Name = "btnSearchInitialText";
            this.btnSearchInitialText.Size = new System.Drawing.Size(102, 23);
            this.btnSearchInitialText.TabIndex = 13;
            this.btnSearchInitialText.Text = "Search!";
            this.btnSearchInitialText.UseVisualStyleBackColor = true;
            this.btnSearchInitialText.Click += new System.EventHandler(this.btnSearchInitialText_Click);
            // 
            // frmCadenas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(440, 292);
            this.Controls.Add(this.btnSearchInitialText);
            this.Controls.Add(this.txtInitialText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChangeText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChangeTo);
            this.Controls.Add(this.txtChangeFor);
            this.Controls.Add(this.lblTextbox);
            this.Controls.Add(this.txtString);
            this.MaximizeBox = false;
            this.Name = "frmCadenas";
            this.Text = "Cadenas";
            this.Load += new System.EventHandler(this.frmCadenas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Label lblTextbox;
        private System.Windows.Forms.TextBox txtChangeFor;
        private System.Windows.Forms.TextBox txtChangeTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChangeText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInitialText;
        private System.Windows.Forms.Button btnSearchInitialText;
    }
}

