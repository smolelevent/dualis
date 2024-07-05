namespace RetoxikaloKL
{
    partial class ItalLapForm
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
            this.pnlValasztek = new System.Windows.Forms.Panel();
            this.btnRendel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItallapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.galériaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sugóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.névjegyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlValasztek
            // 
            this.pnlValasztek.AutoScroll = true;
            this.pnlValasztek.Location = new System.Drawing.Point(39, 12);
            this.pnlValasztek.Name = "pnlValasztek";
            this.pnlValasztek.Size = new System.Drawing.Size(714, 397);
            this.pnlValasztek.TabIndex = 0;
            // 
            // btnRendel
            // 
            this.btnRendel.Location = new System.Drawing.Point(356, 415);
            this.btnRendel.Name = "btnRendel";
            this.btnRendel.Size = new System.Drawing.Size(75, 23);
            this.btnRendel.TabIndex = 0;
            this.btnRendel.Text = "Rendel";
            this.btnRendel.UseVisualStyleBackColor = true;
            this.btnRendel.Click += new System.EventHandler(this.btnRendel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem,
            this.ItallapMenuItem,
            this.galériaToolStripMenuItem,
            this.sugóToolStripMenuItem,
            this.névjegyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.SaveMenuItem,
            this.kilépésToolStripMenuItem});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(129, 22);
            this.openMenuItem.Text = "Megnyitás";
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Enabled = false;
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.Size = new System.Drawing.Size(129, 22);
            this.SaveMenuItem.Text = "Mentés";
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            // 
            // ItallapMenuItem
            // 
            this.ItallapMenuItem.Enabled = false;
            this.ItallapMenuItem.Name = "ItallapMenuItem";
            this.ItallapMenuItem.Size = new System.Drawing.Size(51, 20);
            this.ItallapMenuItem.Text = "Itallap";
            // 
            // galériaToolStripMenuItem
            // 
            this.galériaToolStripMenuItem.Name = "galériaToolStripMenuItem";
            this.galériaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.galériaToolStripMenuItem.Text = "Galéria";
            // 
            // sugóToolStripMenuItem
            // 
            this.sugóToolStripMenuItem.Name = "sugóToolStripMenuItem";
            this.sugóToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.sugóToolStripMenuItem.Text = "Sugó";
            // 
            // névjegyToolStripMenuItem
            // 
            this.névjegyToolStripMenuItem.Name = "névjegyToolStripMenuItem";
            this.névjegyToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.névjegyToolStripMenuItem.Text = "Névjegy";
            // 
            // ItalLapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRendel);
            this.Controls.Add(this.pnlValasztek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ItalLapForm";
            this.Text = "ItalLap";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlValasztek;
        private System.Windows.Forms.Button btnRendel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ItallapMenuItem;
        private System.Windows.Forms.ToolStripMenuItem galériaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sugóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem névjegyToolStripMenuItem;
    }
}