namespace Minesweeper
{
    partial class MineSweeper
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
            this.msMeni = new System.Windows.Forms.MenuStrip();
            this.sacuvajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zavrsiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naprednoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPokreni = new System.Windows.Forms.Button();
            this.flpPodloga = new System.Windows.Forms.FlowLayoutPanel();
            this.msMeni.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMeni
            // 
            this.msMeni.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMeni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sacuvajToolStripMenuItem,
            this.zavrsiToolStripMenuItem,
            this.naprednoToolStripMenuItem});
            this.msMeni.Location = new System.Drawing.Point(0, 0);
            this.msMeni.Name = "msMeni";
            this.msMeni.Size = new System.Drawing.Size(625, 28);
            this.msMeni.TabIndex = 0;
            this.msMeni.Text = "menuStrip1";
            // 
            // sacuvajToolStripMenuItem
            // 
            this.sacuvajToolStripMenuItem.Name = "sacuvajToolStripMenuItem";
            this.sacuvajToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.sacuvajToolStripMenuItem.Text = "Sacuvaj";
            // 
            // zavrsiToolStripMenuItem
            // 
            this.zavrsiToolStripMenuItem.Name = "zavrsiToolStripMenuItem";
            this.zavrsiToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.zavrsiToolStripMenuItem.Text = "Zavrsi";
            // 
            // naprednoToolStripMenuItem
            // 
            this.naprednoToolStripMenuItem.Name = "naprednoToolStripMenuItem";
            this.naprednoToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.naprednoToolStripMenuItem.Text = "Napredno";
            this.naprednoToolStripMenuItem.Click += new System.EventHandler(this.naprednoToolStripMenuItem_Click);
            // 
            // btnPokreni
            // 
            this.btnPokreni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPokreni.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPokreni.Image = global::Minesweeper.Properties.Resources.cool_face;
            this.btnPokreni.Location = new System.Drawing.Point(163, 376);
            this.btnPokreni.Margin = new System.Windows.Forms.Padding(10);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(63, 63);
            this.btnPokreni.TabIndex = 2;
            this.btnPokreni.UseVisualStyleBackColor = true;
            this.btnPokreni.Click += new System.EventHandler(this.btnPokreni_Click_1);
            // 
            // flpPodloga
            // 
            this.flpPodloga.Location = new System.Drawing.Point(12, 31);
            this.flpPodloga.Name = "flpPodloga";
            this.flpPodloga.Size = new System.Drawing.Size(365, 332);
            this.flpPodloga.TabIndex = 3;
            this.flpPodloga.Paint += new System.Windows.Forms.PaintEventHandler(this.flpPodloga_Paint);
            // 
            // MineSweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 533);
            this.Controls.Add(this.flpPodloga);
            this.Controls.Add(this.btnPokreni);
            this.Controls.Add(this.msMeni);
            this.MainMenuStrip = this.msMeni;
            this.Name = "MineSweeper";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MineSweeper_Load);
            this.Shown += new System.EventHandler(this.MineSweeper_Shown);
            this.msMeni.ResumeLayout(false);
            this.msMeni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMeni;
        private System.Windows.Forms.ToolStripMenuItem sacuvajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zavrsiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naprednoToolStripMenuItem;
        private System.Windows.Forms.Button btnPokreni;
        private System.Windows.Forms.FlowLayoutPanel flpPodloga;
    }
}

