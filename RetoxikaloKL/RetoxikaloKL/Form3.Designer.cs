namespace RetoxikaloKL
{
    partial class SzamlaForm
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
            this.rchTxtSzamla = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rchTxtSzamla
            // 
            this.rchTxtSzamla.Location = new System.Drawing.Point(91, 12);
            this.rchTxtSzamla.Name = "rchTxtSzamla";
            this.rchTxtSzamla.ReadOnly = true;
            this.rchTxtSzamla.Size = new System.Drawing.Size(610, 309);
            this.rchTxtSzamla.TabIndex = 0;
            this.rchTxtSzamla.Text = "";
            // 
            // SzamlaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rchTxtSzamla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SzamlaForm";
            this.Text = "Számla";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTxtSzamla;
    }
}