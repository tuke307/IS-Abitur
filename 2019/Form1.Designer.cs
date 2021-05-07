
namespace _2019
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
            this.btn_instanzieren = new System.Windows.Forms.Button();
            this.txtb_instanzieren = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtb_ort = new System.Windows.Forms.TextBox();
            this.txtb_plz = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_instanzieren
            // 
            this.btn_instanzieren.Location = new System.Drawing.Point(63, 180);
            this.btn_instanzieren.Name = "btn_instanzieren";
            this.btn_instanzieren.Size = new System.Drawing.Size(100, 23);
            this.btn_instanzieren.TabIndex = 1;
            this.btn_instanzieren.Text = "instanzieren";
            this.btn_instanzieren.UseVisualStyleBackColor = true;
            this.btn_instanzieren.Click += new System.EventHandler(this.btn_instanzieren_Click);
            // 
            // txtb_instanzieren
            // 
            this.txtb_instanzieren.Location = new System.Drawing.Point(195, 180);
            this.txtb_instanzieren.Name = "txtb_instanzieren";
            this.txtb_instanzieren.Size = new System.Drawing.Size(491, 23);
            this.txtb_instanzieren.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "gast eintragen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(512, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "ort eintragen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtb_ort
            // 
            this.txtb_ort.Location = new System.Drawing.Point(472, 367);
            this.txtb_ort.Name = "txtb_ort";
            this.txtb_ort.Size = new System.Drawing.Size(214, 23);
            this.txtb_ort.TabIndex = 5;
            this.txtb_ort.Text = "ort";
            // 
            // txtb_plz
            // 
            this.txtb_plz.Location = new System.Drawing.Point(472, 338);
            this.txtb_plz.Name = "txtb_plz";
            this.txtb_plz.Size = new System.Drawing.Size(214, 23);
            this.txtb_plz.TabIndex = 6;
            this.txtb_plz.Text = "plz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtb_plz);
            this.Controls.Add(this.txtb_ort);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtb_instanzieren);
            this.Controls.Add(this.btn_instanzieren);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_instanzieren;
        private System.Windows.Forms.TextBox txtb_instanzieren;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtb_ort;
        private System.Windows.Forms.TextBox txtb_plz;
    }
}

