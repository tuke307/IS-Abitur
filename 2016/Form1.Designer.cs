
namespace _2016
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_einlesen = new System.Windows.Forms.Button();
            this.btn_erstellen = new System.Windows.Forms.Button();
            this.dgv_termine = new System.Windows.Forms.DataGridView();
            this.Starttag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Startzeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endtag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endzeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Beschreibung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_termine)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_einlesen
            // 
            this.btn_einlesen.Location = new System.Drawing.Point(26, 98);
            this.btn_einlesen.Name = "btn_einlesen";
            this.btn_einlesen.Size = new System.Drawing.Size(168, 23);
            this.btn_einlesen.TabIndex = 0;
            this.btn_einlesen.Text = "Kalenderdatei einlesen";
            this.btn_einlesen.UseVisualStyleBackColor = true;
            this.btn_einlesen.Click += new System.EventHandler(this.btn_einlesen_Click);
            // 
            // btn_erstellen
            // 
            this.btn_erstellen.Location = new System.Drawing.Point(350, 98);
            this.btn_erstellen.Name = "btn_erstellen";
            this.btn_erstellen.Size = new System.Drawing.Size(154, 23);
            this.btn_erstellen.TabIndex = 1;
            this.btn_erstellen.Text = "Termin erstellen";
            this.btn_erstellen.UseVisualStyleBackColor = true;
            // 
            // dgv_termine
            // 
            this.dgv_termine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_termine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Starttag,
            this.Startzeit,
            this.Endtag,
            this.Endzeit,
            this.Ort,
            this.Titel,
            this.Beschreibung});
            this.dgv_termine.Location = new System.Drawing.Point(26, 194);
            this.dgv_termine.Name = "dgv_termine";
            this.dgv_termine.RowTemplate.Height = 25;
            this.dgv_termine.Size = new System.Drawing.Size(785, 211);
            this.dgv_termine.TabIndex = 2;
            // 
            // Starttag
            // 
            this.Starttag.HeaderText = "Starttag";
            this.Starttag.Name = "Starttag";
            // 
            // Startzeit
            // 
            this.Startzeit.HeaderText = "Startzeit";
            this.Startzeit.Name = "Startzeit";
            // 
            // Endtag
            // 
            this.Endtag.HeaderText = "Endtag";
            this.Endtag.Name = "Endtag";
            // 
            // Endzeit
            // 
            this.Endzeit.HeaderText = "Endzeit";
            this.Endzeit.Name = "Endzeit";
            // 
            // Ort
            // 
            this.Ort.HeaderText = "Ort";
            this.Ort.Name = "Ort";
            // 
            // Titel
            // 
            this.Titel.HeaderText = "Titel";
            this.Titel.Name = "Titel";
            // 
            // Beschreibung
            // 
            this.Beschreibung.HeaderText = "Beschreibung";
            this.Beschreibung.Name = "Beschreibung";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 450);
            this.Controls.Add(this.dgv_termine);
            this.Controls.Add(this.btn_erstellen);
            this.Controls.Add(this.btn_einlesen);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_termine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_einlesen;
        private System.Windows.Forms.Button btn_erstellen;
        private System.Windows.Forms.DataGridView dgv_termine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Starttag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Startzeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endtag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endzeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Beschreibung;
    }
}

