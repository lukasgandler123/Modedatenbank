namespace Lagerverwaltung___Mode
{
    partial class kund_anlegen_form
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
            this.kund_anlegen_land = new System.Windows.Forms.ComboBox();
            this.kund_anlegen_kunde = new System.Windows.Forms.ComboBox();
            this.kund_anlegen_ort = new System.Windows.Forms.TextBox();
            this.kund_lbl_bezeichnung = new System.Windows.Forms.Label();
            this.kund_lbl_land = new System.Windows.Forms.Label();
            this.kund_lbl_kunde = new System.Windows.Forms.Label();
            this.btn_kund_erfassen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.kund_anlegen_anschrift = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // kund_anlegen_land
            // 
            this.kund_anlegen_land.FormattingEnabled = true;
            this.kund_anlegen_land.Location = new System.Drawing.Point(96, 37);
            this.kund_anlegen_land.Name = "kund_anlegen_land";
            this.kund_anlegen_land.Size = new System.Drawing.Size(259, 21);
            this.kund_anlegen_land.TabIndex = 41;
            // 
            // kund_anlegen_kunde
            // 
            this.kund_anlegen_kunde.FormattingEnabled = true;
            this.kund_anlegen_kunde.Items.AddRange(new object[] {
            "",
            ""});
            this.kund_anlegen_kunde.Location = new System.Drawing.Point(96, 10);
            this.kund_anlegen_kunde.Name = "kund_anlegen_kunde";
            this.kund_anlegen_kunde.Size = new System.Drawing.Size(259, 21);
            this.kund_anlegen_kunde.TabIndex = 40;
            // 
            // kund_anlegen_ort
            // 
            this.kund_anlegen_ort.Location = new System.Drawing.Point(96, 64);
            this.kund_anlegen_ort.Name = "kund_anlegen_ort";
            this.kund_anlegen_ort.Size = new System.Drawing.Size(259, 20);
            this.kund_anlegen_ort.TabIndex = 39;
            // 
            // kund_lbl_bezeichnung
            // 
            this.kund_lbl_bezeichnung.AutoSize = true;
            this.kund_lbl_bezeichnung.Location = new System.Drawing.Point(9, 67);
            this.kund_lbl_bezeichnung.Name = "kund_lbl_bezeichnung";
            this.kund_lbl_bezeichnung.Size = new System.Drawing.Size(21, 13);
            this.kund_lbl_bezeichnung.TabIndex = 38;
            this.kund_lbl_bezeichnung.Text = "Ort";
            // 
            // kund_lbl_land
            // 
            this.kund_lbl_land.AutoSize = true;
            this.kund_lbl_land.Location = new System.Drawing.Point(9, 40);
            this.kund_lbl_land.Name = "kund_lbl_land";
            this.kund_lbl_land.Size = new System.Drawing.Size(31, 13);
            this.kund_lbl_land.TabIndex = 37;
            this.kund_lbl_land.Text = "Land";
            // 
            // kund_lbl_kunde
            // 
            this.kund_lbl_kunde.AutoSize = true;
            this.kund_lbl_kunde.Location = new System.Drawing.Point(9, 13);
            this.kund_lbl_kunde.Name = "kund_lbl_kunde";
            this.kund_lbl_kunde.Size = new System.Drawing.Size(38, 13);
            this.kund_lbl_kunde.TabIndex = 36;
            this.kund_lbl_kunde.Text = "Kunde";
            // 
            // btn_kund_erfassen
            // 
            this.btn_kund_erfassen.Location = new System.Drawing.Point(15, 116);
            this.btn_kund_erfassen.Name = "btn_kund_erfassen";
            this.btn_kund_erfassen.Size = new System.Drawing.Size(343, 65);
            this.btn_kund_erfassen.TabIndex = 35;
            this.btn_kund_erfassen.Text = "Kunde erfassen";
            this.btn_kund_erfassen.UseVisualStyleBackColor = true;
            this.btn_kund_erfassen.Click += new System.EventHandler(this.btn_kund_erfassen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Anschrift";
            // 
            // kund_anlegen_anschrift
            // 
            this.kund_anlegen_anschrift.Location = new System.Drawing.Point(96, 90);
            this.kund_anlegen_anschrift.Name = "kund_anlegen_anschrift";
            this.kund_anlegen_anschrift.Size = new System.Drawing.Size(259, 20);
            this.kund_anlegen_anschrift.TabIndex = 44;
            // 
            // kund_anlegen_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 196);
            this.Controls.Add(this.kund_anlegen_anschrift);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kund_anlegen_land);
            this.Controls.Add(this.kund_anlegen_kunde);
            this.Controls.Add(this.kund_anlegen_ort);
            this.Controls.Add(this.kund_lbl_bezeichnung);
            this.Controls.Add(this.kund_lbl_land);
            this.Controls.Add(this.kund_lbl_kunde);
            this.Controls.Add(this.btn_kund_erfassen);
            this.Name = "kund_anlegen_form";
            this.Text = "kund_anlegen_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox kund_anlegen_land;
        private System.Windows.Forms.ComboBox kund_anlegen_kunde;
        private System.Windows.Forms.TextBox kund_anlegen_ort;
        private System.Windows.Forms.Label kund_lbl_bezeichnung;
        private System.Windows.Forms.Label kund_lbl_land;
        private System.Windows.Forms.Label kund_lbl_kunde;
        private System.Windows.Forms.Button btn_kund_erfassen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kund_anlegen_anschrift;
    }
}