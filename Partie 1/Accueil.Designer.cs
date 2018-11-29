namespace Partie_1
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BoutonCommencer = new System.Windows.Forms.Button();
            this.Module = new System.Windows.Forms.Label();
            this.Titre = new System.Windows.Forms.Label();
            this.Intro2 = new System.Windows.Forms.Label();
            this.Intro3 = new System.Windows.Forms.Label();
            this.Intro1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BoutonCommencer
            // 
            this.BoutonCommencer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BoutonCommencer.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoutonCommencer.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BoutonCommencer.Location = new System.Drawing.Point(349, 212);
            this.BoutonCommencer.Name = "BoutonCommencer";
            this.BoutonCommencer.Size = new System.Drawing.Size(95, 31);
            this.BoutonCommencer.TabIndex = 0;
            this.BoutonCommencer.Text = "Commencer";
            this.BoutonCommencer.UseVisualStyleBackColor = false;
            this.BoutonCommencer.Click += new System.EventHandler(this.BoutonCommencer_Click);
            // 
            // Module
            // 
            this.Module.AutoSize = true;
            this.Module.Font = new System.Drawing.Font("Poiret One", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Module.Location = new System.Drawing.Point(44, 36);
            this.Module.Name = "Module";
            this.Module.Size = new System.Drawing.Size(148, 13);
            this.Module.TabIndex = 1;
            this.Module.Text = "Module Intelligence Artificielle";
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.BackColor = System.Drawing.SystemColors.Window;
            this.Titre.Font = new System.Drawing.Font("Lobster", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Titre.Location = new System.Drawing.Point(312, 75);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(180, 15);
            this.Titre.TabIndex = 2;
            this.Titre.Text = "Questionnaire Intelligence Articifielle";
            this.Titre.Click += new System.EventHandler(this.Titre_Click);
            // 
            // Intro2
            // 
            this.Intro2.AutoSize = true;
            this.Intro2.Location = new System.Drawing.Point(192, 137);
            this.Intro2.Name = "Intro2";
            this.Intro2.Size = new System.Drawing.Size(427, 13);
            this.Intro2.TabIndex = 3;
            this.Intro2.Text = "Vous aurez accès à votre score global lorsque vous aurez répondu à toutes les que" +
    "stions";
            // 
            // Intro3
            // 
            this.Intro3.AutoSize = true;
            this.Intro3.Location = new System.Drawing.Point(280, 181);
            this.Intro3.Name = "Intro3";
            this.Intro3.Size = new System.Drawing.Size(248, 13);
            this.Intro3.TabIndex = 4;
            this.Intro3.Text = "Si vous vous sentez prêt, vous pouvez commencer";
            // 
            // Intro1
            // 
            this.Intro1.AutoSize = true;
            this.Intro1.Location = new System.Drawing.Point(182, 124);
            this.Intro1.Name = "Intro1";
            this.Intro1.Size = new System.Drawing.Size(447, 13);
            this.Intro1.TabIndex = 5;
            this.Intro1.Text = "Bienvenue sur notre questionnaire! Une série de 20 questions de formes diverses v" +
    "ous attend";
            this.Intro1.Click += new System.EventHandler(this.Intro1_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 300);
            this.Controls.Add(this.Intro1);
            this.Controls.Add(this.Intro3);
            this.Controls.Add(this.Intro2);
            this.Controls.Add(this.Titre);
            this.Controls.Add(this.Module);
            this.Controls.Add(this.BoutonCommencer);
            this.Name = "Accueil";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BoutonCommencer;
        private System.Windows.Forms.Label Module;
        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.Label Intro2;
        private System.Windows.Forms.Label Intro3;
        private System.Windows.Forms.Label Intro1;
    }
}

