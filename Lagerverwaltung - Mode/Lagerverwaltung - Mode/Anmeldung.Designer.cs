namespace Lagerverwaltung___Mode
{
    partial class frm_Anmelden
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
            this.lbl_Benutzername = new System.Windows.Forms.Label();
            this.txt_Benutzername = new System.Windows.Forms.TextBox();
            this.btn_Abbrechen = new System.Windows.Forms.Button();
            this.lbl_Passwort = new System.Windows.Forms.Label();
            this.txt_Passwort = new System.Windows.Forms.TextBox();
            this.btn_Anmelden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Benutzername
            // 
            this.lbl_Benutzername.AutoSize = true;
            this.lbl_Benutzername.Location = new System.Drawing.Point(12, 22);
            this.lbl_Benutzername.Name = "lbl_Benutzername";
            this.lbl_Benutzername.Size = new System.Drawing.Size(75, 13);
            this.lbl_Benutzername.TabIndex = 0;
            this.lbl_Benutzername.Text = "Benutzername";
            // 
            // txt_Benutzername
            // 
            this.txt_Benutzername.Location = new System.Drawing.Point(93, 19);
            this.txt_Benutzername.Name = "txt_Benutzername";
            this.txt_Benutzername.Size = new System.Drawing.Size(247, 20);
            this.txt_Benutzername.TabIndex = 1;
            // 
            // btn_Abbrechen
            // 
            this.btn_Abbrechen.Location = new System.Drawing.Point(190, 84);
            this.btn_Abbrechen.Name = "btn_Abbrechen";
            this.btn_Abbrechen.Size = new System.Drawing.Size(150, 45);
            this.btn_Abbrechen.TabIndex = 4;
            this.btn_Abbrechen.Text = "Abbrechen";
            this.btn_Abbrechen.UseVisualStyleBackColor = true;
            this.btn_Abbrechen.Click += new System.EventHandler(this.btn_Abbrechen_Click);
            // 
            // lbl_Passwort
            // 
            this.lbl_Passwort.AutoSize = true;
            this.lbl_Passwort.Location = new System.Drawing.Point(12, 48);
            this.lbl_Passwort.Name = "lbl_Passwort";
            this.lbl_Passwort.Size = new System.Drawing.Size(50, 13);
            this.lbl_Passwort.TabIndex = 3;
            this.lbl_Passwort.Text = "Passwort";
            // 
            // txt_Passwort
            // 
            this.txt_Passwort.Location = new System.Drawing.Point(93, 45);
            this.txt_Passwort.Name = "txt_Passwort";
            this.txt_Passwort.Size = new System.Drawing.Size(247, 20);
            this.txt_Passwort.TabIndex = 2;
            this.txt_Passwort.UseSystemPasswordChar = true;
            // 
            // btn_Anmelden
            // 
            this.btn_Anmelden.Location = new System.Drawing.Point(15, 84);
            this.btn_Anmelden.Name = "btn_Anmelden";
            this.btn_Anmelden.Size = new System.Drawing.Size(150, 45);
            this.btn_Anmelden.TabIndex = 3;
            this.btn_Anmelden.Text = "Anmelden";
            this.btn_Anmelden.UseVisualStyleBackColor = true;
            this.btn_Anmelden.Click += new System.EventHandler(this.btn_Anmelden_Click);
            // 
            // frm_Anmelden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 143);
            this.Controls.Add(this.btn_Anmelden);
            this.Controls.Add(this.txt_Passwort);
            this.Controls.Add(this.lbl_Passwort);
            this.Controls.Add(this.btn_Abbrechen);
            this.Controls.Add(this.txt_Benutzername);
            this.Controls.Add(this.lbl_Benutzername);
            this.Name = "frm_Anmelden";
            this.Text = "Anmelden";
            this.Load += new System.EventHandler(this.frm_Anmelden_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Benutzername;
        private System.Windows.Forms.TextBox txt_Benutzername;
        private System.Windows.Forms.Button btn_Abbrechen;
        private System.Windows.Forms.Label lbl_Passwort;
        private System.Windows.Forms.TextBox txt_Passwort;
        private System.Windows.Forms.Button btn_Anmelden;
    }
}

