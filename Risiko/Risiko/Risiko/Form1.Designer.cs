namespace Risiko
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bonusPlayer1 = new System.Windows.Forms.Label();
            this.BonusPlayer2 = new System.Windows.Forms.Label();
            this.bonusPlayer3 = new System.Windows.Forms.Label();
            this.CambiaFase = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(828, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giocatore 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(828, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giocatore 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(827, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giocatore 3";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(807, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 20);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Location = new System.Drawing.Point(807, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 20);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(807, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 20);
            this.panel3.TabIndex = 5;
            // 
            // bonusPlayer1
            // 
            this.bonusPlayer1.AutoSize = true;
            this.bonusPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonusPlayer1.Location = new System.Drawing.Point(925, 15);
            this.bonusPlayer1.Name = "bonusPlayer1";
            this.bonusPlayer1.Size = new System.Drawing.Size(106, 20);
            this.bonusPlayer1.TabIndex = 6;
            this.bonusPlayer1.Text = "Bonus carri: 0";
            // 
            // BonusPlayer2
            // 
            this.BonusPlayer2.AutoSize = true;
            this.BonusPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BonusPlayer2.Location = new System.Drawing.Point(925, 37);
            this.BonusPlayer2.Name = "BonusPlayer2";
            this.BonusPlayer2.Size = new System.Drawing.Size(106, 20);
            this.BonusPlayer2.TabIndex = 7;
            this.BonusPlayer2.Text = "Bonus carri: 0";
            // 
            // bonusPlayer3
            // 
            this.bonusPlayer3.AutoSize = true;
            this.bonusPlayer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonusPlayer3.Location = new System.Drawing.Point(925, 60);
            this.bonusPlayer3.Name = "bonusPlayer3";
            this.bonusPlayer3.Size = new System.Drawing.Size(106, 20);
            this.bonusPlayer3.TabIndex = 8;
            this.bonusPlayer3.Text = "Bonus carri: 0";
            // 
            // CambiaFase
            // 
            this.CambiaFase.Location = new System.Drawing.Point(834, 555);
            this.CambiaFase.Name = "CambiaFase";
            this.CambiaFase.Size = new System.Drawing.Size(79, 29);
            this.CambiaFase.TabIndex = 9;
            this.CambiaFase.Text = "Cambia fase";
            this.CambiaFase.UseVisualStyleBackColor = true;
            this.CambiaFase.Click += new System.EventHandler(this.CambiaFase_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(919, 555);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(79, 29);
            this.Reset.TabIndex = 10;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 636);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.CambiaFase);
            this.Controls.Add(this.bonusPlayer3);
            this.Controls.Add(this.BonusPlayer2);
            this.Controls.Add(this.bonusPlayer1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label bonusPlayer1;
        private System.Windows.Forms.Label BonusPlayer2;
        private System.Windows.Forms.Label bonusPlayer3;
        private System.Windows.Forms.Button CambiaFase;
        private System.Windows.Forms.Button Reset;
    }
}

