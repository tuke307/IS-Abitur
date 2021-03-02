
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
            this.dg_termine = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.txtb_terminanfrage = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_termine)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_termine
            // 
            this.dg_termine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_termine.Location = new System.Drawing.Point(34, 39);
            this.dg_termine.Name = "dg_termine";
            this.dg_termine.RowHeadersWidth = 82;
            this.dg_termine.RowTemplate.Height = 33;
            this.dg_termine.Size = new System.Drawing.Size(692, 558);
            this.dg_termine.TabIndex = 0;
            this.dg_termine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_termine_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(873, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 89);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtb_terminanfrage
            // 
            this.txtb_terminanfrage.Location = new System.Drawing.Point(34, 654);
            this.txtb_terminanfrage.Name = "txtb_terminanfrage";
            this.txtb_terminanfrage.Size = new System.Drawing.Size(692, 31);
            this.txtb_terminanfrage.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(843, 616);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 80);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 778);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtb_terminanfrage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dg_termine);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dg_termine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_termine;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtb_terminanfrage;
        private System.Windows.Forms.Button button2;
    }
}

