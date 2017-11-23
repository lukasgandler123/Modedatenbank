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
            this.components = new System.ComponentModel.Container();
            this.btn_Abbrechen = new System.Windows.Forms.Button();
            this.dgv_Benutzer = new System.Windows.Forms.DataGridView();
            this.team07DataSet_Benutzer = new Lagerverwaltung___Mode.team07DataSet_Benutzer();
            this.tbenutzerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t_benutzerTableAdapter = new Lagerverwaltung___Mode.team07DataSet_BenutzerTableAdapters.t_benutzerTableAdapter();
            this.team07DataSetBenutzerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Benutzer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.team07DataSet_Benutzer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbenutzerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.team07DataSetBenutzerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Abbrechen
            // 
            this.btn_Abbrechen.Location = new System.Drawing.Point(666, 377);
            this.btn_Abbrechen.Name = "btn_Abbrechen";
            this.btn_Abbrechen.Size = new System.Drawing.Size(215, 45);
            this.btn_Abbrechen.TabIndex = 0;
            this.btn_Abbrechen.Text = "Zurück";
            this.btn_Abbrechen.UseVisualStyleBackColor = true;
            this.btn_Abbrechen.Click += new System.EventHandler(this.btn_Abbrechen_Click);
            // 
            // dgv_Benutzer
            // 
            this.dgv_Benutzer.AllowUserToAddRows = false;
            this.dgv_Benutzer.AllowUserToDeleteRows = false;
            this.dgv_Benutzer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Benutzer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Benutzer.Location = new System.Drawing.Point(12, 10);
            this.dgv_Benutzer.Name = "dgv_Benutzer";
            this.dgv_Benutzer.Size = new System.Drawing.Size(869, 361);
            this.dgv_Benutzer.TabIndex = 1;
            this.dgv_Benutzer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Benutzer_CellClick);
            this.dgv_Benutzer.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Benutzer_Bearbeiten);
            // 
            // team07DataSet_Benutzer
            // 
            this.team07DataSet_Benutzer.DataSetName = "team07DataSet_Benutzer";
            this.team07DataSet_Benutzer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbenutzerBindingSource
            // 
            this.tbenutzerBindingSource.DataMember = "t_benutzer";
            this.tbenutzerBindingSource.DataSource = this.team07DataSet_Benutzer;
            // 
            // t_benutzerTableAdapter
            // 
            this.t_benutzerTableAdapter.ClearBeforeFill = true;
            // 
            // team07DataSetBenutzerBindingSource
            // 
            this.team07DataSetBenutzerBindingSource.DataSource = this.team07DataSet_Benutzer;
            this.team07DataSetBenutzerBindingSource.Position = 0;
            // 
            // Benutzer_Bearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 434);
            this.Controls.Add(this.dgv_Benutzer);
            this.Controls.Add(this.btn_Abbrechen);
            this.Name = "Benutzer_Bearbeiten";
            this.Text = "Benutzer_Bearbeiten";
            this.Load += new System.EventHandler(this.Benutzer_Bearbeiten_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Benutzer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.team07DataSet_Benutzer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbenutzerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.team07DataSetBenutzerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Abbrechen;
        private System.Windows.Forms.DataGridView dgv_Benutzer;
        private team07DataSet_Benutzer team07DataSet_Benutzer;
        private System.Windows.Forms.BindingSource tbenutzerBindingSource;
        private team07DataSet_BenutzerTableAdapters.t_benutzerTableAdapter t_benutzerTableAdapter;
        private System.Windows.Forms.BindingSource team07DataSetBenutzerBindingSource;
    }
}