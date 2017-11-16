namespace Lagerverwaltung___Mode
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abmeldenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eingangsjournalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ausgansjournalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.benutzerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuenBenutzerAnlegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.benutzerBearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbc_Lager = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbc_Daten = new System.Windows.Forms.TabControl();
            this.tbp_Artikel = new System.Windows.Forms.TabPage();
            this.tbp_Lieferanten = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tbp_Kunden = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tbc_Lager.SuspendLayout();
            this.tbc_Daten.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abmeldenToolStripMenuItem,
            this.eingangsjournalToolStripMenuItem,
            this.ausgansjournalToolStripMenuItem,
            this.benutzerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(810, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abmeldenToolStripMenuItem
            // 
            this.abmeldenToolStripMenuItem.Name = "abmeldenToolStripMenuItem";
            this.abmeldenToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.abmeldenToolStripMenuItem.Text = "Abmelden";
            this.abmeldenToolStripMenuItem.Click += new System.EventHandler(this.abmeldenToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // eingangsjournalToolStripMenuItem
            // 
            this.eingangsjournalToolStripMenuItem.Name = "eingangsjournalToolStripMenuItem";
            this.eingangsjournalToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.eingangsjournalToolStripMenuItem.Text = "Eingangsjournal";
            // 
            // ausgansjournalToolStripMenuItem
            // 
            this.ausgansjournalToolStripMenuItem.Name = "ausgansjournalToolStripMenuItem";
            this.ausgansjournalToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.ausgansjournalToolStripMenuItem.Text = "Ausgansjournal";
            // 
            // benutzerToolStripMenuItem
            // 
            this.benutzerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuenBenutzerAnlegenToolStripMenuItem,
            this.benutzerBearbeitenToolStripMenuItem});
            this.benutzerToolStripMenuItem.Name = "benutzerToolStripMenuItem";
            this.benutzerToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.benutzerToolStripMenuItem.Text = "Benutzer";
            // 
            // neuenBenutzerAnlegenToolStripMenuItem
            // 
            this.neuenBenutzerAnlegenToolStripMenuItem.Name = "neuenBenutzerAnlegenToolStripMenuItem";
            this.neuenBenutzerAnlegenToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.neuenBenutzerAnlegenToolStripMenuItem.Text = "Neuen Benutzer anlegen";
            // 
            // benutzerBearbeitenToolStripMenuItem
            // 
            this.benutzerBearbeitenToolStripMenuItem.Name = "benutzerBearbeitenToolStripMenuItem";
            this.benutzerBearbeitenToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.benutzerBearbeitenToolStripMenuItem.Text = "Benutzer bearbeiten";
            // 
            // tbc_Lager
            // 
            this.tbc_Lager.Controls.Add(this.tabPage1);
            this.tbc_Lager.Controls.Add(this.tabPage2);
            this.tbc_Lager.Controls.Add(this.tabPage5);
            this.tbc_Lager.Controls.Add(this.tabPage3);
            this.tbc_Lager.Location = new System.Drawing.Point(12, 27);
            this.tbc_Lager.Name = "tbc_Lager";
            this.tbc_Lager.SelectedIndex = 0;
            this.tbc_Lager.Size = new System.Drawing.Size(327, 476);
            this.tbc_Lager.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(319, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbc_Daten
            // 
            this.tbc_Daten.Controls.Add(this.tbp_Artikel);
            this.tbc_Daten.Controls.Add(this.tbp_Lieferanten);
            this.tbc_Daten.Controls.Add(this.tbp_Kunden);
            this.tbc_Daten.Location = new System.Drawing.Point(484, 27);
            this.tbc_Daten.Name = "tbc_Daten";
            this.tbc_Daten.SelectedIndex = 0;
            this.tbc_Daten.Size = new System.Drawing.Size(314, 472);
            this.tbc_Daten.TabIndex = 3;
            // 
            // tbp_Artikel
            // 
            this.tbp_Artikel.Location = new System.Drawing.Point(4, 22);
            this.tbp_Artikel.Name = "tbp_Artikel";
            this.tbp_Artikel.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Artikel.Size = new System.Drawing.Size(306, 446);
            this.tbp_Artikel.TabIndex = 0;
            this.tbp_Artikel.Text = "Artikel";
            this.tbp_Artikel.UseVisualStyleBackColor = true;
            // 
            // tbp_Lieferanten
            // 
            this.tbp_Lieferanten.Location = new System.Drawing.Point(4, 22);
            this.tbp_Lieferanten.Name = "tbp_Lieferanten";
            this.tbp_Lieferanten.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Lieferanten.Size = new System.Drawing.Size(306, 446);
            this.tbp_Lieferanten.TabIndex = 1;
            this.tbp_Lieferanten.Text = "Lieferanten";
            this.tbp_Lieferanten.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(319, 450);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tbp_Kunden
            // 
            this.tbp_Kunden.Location = new System.Drawing.Point(4, 22);
            this.tbp_Kunden.Name = "tbp_Kunden";
            this.tbp_Kunden.Size = new System.Drawing.Size(306, 446);
            this.tbp_Kunden.TabIndex = 2;
            this.tbp_Kunden.Text = "Kunden";
            this.tbp_Kunden.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(319, 450);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 515);
            this.Controls.Add(this.tbc_Daten);
            this.Controls.Add(this.tbc_Lager);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tbc_Lager.ResumeLayout(false);
            this.tbc_Daten.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abmeldenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eingangsjournalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ausgansjournalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem benutzerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuenBenutzerAnlegenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem benutzerBearbeitenToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tbc_Lager;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tbc_Daten;
        private System.Windows.Forms.TabPage tbp_Artikel;
        private System.Windows.Forms.TabPage tbp_Lieferanten;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tbp_Kunden;
        private System.Windows.Forms.TabPage tabPage3;
    }
}