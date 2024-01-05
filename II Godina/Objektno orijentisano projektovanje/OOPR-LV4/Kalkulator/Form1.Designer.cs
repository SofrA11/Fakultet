namespace Kalkulator
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
            this.tb1 = new System.Windows.Forms.TextBox();
            this.Racunaj = new System.Windows.Forms.Button();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mODToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbRezultat = new System.Windows.Forms.ListBox();
            this.lblMod = new System.Windows.Forms.Label();
            this.ckbCeliBrojevi = new System.Windows.Forms.CheckBox();
            this.decBinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(12, 49);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(126, 22);
            this.tb1.TabIndex = 0;
            // 
            // Racunaj
            // 
            this.Racunaj.Location = new System.Drawing.Point(12, 88);
            this.Racunaj.Name = "Racunaj";
            this.Racunaj.Size = new System.Drawing.Size(69, 48);
            this.Racunaj.TabIndex = 2;
            this.Racunaj.UseVisualStyleBackColor = true;
            this.Racunaj.Click += new System.EventHandler(this.Racunaj_Click);
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(188, 49);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(126, 22);
            this.tb2.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(559, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mODToolStripMenuItem1,
            this.decBinToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(87, 24);
            this.toolStripMenuItem1.Text = "Operacija";
            // 
            // mODToolStripMenuItem1
            // 
            this.mODToolStripMenuItem1.Name = "mODToolStripMenuItem1";
            this.mODToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.mODToolStripMenuItem1.Text = "MOD";
            this.mODToolStripMenuItem1.Click += new System.EventHandler(this.mODToolStripMenuItem1_Click);
            // 
            // lbRezultat
            // 
            this.lbRezultat.FormattingEnabled = true;
            this.lbRezultat.ItemHeight = 16;
            this.lbRezultat.Location = new System.Drawing.Point(108, 88);
            this.lbRezultat.Name = "lbRezultat";
            this.lbRezultat.Size = new System.Drawing.Size(206, 100);
            this.lbRezultat.TabIndex = 5;
            // 
            // lblMod
            // 
            this.lblMod.AutoSize = true;
            this.lblMod.Location = new System.Drawing.Point(144, 52);
            this.lblMod.Name = "lblMod";
            this.lblMod.Size = new System.Drawing.Size(38, 16);
            this.lblMod.TabIndex = 6;
            this.lblMod.Text = "MOD";
            // 
            // ckbCeliBrojevi
            // 
            this.ckbCeliBrojevi.AutoSize = true;
            this.ckbCeliBrojevi.Location = new System.Drawing.Point(12, 152);
            this.ckbCeliBrojevi.Name = "ckbCeliBrojevi";
            this.ckbCeliBrojevi.Size = new System.Drawing.Size(96, 20);
            this.ckbCeliBrojevi.TabIndex = 7;
            this.ckbCeliBrojevi.Text = "Celi brojevi";
            this.ckbCeliBrojevi.UseVisualStyleBackColor = true;
            // 
            // decBinToolStripMenuItem
            // 
            this.decBinToolStripMenuItem.Name = "decBinToolStripMenuItem";
            this.decBinToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.decBinToolStripMenuItem.Text = "Dec -> Bin";
            this.decBinToolStripMenuItem.Click += new System.EventHandler(this.decBinToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 311);
            this.Controls.Add(this.ckbCeliBrojevi);
            this.Controls.Add(this.lblMod);
            this.Controls.Add(this.lbRezultat);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.Racunaj);
            this.Controls.Add(this.tb1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Button Racunaj;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mODToolStripMenuItem1;
        private System.Windows.Forms.ListBox lbRezultat;
        private System.Windows.Forms.Label lblMod;
        private System.Windows.Forms.CheckBox ckbCeliBrojevi;
        private System.Windows.Forms.ToolStripMenuItem decBinToolStripMenuItem;
    }
}

