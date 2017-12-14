namespace Lagerverwaltung___Mode
{
    partial class art_anlegen_form
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
            this.art_anlegen_bezeichnung = new System.Windows.Forms.TextBox();
            this.lbl_Telefon = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_Nachname = new System.Windows.Forms.Label();
            this.btn_anlegen = new System.Windows.Forms.Button();
            this.art_anlegen_kategorie = new System.Windows.Forms.ComboBox();
            this.art_anlegen_marke = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // art_anlegen_bezeichnung
            // 
            this.art_anlegen_bezeichnung.Location = new System.Drawing.Point(96, 57);
            this.art_anlegen_bezeichnung.Name = "art_anlegen_bezeichnung";
            this.art_anlegen_bezeichnung.Size = new System.Drawing.Size(259, 20);
            this.art_anlegen_bezeichnung.TabIndex = 32;
            // 
            // lbl_Telefon
            // 
            this.lbl_Telefon.AutoSize = true;
            this.lbl_Telefon.Location = new System.Drawing.Point(9, 60);
            this.lbl_Telefon.Name = "lbl_Telefon";
            this.lbl_Telefon.Size = new System.Drawing.Size(69, 13);
            this.lbl_Telefon.TabIndex = 24;
            this.lbl_Telefon.Text = "Bezeichnung";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(12, 33);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(37, 13);
            this.lbl_email.TabIndex = 23;
            this.lbl_email.Text = "Marke";
            // 
            // lbl_Nachname
            // 
            this.lbl_Nachname.AutoSize = true;
            this.lbl_Nachname.Location = new System.Drawing.Point(12, 6);
            this.lbl_Nachname.Name = "lbl_Nachname";
            this.lbl_Nachname.Size = new System.Drawing.Size(52, 13);
            this.lbl_Nachname.TabIndex = 22;
            this.lbl_Nachname.Text = "Kategorie";
            // 
            // btn_anlegen
            // 
            this.btn_anlegen.Location = new System.Drawing.Point(12, 83);
            this.btn_anlegen.Name = "btn_anlegen";
            this.btn_anlegen.Size = new System.Drawing.Size(343, 65);
            this.btn_anlegen.TabIndex = 19;
            this.btn_anlegen.Text = "Artikel anlegen";
            this.btn_anlegen.UseVisualStyleBackColor = true;
            this.btn_anlegen.Click += new System.EventHandler(this.btn_anlegen_Click);
            // 
            // art_anlegen_kategorie
            // 
            this.art_anlegen_kategorie.FormattingEnabled = true;
            this.art_anlegen_kategorie.Items.AddRange(new object[] {
            "",
            ""});
            this.art_anlegen_kategorie.Location = new System.Drawing.Point(96, 3);
            this.art_anlegen_kategorie.Name = "art_anlegen_kategorie";
            this.art_anlegen_kategorie.Size = new System.Drawing.Size(259, 21);
            this.art_anlegen_kategorie.TabIndex = 33;
            // 
            // art_anlegen_marke
            // 
            this.art_anlegen_marke.FormattingEnabled = true;
            this.art_anlegen_marke.Location = new System.Drawing.Point(96, 30);
            this.art_anlegen_marke.Name = "art_anlegen_marke";
            this.art_anlegen_marke.Size = new System.Drawing.Size(259, 21);
            this.art_anlegen_marke.TabIndex = 34;
            // 
            // art_anlegen_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 155);
            this.Controls.Add(this.art_anlegen_marke);
            this.Controls.Add(this.art_anlegen_kategorie);
            this.Controls.Add(this.art_anlegen_bezeichnung);
            this.Controls.Add(this.lbl_Telefon);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_Nachname);
            this.Controls.Add(this.btn_anlegen);
            this.Name = "art_anlegen_form";
            this.Text = "art_anlegen_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox art_anlegen_bezeichnung;
        private System.Windows.Forms.Label lbl_Telefon;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_Nachname;
        private System.Windows.Forms.Button btn_anlegen;
        private System.Windows.Forms.ComboBox art_anlegen_kategorie;
        private System.Windows.Forms.ComboBox art_anlegen_marke;
    }
}