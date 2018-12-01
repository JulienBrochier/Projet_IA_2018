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
            this.BtnPartie2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.SystemColors.Window;
            this.score.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.score.Location = new System.Drawing.Point(208, 123);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(63, 20);
            this.score.TabIndex = 3;
            this.score.Text = "SCORE :";
            this.score.Click += new System.EventHandler(this.Titre_Click);
            // 
            // Texte1
            // 
            this.Texte1.AutoSize = true;
            this.Texte1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Texte1.Location = new System.Drawing.Point(147, 51);
            this.Texte1.Name = "Texte1";
            this.Texte1.Size = new System.Drawing.Size(302, 20);
            this.Texte1.TabIndex = 6;
            this.Texte1.Text = "Le questionnaire est terminé! Voici vos résultats :";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(310, 123);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(52, 17);
            this.Total.TabIndex = 7;
            this.Total.Text = "points";
            this.Total.Click += new System.EventHandler(this.Total_Click);
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BtnQuitter.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuitter.ForeColor = System.Drawing.Color.LightCoral;
            this.BtnQuitter.Location = new System.Drawing.Point(518, 12);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(62, 26);
            this.BtnQuitter.TabIndex = 8;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = false;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // BtnPartie2
            // 
            this.BtnPartie2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnPartie2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPartie2.ForeColor = System.Drawing.Color.Black;
            this.BtnPartie2.Location = new System.Drawing.Point(247, 214);
            this.BtnPartie2.Name = "BtnPartie2";
            this.BtnPartie2.Size = new System.Drawing.Size(115, 25);
            this.BtnPartie2.TabIndex = 9;
            this.BtnPartie2.Text = "Cliquez-ici!";
            this.BtnPartie2.UseVisualStyleBackColor = false;
            this.BtnPartie2.Click += new System.EventHandler(this.BtnPartie2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pour obtenir votre note sur 20, résolvez un dernier problème!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Resultats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 273);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPartie2);
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
        private System.Windows.Forms.Button BtnPartie2;
        private System.Windows.Forms.Label label1;
    }
}