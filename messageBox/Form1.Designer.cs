namespace messageBox
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
            this.txtBoxRezultat = new System.Windows.Forms.TextBox();
            this.buttonOtvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxRezultat
            // 
            this.txtBoxRezultat.Location = new System.Drawing.Point(60, 120);
            this.txtBoxRezultat.Multiline = true;
            this.txtBoxRezultat.Name = "txtBoxRezultat";
            this.txtBoxRezultat.Size = new System.Drawing.Size(187, 130);
            this.txtBoxRezultat.TabIndex = 0;
            // 
            // buttonOtvori
            // 
            this.buttonOtvori.Location = new System.Drawing.Point(60, 64);
            this.buttonOtvori.Name = "buttonOtvori";
            this.buttonOtvori.Size = new System.Drawing.Size(187, 23);
            this.buttonOtvori.TabIndex = 1;
            this.buttonOtvori.Text = "Otvori Message box";
            this.buttonOtvori.UseVisualStyleBackColor = true;
            this.buttonOtvori.Click += new System.EventHandler(this.mbButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 331);
            this.Controls.Add(this.buttonOtvori);
            this.Controls.Add(this.txtBoxRezultat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxRezultat;
        private System.Windows.Forms.Button buttonOtvori;
    }
}

