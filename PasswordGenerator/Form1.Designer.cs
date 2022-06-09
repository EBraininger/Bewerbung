namespace PasswordGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Generiere = new System.Windows.Forms.Button();
            this.Anzeigen = new System.Windows.Forms.Button();
            this.speichern = new System.Windows.Forms.Button();
            this.textB1 = new System.Windows.Forms.TextBox();
            this.Zahl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Generiere
            // 
            this.Generiere.Location = new System.Drawing.Point(98, 299);
            this.Generiere.Name = "Generiere";
            this.Generiere.Size = new System.Drawing.Size(75, 23);
            this.Generiere.TabIndex = 1;
            this.Generiere.Text = "Generieren";
            this.Generiere.UseVisualStyleBackColor = true;
            this.Generiere.Click += new System.EventHandler(this.Generiere_Click);
            // 
            // Anzeigen
            // 
            this.Anzeigen.Location = new System.Drawing.Point(380, 299);
            this.Anzeigen.Name = "Anzeigen";
            this.Anzeigen.Size = new System.Drawing.Size(75, 23);
            this.Anzeigen.TabIndex = 2;
            this.Anzeigen.Text = "Anzeigen";
            this.Anzeigen.UseVisualStyleBackColor = true;
            this.Anzeigen.Click += new System.EventHandler(this.Anzeigen_Click);
            // 
            // speichern
            // 
            this.speichern.Location = new System.Drawing.Point(237, 299);
            this.speichern.Name = "speichern";
            this.speichern.Size = new System.Drawing.Size(75, 23);
            this.speichern.TabIndex = 3;
            this.speichern.Text = "Speichern";
            this.speichern.UseVisualStyleBackColor = true;
            this.speichern.Click += new System.EventHandler(this.speichern_Click);
            // 
            // textB1
            // 
            this.textB1.Location = new System.Drawing.Point(181, 205);
            this.textB1.Name = "textB1";
            this.textB1.Size = new System.Drawing.Size(217, 20);
            this.textB1.TabIndex = 4;
            this.textB1.TextChanged += new System.EventHandler(this.textB1_TextChanged);
            // 
            // Zahl
            // 
            this.Zahl.Location = new System.Drawing.Point(237, 231);
            this.Zahl.Name = "Zahl";
            this.Zahl.Size = new System.Drawing.Size(100, 20);
            this.Zahl.TabIndex = 5;
            this.Zahl.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Zahl);
            this.Controls.Add(this.textB1);
            this.Controls.Add(this.speichern);
            this.Controls.Add(this.Anzeigen);
            this.Controls.Add(this.Generiere);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Generiere;
        private System.Windows.Forms.Button Anzeigen;
        private System.Windows.Forms.Button speichern;
        private System.Windows.Forms.TextBox textB1;
        private System.Windows.Forms.TextBox Zahl;
    }
}

