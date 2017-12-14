namespace Lagerverwaltung___Mode
{
    partial class Artikel_Bearbeiten
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
            this.lbl_Kategorie = new System.Windows.Forms.Label();
            this.lbl_Marke = new System.Windows.Forms.Label();
            this.lbl_Bezeichnung = new System.Windows.Forms.Label();
            this.btn_Speichern = new System.Windows.Forms.Button();
            this.btn_Abbrechen = new System.Windows.Forms.Button();
            this.cmb_Kategorie = new System.Windows.Forms.ComboBox();
            this.txt_Marke = new System.Windows.Forms.TextBox();
            this.txt_Bezeichnung = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Kategorie
            // 
            this.lbl_Kategorie.AutoSize = true;
            this.lbl_Kategorie.Location = new System.Drawing.Point(77, 15);
            this.lbl_Kategorie.Name = "lbl_Kategorie";
            this.lbl_Kategorie.Size = new System.Drawing.Size(52, 13);
            this.lbl_Kategorie.TabIndex = 4;
            this.lbl_Kategorie.Text = "Kategorie";
            // 
            // lbl_Marke
            // 
            this.lbl_Marke.AutoSize = true;
            this.lbl_Marke.Location = new System.Drawing.Point(92, 41);
            this.lbl_Marke.Name = "lbl_Marke";
            this.lbl_Marke.Size = new System.Drawing.Size(37, 13);
            this.lbl_Marke.TabIndex = 5;
            this.lbl_Marke.Text = "Marke";
            // 
            // lbl_Bezeichnung
            // 
            this.lbl_Bezeichnung.AutoSize = true;
            this.lbl_Bezeichnung.Location = new System.Drawing.Point(60, 67);
            this.lbl_Bezeichnung.Name = "lbl_Bezeichnung";
            this.lbl_Bezeichnung.Size = new System.Drawing.Size(69, 13);
            this.lbl_Bezeichnung.TabIndex = 6;
            this.lbl_Bezeichnung.Text = "Bezeichnung";
            // 
            // btn_Speichern
            // 
            this.btn_Speichern.Location = new System.Drawing.Point(197, 90);
            this.btn_Speichern.Name = "btn_Speichern";
            this.btn_Speichern.Size = new System.Drawing.Size(168, 36);
            this.btn_Speichern.TabIndex = 7;
            this.btn_Speichern.Text = "Speichern";
            this.btn_Speichern.UseVisualStyleBackColor = true;
            this.btn_Speichern.Click += new System.EventHandler(this.btn_Speichern_Click);
            // 
            // btn_Abbrechen
            // 
            this.btn_Abbrechen.Location = new System.Drawing.Point(12, 90);
            this.btn_Abbrechen.Name = "btn_Abbrechen";
            this.btn_Abbrechen.Size = new System.Drawing.Size(179, 36);
            this.btn_Abbrechen.TabIndex = 8;
            this.btn_Abbrechen.Text = "Abbrechen";
            this.btn_Abbrechen.UseVisualStyleBackColor = true;
            this.btn_Abbrechen.Click += new System.EventHandler(this.btn_Abbrechen_Click);
            // 
            // cmb_Kategorie
            // 
            this.cmb_Kategorie.FormattingEnabled = true;
            this.cmb_Kategorie.Location = new System.Drawing.Point(135, 11);
            this.cmb_Kategorie.Name = "cmb_Kategorie";
            this.cmb_Kategorie.Size = new System.Drawing.Size(230, 21);
            this.cmb_Kategorie.TabIndex = 9;
            // 
            // txt_Marke
            // 
            this.txt_Marke.Location = new System.Drawing.Point(135, 38);
            this.txt_Marke.Name = "txt_Marke";
            this.txt_Marke.Size = new System.Drawing.Size(230, 20);
            this.txt_Marke.TabIndex = 10;
            // 
            // txt_Bezeichnung
            // 
            this.txt_Bezeichnung.Location = new System.Drawing.Point(135, 64);
            this.txt_Bezeichnung.Name = "txt_Bezeichnung";
            this.txt_Bezeichnung.Size = new System.Drawing.Size(230, 20);
            this.txt_Bezeichnung.TabIndex = 11;
            // 
            // Artikel_Bearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 138);
            this.Controls.Add(this.txt_Bezeichnung);
            this.Controls.Add(this.txt_Marke);
            this.Controls.Add(this.cmb_Kategorie);
            this.Controls.Add(this.btn_Abbrechen);
            this.Controls.Add(this.btn_Speichern);
            this.Controls.Add(this.lbl_Bezeichnung);
            this.Controls.Add(this.lbl_Marke);
            this.Controls.Add(this.lbl_Kategorie);
            this.Name = "Artikel_Bearbeiten";
            this.Text = "Artikel_Bearbeiten";
            this.Load += new System.EventHandler(this.Artikel_Bearbeiten_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Kategorie;
        private System.Windows.Forms.Label lbl_Marke;
        private System.Windows.Forms.Label lbl_Bezeichnung;
        private System.Windows.Forms.Button btn_Speichern;
        private System.Windows.Forms.Button btn_Abbrechen;
        private System.Windows.Forms.ComboBox cmb_Kategorie;
        private System.Windows.Forms.TextBox txt_Marke;
        private System.Windows.Forms.TextBox txt_Bezeichnung;
    }
}