namespace Minesweeper
{
    partial class NaprednaPodesavanja
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
            this.nudVrsta = new System.Windows.Forms.NumericUpDown();
            this.nudKolona = new System.Windows.Forms.NumericUpDown();
            this.nudMina = new System.Windows.Forms.NumericUpDown();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnPonisti = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudVrsta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMina)).BeginInit();
            this.SuspendLayout();
            // 
            // nudVrsta
            // 
            this.nudVrsta.Location = new System.Drawing.Point(14, 33);
            this.nudVrsta.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudVrsta.Name = "nudVrsta";
            this.nudVrsta.Size = new System.Drawing.Size(88, 22);
            this.nudVrsta.TabIndex = 0;
            this.nudVrsta.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudVrsta.ValueChanged += new System.EventHandler(this.nudVrsta_ValueChanged);
            // 
            // nudKolona
            // 
            this.nudKolona.Location = new System.Drawing.Point(131, 33);
            this.nudKolona.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudKolona.Name = "nudKolona";
            this.nudKolona.Size = new System.Drawing.Size(87, 22);
            this.nudKolona.TabIndex = 1;
            this.nudKolona.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // nudMina
            // 
            this.nudMina.Location = new System.Drawing.Point(276, 33);
            this.nudMina.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMina.Name = "nudMina";
            this.nudMina.Size = new System.Drawing.Size(87, 22);
            this.nudMina.TabIndex = 2;
            this.nudMina.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMina.ValueChanged += new System.EventHandler(this.nudMina_ValueChanged);
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(95, 85);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(83, 29);
            this.btnUnesi.TabIndex = 3;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnPonisti
            // 
            this.btnPonisti.Location = new System.Drawing.Point(234, 85);
            this.btnPonisti.Name = "btnPonisti";
            this.btnPonisti.Size = new System.Drawing.Size(83, 29);
            this.btnPonisti.TabIndex = 4;
            this.btnPonisti.Text = "Ponisti";
            this.btnPonisti.UseVisualStyleBackColor = true;
            this.btnPonisti.Click += new System.EventHandler(this.btnPonisti_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Broj vrsta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Broj kolona:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Broj mina:";
            // 
            // NaprednaPodesavanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 126);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPonisti);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.nudMina);
            this.Controls.Add(this.nudKolona);
            this.Controls.Add(this.nudVrsta);
            this.Name = "NaprednaPodesavanja";
            this.Text = "NaprednaPodesavanja";
            this.Load += new System.EventHandler(this.NaprednaPodesavanja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudVrsta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudVrsta;
        private System.Windows.Forms.NumericUpDown nudKolona;
        private System.Windows.Forms.NumericUpDown nudMina;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnPonisti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}