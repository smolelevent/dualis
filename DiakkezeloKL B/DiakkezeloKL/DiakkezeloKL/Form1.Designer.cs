namespace DiakkezeloKL
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAdatbevitel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstEredmenyek = new System.Windows.Forms.ListBox();
            this.lblDiak = new System.Windows.Forms.Label();
            this.lstDiakok = new System.Windows.Forms.ListBox();
            this.pnlEvek = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAdatbevitel
            // 
            this.btnAdatbevitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdatbevitel.Location = new System.Drawing.Point(141, 363);
            this.btnAdatbevitel.Name = "btnAdatbevitel";
            this.btnAdatbevitel.Size = new System.Drawing.Size(100, 40);
            this.btnAdatbevitel.TabIndex = 0;
            this.btnAdatbevitel.Text = "Adatbevitel";
            this.btnAdatbevitel.UseVisualStyleBackColor = true;
            this.btnAdatbevitel.Click += new System.EventHandler(this.btnAdatbevitel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(159, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Diákok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(534, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Születési évek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(407, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "A keresés eredménye:";
            // 
            // lstEredmenyek
            // 
            this.lstEredmenyek.FormattingEnabled = true;
            this.lstEredmenyek.Location = new System.Drawing.Point(411, 194);
            this.lstEredmenyek.Name = "lstEredmenyek";
            this.lstEredmenyek.Size = new System.Drawing.Size(347, 147);
            this.lstEredmenyek.TabIndex = 7;
            // 
            // lblDiak
            // 
            this.lblDiak.AutoSize = true;
            this.lblDiak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDiak.Location = new System.Drawing.Point(442, 373);
            this.lblDiak.Name = "lblDiak";
            this.lblDiak.Size = new System.Drawing.Size(0, 20);
            this.lblDiak.TabIndex = 8;
            // 
            // lstDiakok
            // 
            this.lstDiakok.FormattingEnabled = true;
            this.lstDiakok.Location = new System.Drawing.Point(54, 64);
            this.lstDiakok.Name = "lstDiakok";
            this.lstDiakok.Size = new System.Drawing.Size(285, 277);
            this.lstDiakok.TabIndex = 0;
            // 
            // pnlEvek
            // 
            this.pnlEvek.Location = new System.Drawing.Point(411, 64);
            this.pnlEvek.Name = "pnlEvek";
            this.pnlEvek.Size = new System.Drawing.Size(347, 49);
            this.pnlEvek.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlEvek);
            this.Controls.Add(this.lstDiakok);
            this.Controls.Add(this.lblDiak);
            this.Controls.Add(this.lstEredmenyek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdatbevitel);
            this.Name = "Form1";
            this.Text = "Diákok adatai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAdatbevitel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstEredmenyek;
        private System.Windows.Forms.Label lblDiak;
        private System.Windows.Forms.ListBox lstDiakok;
        private System.Windows.Forms.Panel pnlEvek;
    }
}

