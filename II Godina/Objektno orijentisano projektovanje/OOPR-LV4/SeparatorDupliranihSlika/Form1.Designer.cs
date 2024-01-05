namespace SeparatorDupliranihSlika
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
            this.tbPrviFolder = new System.Windows.Forms.TextBox();
            this.tbDrugiFolder = new System.Windows.Forms.TextBox();
            this.btnUnos = new System.Windows.Forms.Button();
            this.lblObavestenje = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.tbDest = new System.Windows.Forms.TextBox();
            this.ckbUnikati = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbPrviFolder
            // 
            this.tbPrviFolder.Location = new System.Drawing.Point(44, 42);
            this.tbPrviFolder.Name = "tbPrviFolder";
            this.tbPrviFolder.Size = new System.Drawing.Size(391, 22);
            this.tbPrviFolder.TabIndex = 0;
            // 
            // tbDrugiFolder
            // 
            this.tbDrugiFolder.Location = new System.Drawing.Point(44, 85);
            this.tbDrugiFolder.Name = "tbDrugiFolder";
            this.tbDrugiFolder.Size = new System.Drawing.Size(391, 22);
            this.tbDrugiFolder.TabIndex = 1;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(44, 135);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(74, 47);
            this.btnUnos.TabIndex = 2;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // lblObavestenje
            // 
            this.lblObavestenje.AutoSize = true;
            this.lblObavestenje.Location = new System.Drawing.Point(158, 135);
            this.lblObavestenje.Name = "lblObavestenje";
            this.lblObavestenje.Size = new System.Drawing.Size(119, 16);
            this.lblObavestenje.TabIndex = 3;
            this.lblObavestenje.Text = "Operacija izvrsena";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(158, 162);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(0, 16);
            this.lblPath.TabIndex = 4;
            // 
            // tbDest
            // 
            this.tbDest.Location = new System.Drawing.Point(44, 189);
            this.tbDest.Name = "tbDest";
            this.tbDest.Size = new System.Drawing.Size(391, 22);
            this.tbDest.TabIndex = 5;
            // 
            // ckbUnikati
            // 
            this.ckbUnikati.AutoSize = true;
            this.ckbUnikati.Location = new System.Drawing.Point(450, 191);
            this.ckbUnikati.Name = "ckbUnikati";
            this.ckbUnikati.Size = new System.Drawing.Size(109, 20);
            this.ckbUnikati.TabIndex = 6;
            this.ckbUnikati.Text = "Samo Unikati";
            this.ckbUnikati.UseVisualStyleBackColor = true;
            this.ckbUnikati.CheckedChanged += new System.EventHandler(this.ckbUnikati_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 243);
            this.Controls.Add(this.ckbUnikati);
            this.Controls.Add(this.tbDest);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblObavestenje);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.tbDrugiFolder);
            this.Controls.Add(this.tbPrviFolder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPrviFolder;
        private System.Windows.Forms.TextBox tbDrugiFolder;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Label lblObavestenje;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox tbDest;
        private System.Windows.Forms.CheckBox ckbUnikati;
    }
}

