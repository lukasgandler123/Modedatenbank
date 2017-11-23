namespace Lagerverwaltung___Mode
{
    partial class PasswortReseten
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
            this.lbl_Passwort = new System.Windows.Forms.Label();
            this.lbl_Bestaetigung = new System.Windows.Forms.Label();
            this.txt_Passwort = new System.Windows.Forms.TextBox();
            this.txt_PasswortBestaetigen = new System.Windows.Forms.TextBox();
            this.btn_Speichern = new System.Windows.Forms.Button();
            this.btn_Abbrechen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Passwort
            // 
            this.lbl_Passwort.AutoSize = true;
            this.lbl_Passwort.Location = new System.Drawing.Point(12, 9);
            this.lbl_Passwort.Name = "lbl_Passwort";
            this.lbl_Passwort.Size = new System.Drawing.Size(84, 13);
            this.lbl_Passwort.TabIndex = 0;
            this.lbl_Passwort.Text = "Neues Passwort";
            // 
            // lbl_Bestaetigung
            // 
            this.lbl_Bestaetigung.AutoSize = true;
            this.lbl_Bestaetigung.Location = new System.Drawing.Point(12, 35);
            this.lbl_Bestaetigung.Name = "lbl_Bestaetigung";
            this.lbl_Bestaetigung.Size = new System.Drawing.Size(102, 13);
            this.lbl_Bestaetigung.TabIndex = 1;
            this.lbl_Bestaetigung.Text = "Passwort bestätigen";
            // 
            // txt_Passwort
            // 
            this.txt_Passwort.Location = new System.Drawing.Point(143, 6);
            this.txt_Passwort.Name = "txt_Passwort";
            this.txt_Passwort.PasswordChar = '*';
            this.txt_Passwort.Size = new System.Drawing.Size(203, 20);
            this.txt_Passwort.TabIndex = 2;
            // 
            // txt_PasswortBestaetigen
            // 
            this.txt_PasswortBestaetigen.Location = new System.Drawing.Point(143, 32);
            this.txt_PasswortBestaetigen.Name = "txt_PasswortBestaetigen";
            this.txt_PasswortBestaetigen.PasswordChar = '*';
            this.txt_PasswortBestaetigen.Size = new System.Drawing.Size(203, 20);
            this.txt_PasswortBestaetigen.TabIndex = 3;
            // 
            // btn_Speichern
            // 
            this.btn_Speichern.Location = new System.Drawing.Point(12, 60);
            this.btn_Speichern.Name = "btn_Speichern";
            this.btn_Speichern.Size = new System.Drawing.Size(164, 40);
            this.btn_Speichern.TabIndex = 4;
            this.btn_Speichern.Text = "Speichern";
            this.btn_Speichern.UseVisualStyleBackColor = true;
            this.btn_Speichern.Click += new System.EventHandler(this.btn_Speichern_Click);
            // 
            // btn_Abbrechen
            // 
            this.btn_Abbrechen.Location = new System.Drawing.Point(182, 58);
            this.btn_Abbrechen.Name = "btn_Abbrechen";
            this.btn_Abbrechen.Size = new System.Drawing.Size(164, 42);
            this.btn_Abbrechen.TabIndex = 5;
            this.btn_Abbrechen.Text = "Abbrechen";
            this.btn_Abbrechen.UseVisualStyleBackColor = true;
            this.btn_Abbrechen.Click += new System.EventHandler(this.btn_Abbrechen_Click);
            // 
            // PasswortReseten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 112);
            this.Controls.Add(this.btn_Abbrechen);
            this.Controls.Add(this.btn_Speichern);
            this.Controls.Add(this.txt_PasswortBestaetigen);
            this.Controls.Add(this.txt_Passwort);
            this.Controls.Add(this.lbl_Bestaetigung);
            this.Controls.Add(this.lbl_Passwort);
            this.Name = "PasswortReseten";
            this.Text = "PasswortReseten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Passwort;
        private System.Windows.Forms.Label lbl_Bestaetigung;
        private System.Windows.Forms.TextBox txt_Passwort;
        private System.Windows.Forms.TextBox txt_PasswortBestaetigen;
        private System.Windows.Forms.Button btn_Speichern;
        private System.Windows.Forms.Button btn_Abbrechen;
    }
}