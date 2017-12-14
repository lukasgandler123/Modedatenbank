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
            this.art_anlegen_artnr = new System.Windows.Forms.TextBox();
            this.lbl_Telefon = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_Nachname = new System.Windows.Forms.Label();
            this.lbl_Vorname = new System.Windows.Forms.Label();
            this.btn_anlegen = new System.Windows.Forms.Button();
            this.art_anlegen_kategorie = new System.Windows.Forms.ComboBox();
            this.art_anlegen_marke = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // art_anlegen_bezeichnung
            // 
            this.art_anlegen_bezeichnung.Location = new System.Drawing.Point(142, 84);
            this.art_anlegen_bezeichnung.Name = "art_anlegen_bezeichnung";
            this.art_anlegen_bezeichnung.Size = new System.Drawing.Size(213, 20);
            this.art_anlegen_bezeichnung.TabIndex = 32;
            // 
            // art_anlegen_artnr
            // 
            this.art_anlegen_artnr.Location = new System.Drawing.Point(142, 6);
            this.art_anlegen_artnr.Name = "art_anlegen_artnr";
            this.art_anlegen_artnr.Size = new System.Drawing.Size(213, 20);
            this.art_anlegen_artnr.TabIndex = 29;
            this.art_anlegen_artnr.TextChanged += new System.EventHandler(this.art_anlegen_artnr_TextChanged);
            // 
            // lbl_Telefon
            // 
            this.lbl_Telefon.AutoSize = true;
            this.lbl_Telefon.Location = new System.Drawing.Point(12, 87);
            this.lbl_Telefon.Name = "lbl_Telefon";
            this.lbl_Telefon.Size = new System.Drawing.Size(69, 13);
            this.lbl_Telefon.TabIndex = 24;
            this.lbl_Telefon.Text = "Bezeichnung";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(12, 61);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(37, 13);
            this.lbl_email.TabIndex = 23;
            this.lbl_email.Text = "Marke";
            // 
            // lbl_Nachname
            // 
            this.lbl_Nachname.AutoSize = true;
            this.lbl_Nachname.Location = new System.Drawing.Point(12, 35);
            this.lbl_Nachname.Name = "lbl_Nachname";
            this.lbl_Nachname.Size = new System.Drawing.Size(52, 13);
            this.lbl_Nachname.TabIndex = 22;
            this.lbl_Nachname.Text = "Kategorie";
            // 
            // lbl_Vorname
            // 
            this.lbl_Vorname.AutoSize = true;
            this.lbl_Vorname.Location = new System.Drawing.Point(12, 9);
            this.lbl_Vorname.Name = "lbl_Vorname";
            this.lbl_Vorname.Size = new System.Drawing.Size(73, 13);
            this.lbl_Vorname.TabIndex = 21;
            this.lbl_Vorname.Text = "Artikelnummer";
            // 
            // btn_anlegen
            // 
            this.btn_anlegen.Location = new System.Drawing.Point(12, 110);
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
            this.art_anlegen_kategorie.Location = new System.Drawing.Point(142, 30);
            this.art_anlegen_kategorie.Name = "art_anlegen_kategorie";
            this.art_anlegen_kategorie.Size = new System.Drawing.Size(213, 21);
            this.art_anlegen_kategorie.TabIndex = 33;
            // 
            // art_anlegen_marke
            // 
            this.art_anlegen_marke.FormattingEnabled = true;
            this.art_anlegen_marke.Location = new System.Drawing.Point(142, 57);
            this.art_anlegen_marke.Name = "art_anlegen_marke";
            this.art_anlegen_marke.Size = new System.Drawing.Size(213, 21);
            this.art_anlegen_marke.TabIndex = 34;
            // 
            // art_anlegen_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 180);
            this.Controls.Add(this.art_anlegen_marke);
            this.Controls.Add(this.art_anlegen_kategorie);
            this.Controls.Add(this.art_anlegen_bezeichnung);
            this.Controls.Add(this.art_anlegen_artnr);
            this.Controls.Add(this.lbl_Telefon);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_Nachname);
            this.Controls.Add(this.lbl_Vorname);
            this.Controls.Add(this.btn_anlegen);
            this.Name = "art_anlegen_form";
            this.Text = "art_anlegen_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox art_anlegen_bezeichnung;
        private System.Windows.Forms.TextBox art_anlegen_artnr;
        private System.Windows.Forms.Label lbl_Telefon;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_Nachname;
        private System.Windows.Forms.Label lbl_Vorname;
        private System.Windows.Forms.Button btn_anlegen;
        private System.Windows.Forms.ComboBox art_anlegen_kategorie;
        private System.Windows.Forms.ComboBox art_anlegen_marke;
    }
}