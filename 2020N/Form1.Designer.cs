
namespace _2020N
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
            this.btn_test_pc_instanzieren = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_fehler_melden = new System.Windows.Forms.Button();
            this.txtb_fehlermeldung = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb_fehlerliste = new System.Windows.Forms.TextBox();
            this.btn_fehler_beseitigt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtb_listenindex = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_test_pc_instanzieren
            // 
            this.btn_test_pc_instanzieren.Location = new System.Drawing.Point(46, 40);
            this.btn_test_pc_instanzieren.Name = "btn_test_pc_instanzieren";
            this.btn_test_pc_instanzieren.Size = new System.Drawing.Size(411, 44);
            this.btn_test_pc_instanzieren.TabIndex = 0;
            this.btn_test_pc_instanzieren.Text = "Test_PC instanzieren";
            this.btn_test_pc_instanzieren.UseVisualStyleBackColor = true;
            this.btn_test_pc_instanzieren.Click += new System.EventHandler(this.btn_test_pc_instanzieren_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reperatur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fehler beschreiben";
            // 
            // btn_fehler_melden
            // 
            this.btn_fehler_melden.Location = new System.Drawing.Point(46, 289);
            this.btn_fehler_melden.Name = "btn_fehler_melden";
            this.btn_fehler_melden.Size = new System.Drawing.Size(411, 50);
            this.btn_fehler_melden.TabIndex = 3;
            this.btn_fehler_melden.Text = "Fehler melden";
            this.btn_fehler_melden.UseVisualStyleBackColor = true;
            this.btn_fehler_melden.Click += new System.EventHandler(this.btn_fehler_melden_Click);
            // 
            // txtb_fehlermeldung
            // 
            this.txtb_fehlermeldung.Location = new System.Drawing.Point(46, 235);
            this.txtb_fehlermeldung.Name = "txtb_fehlermeldung";
            this.txtb_fehlermeldung.Size = new System.Drawing.Size(411, 23);
            this.txtb_fehlermeldung.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fehlerliste";
            // 
            // txtb_fehlerliste
            // 
            this.txtb_fehlerliste.AcceptsReturn = true;
            this.txtb_fehlerliste.Location = new System.Drawing.Point(46, 431);
            this.txtb_fehlerliste.Multiline = true;
            this.txtb_fehlerliste.Name = "txtb_fehlerliste";
            this.txtb_fehlerliste.Size = new System.Drawing.Size(411, 109);
            this.txtb_fehlerliste.TabIndex = 6;
            // 
            // btn_fehler_beseitigt
            // 
            this.btn_fehler_beseitigt.Location = new System.Drawing.Point(46, 567);
            this.btn_fehler_beseitigt.Name = "btn_fehler_beseitigt";
            this.btn_fehler_beseitigt.Size = new System.Drawing.Size(127, 50);
            this.btn_fehler_beseitigt.TabIndex = 7;
            this.btn_fehler_beseitigt.Text = "Fehler beseitigen";
            this.btn_fehler_beseitigt.UseVisualStyleBackColor = true;
            this.btn_fehler_beseitigt.Click += new System.EventHandler(this.btn_fehler_beseitigt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 585);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Listenindex";
            // 
            // txtb_listenindex
            // 
            this.txtb_listenindex.Location = new System.Drawing.Point(357, 577);
            this.txtb_listenindex.Name = "txtb_listenindex";
            this.txtb_listenindex.Size = new System.Drawing.Size(100, 23);
            this.txtb_listenindex.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 668);
            this.Controls.Add(this.txtb_listenindex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_fehler_beseitigt);
            this.Controls.Add(this.txtb_fehlerliste);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtb_fehlermeldung);
            this.Controls.Add(this.btn_fehler_melden);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_test_pc_instanzieren);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_test_pc_instanzieren;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_fehler_melden;
        private System.Windows.Forms.TextBox txtb_fehlermeldung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb_fehlerliste;
        private System.Windows.Forms.Button btn_fehler_beseitigt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtb_listenindex;
    }
}

