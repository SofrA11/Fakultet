namespace Kalkulator
{
    partial class DTB
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
            this.tb2 = new System.Windows.Forms.TextBox();
            this.btnKonvertuj = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.cmb2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Russo One", 10.2F);
            this.tb1.Location = new System.Drawing.Point(22, 26);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(354, 28);
            this.tb1.TabIndex = 0;
            this.tb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb1_KeyPress);
            // 
            // tb2
            // 
            this.tb2.Font = new System.Drawing.Font("Russo One", 10.2F);
            this.tb2.Location = new System.Drawing.Point(22, 74);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(354, 28);
            this.tb2.TabIndex = 1;
            // 
            // btnKonvertuj
            // 
            this.btnKonvertuj.Location = new System.Drawing.Point(22, 110);
            this.btnKonvertuj.Name = "btnKonvertuj";
            this.btnKonvertuj.Size = new System.Drawing.Size(136, 38);
            this.btnKonvertuj.TabIndex = 2;
            this.btnKonvertuj.Text = "button1";
            this.btnKonvertuj.UseVisualStyleBackColor = true;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(19, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(10, 16);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = ".";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(19, 55);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(10, 16);
            this.lbl2.TabIndex = 6;
            this.lbl2.Text = ".";
            // 
            // cmb1
            // 
            this.cmb1.Font = new System.Drawing.Font("Russo One", 10.2F);
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Items.AddRange(new object[] {
            "Dekadni",
            "Binarni",
            "Heksadekadni",
            "Oktalni"});
            this.cmb1.Location = new System.Drawing.Point(394, 26);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(190, 29);
            this.cmb1.TabIndex = 7;
            this.cmb1.SelectedValueChanged += new System.EventHandler(this.cmb1_SelectedValueChanged);
            // 
            // cmb2
            // 
            this.cmb2.Font = new System.Drawing.Font("Russo One", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb2.FormattingEnabled = true;
            this.cmb2.Items.AddRange(new object[] {
            "Dekadni",
            "Binarni",
            "Heksadekadni",
            "Oktalni"});
            this.cmb2.Location = new System.Drawing.Point(394, 74);
            this.cmb2.Name = "cmb2";
            this.cmb2.Size = new System.Drawing.Size(190, 29);
            this.cmb2.TabIndex = 8;
            this.cmb2.SelectedIndexChanged += new System.EventHandler(this.cmb2_SelectedIndexChanged);
            // 
            // DTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 166);
            this.Controls.Add(this.cmb2);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnKonvertuj);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Name = "DTB";
            this.Text = "DTB";
            this.Load += new System.EventHandler(this.DTB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Button btnKonvertuj;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.ComboBox cmb2;
    }
}