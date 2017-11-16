namespace Lagerverwaltung___Mode
{
    partial class Benutzer_Bearbeiten
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
            this.btn_Abbrechen = new System.Windows.Forms.Button();
            this.tlp_Benutzer = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // btn_Abbrechen
            // 
            this.btn_Abbrechen.Location = new System.Drawing.Point(310, 558);
            this.btn_Abbrechen.Name = "btn_Abbrechen";
            this.btn_Abbrechen.Size = new System.Drawing.Size(215, 45);
            this.btn_Abbrechen.TabIndex = 0;
            this.btn_Abbrechen.Text = "Abbrechen";
            this.btn_Abbrechen.UseVisualStyleBackColor = true;
            this.btn_Abbrechen.Click += new System.EventHandler(this.btn_Abbrechen_Click);
            // 
            // tlp_Benutzer
            // 
            this.tlp_Benutzer.AutoScroll = true;
            this.tlp_Benutzer.AutoSize = true;
            this.tlp_Benutzer.ColumnCount = 4;
            this.tlp_Benutzer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.05882F));
            this.tlp_Benutzer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.94118F));
            this.tlp_Benutzer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tlp_Benutzer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 339F));
            this.tlp_Benutzer.Location = new System.Drawing.Point(12, 12);
            this.tlp_Benutzer.Name = "tlp_Benutzer";
            this.tlp_Benutzer.RowCount = 1;
            this.tlp_Benutzer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Benutzer.Size = new System.Drawing.Size(514, 0);
            this.tlp_Benutzer.TabIndex = 1;
            // 
            // Benutzer_Bearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 615);
            this.Controls.Add(this.tlp_Benutzer);
            this.Controls.Add(this.btn_Abbrechen);
            this.Name = "Benutzer_Bearbeiten";
            this.Text = "Benutzer_Bearbeiten";
            this.Load += new System.EventHandler(this.Benutzer_Bearbeiten_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Abbrechen;
        private System.Windows.Forms.TableLayoutPanel tlp_Benutzer;
    }
}