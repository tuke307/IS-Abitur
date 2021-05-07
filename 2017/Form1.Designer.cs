
namespace Vorabi._2018
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.nud_karten = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_ermaeßigt = new System.Windows.Forms.RadioButton();
            this.rb_vollerbetrag = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_jahreskarte = new System.Windows.Forms.RadioButton();
            this.rb_tageskarte = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kaufen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_karten = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_karten)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nud_karten
            // 
            this.nud_karten.Location = new System.Drawing.Point(41, 151);
            this.nud_karten.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_karten.Name = "nud_karten";
            this.nud_karten.Size = new System.Drawing.Size(120, 20);
            this.nud_karten.TabIndex = 0;
            this.nud_karten.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_ermaeßigt);
            this.groupBox1.Controls.Add(this.rb_vollerbetrag);
            this.groupBox1.Location = new System.Drawing.Point(513, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zahlungsart:";
            // 
            // rb_ermaeßigt
            // 
            this.rb_ermaeßigt.AutoSize = true;
            this.rb_ermaeßigt.Location = new System.Drawing.Point(24, 63);
            this.rb_ermaeßigt.Name = "rb_ermaeßigt";
            this.rb_ermaeßigt.Size = new System.Drawing.Size(138, 17);
            this.rb_ermaeßigt.TabIndex = 1;
            this.rb_ermaeßigt.TabStop = true;
            this.rb_ermaeßigt.Text = "ermäßigter Betrag (Kind)";
            this.rb_ermaeßigt.UseVisualStyleBackColor = true;
            // 
            // rb_vollerbetrag
            // 
            this.rb_vollerbetrag.AutoSize = true;
            this.rb_vollerbetrag.Location = new System.Drawing.Point(24, 31);
            this.rb_vollerbetrag.Name = "rb_vollerbetrag";
            this.rb_vollerbetrag.Size = new System.Drawing.Size(155, 17);
            this.rb_vollerbetrag.TabIndex = 0;
            this.rb_vollerbetrag.TabStop = true;
            this.rb_vollerbetrag.Text = "voller Betrag (Erwachsener)";
            this.rb_vollerbetrag.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_jahreskarte);
            this.groupBox2.Controls.Add(this.rb_tageskarte);
            this.groupBox2.Location = new System.Drawing.Point(271, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kartenart:";
            // 
            // rb_jahreskarte
            // 
            this.rb_jahreskarte.AutoSize = true;
            this.rb_jahreskarte.Location = new System.Drawing.Point(31, 63);
            this.rb_jahreskarte.Name = "rb_jahreskarte";
            this.rb_jahreskarte.Size = new System.Drawing.Size(92, 17);
            this.rb_jahreskarte.TabIndex = 1;
            this.rb_jahreskarte.TabStop = true;
            this.rb_jahreskarte.Text = "Jahreskarte(n)";
            this.rb_jahreskarte.UseVisualStyleBackColor = true;
            // 
            // rb_tageskarte
            // 
            this.rb_tageskarte.AutoSize = true;
            this.rb_tageskarte.Location = new System.Drawing.Point(31, 31);
            this.rb_tageskarte.Name = "rb_tageskarte";
            this.rb_tageskarte.Size = new System.Drawing.Size(91, 17);
            this.rb_tageskarte.TabIndex = 0;
            this.rb_tageskarte.TabStop = true;
            this.rb_tageskarte.Text = "Tageskarte(n)";
            this.rb_tageskarte.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Anzahl Karten";
            // 
            // btn_kaufen
            // 
            this.btn_kaufen.Location = new System.Drawing.Point(141, 373);
            this.btn_kaufen.Name = "btn_kaufen";
            this.btn_kaufen.Size = new System.Drawing.Size(170, 23);
            this.btn_kaufen.TabIndex = 4;
            this.btn_kaufen.Text = "Karte(n) kaufen";
            this.btn_kaufen.UseVisualStyleBackColor = true;
            this.btn_kaufen.Click += new System.EventHandler(this.btn_kaufen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "gespeicherte Kartendaten nach dem Kauf:";
            // 
            // txtb_karten
            // 
            this.txtb_karten.AcceptsReturn = true;
            this.txtb_karten.Location = new System.Drawing.Point(359, 373);
            this.txtb_karten.Multiline = true;
            this.txtb_karten.Name = "txtb_karten";
            this.txtb_karten.Size = new System.Drawing.Size(354, 150);
            this.txtb_karten.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 643);
            this.Controls.Add(this.txtb_karten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_kaufen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nud_karten);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_karten)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown nud_karten;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_ermaeßigt;
        private System.Windows.Forms.RadioButton rb_vollerbetrag;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_jahreskarte;
        private System.Windows.Forms.RadioButton rb_tageskarte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_kaufen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_karten;
    }
}

