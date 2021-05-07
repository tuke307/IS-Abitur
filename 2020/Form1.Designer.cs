
namespace ISVORABI
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
            this.pb_f = new System.Windows.Forms.PictureBox();
            this.pb_e = new System.Windows.Forms.PictureBox();
            this.pb_b = new System.Windows.Forms.PictureBox();
            this.pb_c = new System.Windows.Forms.PictureBox();
            this.pb_d = new System.Windows.Forms.PictureBox();
            this.pb_a = new System.Windows.Forms.PictureBox();
            this.pb_g = new System.Windows.Forms.PictureBox();
            this.txtb_wert = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_anzeigen = new System.Windows.Forms.Button();
            this.btn_wuerfeln_1 = new System.Windows.Forms.Button();
            this.nud_stellenindex = new System.Windows.Forms.NumericUpDown();
            this.btn_wuerfeln_2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_f)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_e)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_c)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stellenindex)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_f
            // 
            this.pb_f.Location = new System.Drawing.Point(81, 84);
            this.pb_f.Name = "pb_f";
            this.pb_f.Size = new System.Drawing.Size(26, 119);
            this.pb_f.TabIndex = 0;
            this.pb_f.TabStop = false;
            // 
            // pb_e
            // 
            this.pb_e.Location = new System.Drawing.Point(81, 257);
            this.pb_e.Name = "pb_e";
            this.pb_e.Size = new System.Drawing.Size(26, 119);
            this.pb_e.TabIndex = 1;
            this.pb_e.TabStop = false;
            // 
            // pb_b
            // 
            this.pb_b.Location = new System.Drawing.Point(266, 84);
            this.pb_b.Name = "pb_b";
            this.pb_b.Size = new System.Drawing.Size(26, 119);
            this.pb_b.TabIndex = 2;
            this.pb_b.TabStop = false;
            // 
            // pb_c
            // 
            this.pb_c.Location = new System.Drawing.Point(266, 257);
            this.pb_c.Name = "pb_c";
            this.pb_c.Size = new System.Drawing.Size(26, 119);
            this.pb_c.TabIndex = 3;
            this.pb_c.TabStop = false;
            // 
            // pb_d
            // 
            this.pb_d.Location = new System.Drawing.Point(121, 389);
            this.pb_d.Name = "pb_d";
            this.pb_d.Size = new System.Drawing.Size(132, 28);
            this.pb_d.TabIndex = 4;
            this.pb_d.TabStop = false;
            // 
            // pb_a
            // 
            this.pb_a.Location = new System.Drawing.Point(121, 40);
            this.pb_a.Name = "pb_a";
            this.pb_a.Size = new System.Drawing.Size(132, 28);
            this.pb_a.TabIndex = 5;
            this.pb_a.TabStop = false;
            // 
            // pb_g
            // 
            this.pb_g.Location = new System.Drawing.Point(121, 218);
            this.pb_g.Name = "pb_g";
            this.pb_g.Size = new System.Drawing.Size(132, 28);
            this.pb_g.TabIndex = 6;
            this.pb_g.TabStop = false;
            // 
            // txtb_wert
            // 
            this.txtb_wert.Location = new System.Drawing.Point(510, 155);
            this.txtb_wert.Name = "txtb_wert";
            this.txtb_wert.Size = new System.Drawing.Size(349, 31);
            this.txtb_wert.TabIndex = 7;
            this.txtb_wert.TextChanged += new System.EventHandler(this.txtb_wert_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Testwert (0...9)";
            // 
            // btn_anzeigen
            // 
            this.btn_anzeigen.Location = new System.Drawing.Point(510, 234);
            this.btn_anzeigen.Name = "btn_anzeigen";
            this.btn_anzeigen.Size = new System.Drawing.Size(349, 50);
            this.btn_anzeigen.TabIndex = 9;
            this.btn_anzeigen.Text = "Testwert anzeigen";
            this.btn_anzeigen.UseVisualStyleBackColor = true;
            this.btn_anzeigen.Click += new System.EventHandler(this.btn_anzeigen_Click);
            // 
            // btn_wuerfeln_1
            // 
            this.btn_wuerfeln_1.Location = new System.Drawing.Point(510, 345);
            this.btn_wuerfeln_1.Name = "btn_wuerfeln_1";
            this.btn_wuerfeln_1.Size = new System.Drawing.Size(349, 93);
            this.btn_wuerfeln_1.TabIndex = 10;
            this.btn_wuerfeln_1.Text = "würfeln (1...6)";
            this.btn_wuerfeln_1.UseVisualStyleBackColor = true;
            this.btn_wuerfeln_1.Click += new System.EventHandler(this.btn_wuerfeln_1_Click);
            // 
            // nud_stellenindex
            // 
            this.nud_stellenindex.Location = new System.Drawing.Point(133, 492);
            this.nud_stellenindex.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nud_stellenindex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_stellenindex.Name = "nud_stellenindex";
            this.nud_stellenindex.Size = new System.Drawing.Size(120, 31);
            this.nud_stellenindex.TabIndex = 11;
            this.nud_stellenindex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_stellenindex.ValueChanged += new System.EventHandler(this.nud_stellenindex_ValueChanged);
            // 
            // btn_wuerfeln_2
            // 
            this.btn_wuerfeln_2.Location = new System.Drawing.Point(510, 492);
            this.btn_wuerfeln_2.Name = "btn_wuerfeln_2";
            this.btn_wuerfeln_2.Size = new System.Drawing.Size(349, 93);
            this.btn_wuerfeln_2.TabIndex = 12;
            this.btn_wuerfeln_2.Text = "würfeln (100...999)";
            this.btn_wuerfeln_2.UseVisualStyleBackColor = true;
            this.btn_wuerfeln_2.Click += new System.EventHandler(this.btn_wuerfeln_2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 805);
            this.Controls.Add(this.btn_wuerfeln_2);
            this.Controls.Add(this.nud_stellenindex);
            this.Controls.Add(this.btn_wuerfeln_1);
            this.Controls.Add(this.btn_anzeigen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtb_wert);
            this.Controls.Add(this.pb_g);
            this.Controls.Add(this.pb_a);
            this.Controls.Add(this.pb_d);
            this.Controls.Add(this.pb_c);
            this.Controls.Add(this.pb_b);
            this.Controls.Add(this.pb_e);
            this.Controls.Add(this.pb_f);
            this.Name = "Form1";
            this.Text = "Testform für Klasse Ziffer";
            ((System.ComponentModel.ISupportInitialize)(this.pb_f)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_e)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_c)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_d)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stellenindex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_f;
        private System.Windows.Forms.PictureBox pb_e;
        private System.Windows.Forms.PictureBox pb_b;
        private System.Windows.Forms.PictureBox pb_c;
        private System.Windows.Forms.PictureBox pb_d;
        private System.Windows.Forms.PictureBox pb_a;
        private System.Windows.Forms.PictureBox pb_g;
        private System.Windows.Forms.TextBox txtb_wert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_anzeigen;
        private System.Windows.Forms.Button btn_wuerfeln_1;
        private System.Windows.Forms.NumericUpDown nud_stellenindex;
        private System.Windows.Forms.Button btn_wuerfeln_2;
    }
}

