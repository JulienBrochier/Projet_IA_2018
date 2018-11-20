namespace Partie_1
{
    partial class Resultats
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
            this.score = new System.Windows.Forms.Label();
            this.Texte1 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.SystemColors.Window;
            this.score.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.score.Location = new System.Drawing.Point(208, 123);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(85, 16);
            this.score.TabIndex = 3;
            this.score.Text = "SCORE :";
            this.score.Click += new System.EventHandler(this.Titre_Click);
            // 
            // Texte1
            // 
            this.Texte1.AutoSize = true;
            this.Texte1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texte1.Location = new System.Drawing.Point(125, 50);
            this.Texte1.Name = "Texte1";
            this.Texte1.Size = new System.Drawing.Size(353, 20);
            this.Texte1.TabIndex = 6;
            this.Texte1.Text = "Le questionnaire est terminé! Voici vos résultats :";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(310, 123);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(35, 13);
            this.Total.TabIndex = 7;
            this.Total.Text = "points";
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnQuitter.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuitter.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnQuitter.Location = new System.Drawing.Point(464, 208);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(95, 31);
            this.BtnQuitter.TabIndex = 8;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = false;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // Resultats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 273);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Texte1);
            this.Controls.Add(this.score);
            this.Name = "Resultats";
            this.Text = "Resultats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label Texte1;
        private System.Windows.Forms.Button BtnQuitter;
        internal System.Windows.Forms.Label Total;
    }
}