﻿namespace Formulaire
{
    partial class Form1
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
            this.TreeViewRecherche = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Bresolve = new System.Windows.Forms.Button();
            this.TBnoeudFin = new System.Windows.Forms.TextBox();
            this.TBnoeudIni = new System.Windows.Forms.TextBox();
            this.Binit = new System.Windows.Forms.Button();
            this.TBF0 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBF1 = new System.Windows.Forms.TextBox();
            this.TBF2 = new System.Windows.Forms.TextBox();
            this.TBF3 = new System.Windows.Forms.TextBox();
            this.TBO0 = new System.Windows.Forms.TextBox();
            this.TBO1 = new System.Windows.Forms.TextBox();
            this.TBO2 = new System.Windows.Forms.TextBox();
            this.TBO3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBF5 = new System.Windows.Forms.TextBox();
            this.TBO4 = new System.Windows.Forms.TextBox();
            this.TBO5 = new System.Windows.Forms.TextBox();
            this.TBO6 = new System.Windows.Forms.TextBox();
            this.TBF6 = new System.Windows.Forms.TextBox();
            this.TBF4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Lcommentaire = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TreeViewRecherche
            // 
            this.TreeViewRecherche.Location = new System.Drawing.Point(771, 175);
            this.TreeViewRecherche.Name = "TreeViewRecherche";
            this.TreeViewRecherche.Size = new System.Drawing.Size(196, 225);
            this.TreeViewRecherche.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Noeud final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Noeud initial";
            // 
            // Bresolve
            // 
            this.Bresolve.Location = new System.Drawing.Point(44, 68);
            this.Bresolve.Name = "Bresolve";
            this.Bresolve.Size = new System.Drawing.Size(114, 23);
            this.Bresolve.TabIndex = 13;
            this.Bresolve.Text = "Lancer la résolution";
            this.Bresolve.UseVisualStyleBackColor = true;
            this.Bresolve.Click += new System.EventHandler(this.Bresolve_Click);
            // 
            // TBnoeudFin
            // 
            this.TBnoeudFin.Location = new System.Drawing.Point(358, 68);
            this.TBnoeudFin.Name = "TBnoeudFin";
            this.TBnoeudFin.Size = new System.Drawing.Size(100, 20);
            this.TBnoeudFin.TabIndex = 12;
            this.TBnoeudFin.Text = "6";
            this.TBnoeudFin.TextChanged += new System.EventHandler(this.TBnoeudFin_TextChanged);
            // 
            // TBnoeudIni
            // 
            this.TBnoeudIni.Location = new System.Drawing.Point(213, 68);
            this.TBnoeudIni.Name = "TBnoeudIni";
            this.TBnoeudIni.Size = new System.Drawing.Size(100, 20);
            this.TBnoeudIni.TabIndex = 11;
            this.TBnoeudIni.Text = "0";
            this.TBnoeudIni.TextChanged += new System.EventHandler(this.TBnoeudIni_TextChanged);
            // 
            // Binit
            // 
            this.Binit.Location = new System.Drawing.Point(44, 36);
            this.Binit.Name = "Binit";
            this.Binit.Size = new System.Drawing.Size(75, 23);
            this.Binit.TabIndex = 10;
            this.Binit.Text = "Initialiser";
            this.Binit.UseVisualStyleBackColor = true;
            this.Binit.Click += new System.EventHandler(this.Binit_Click);
            // 
            // TBF0
            // 
            this.TBF0.Location = new System.Drawing.Point(422, 175);
            this.TBF0.Name = "TBF0";
            this.TBF0.Size = new System.Drawing.Size(108, 20);
            this.TBF0.TabIndex = 18;
            this.TBF0.Text = "A,B,C...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Etapes";
            // 
            // TBF1
            // 
            this.TBF1.Location = new System.Drawing.Point(422, 201);
            this.TBF1.Name = "TBF1";
            this.TBF1.Size = new System.Drawing.Size(108, 20);
            this.TBF1.TabIndex = 20;
            this.TBF1.Text = "A,B,C...";
            // 
            // TBF2
            // 
            this.TBF2.Location = new System.Drawing.Point(422, 227);
            this.TBF2.Name = "TBF2";
            this.TBF2.Size = new System.Drawing.Size(108, 20);
            this.TBF2.TabIndex = 21;
            this.TBF2.Text = "A,B,C...";
            // 
            // TBF3
            // 
            this.TBF3.Location = new System.Drawing.Point(422, 253);
            this.TBF3.Name = "TBF3";
            this.TBF3.Size = new System.Drawing.Size(108, 20);
            this.TBF3.TabIndex = 22;
            this.TBF3.Text = "A,B,C...";
            // 
            // TBO0
            // 
            this.TBO0.Location = new System.Drawing.Point(609, 175);
            this.TBO0.Name = "TBO0";
            this.TBO0.Size = new System.Drawing.Size(106, 20);
            this.TBO0.TabIndex = 23;
            // 
            // TBO1
            // 
            this.TBO1.Location = new System.Drawing.Point(609, 201);
            this.TBO1.Name = "TBO1";
            this.TBO1.Size = new System.Drawing.Size(106, 20);
            this.TBO1.TabIndex = 24;
            // 
            // TBO2
            // 
            this.TBO2.Location = new System.Drawing.Point(609, 227);
            this.TBO2.Name = "TBO2";
            this.TBO2.Size = new System.Drawing.Size(106, 20);
            this.TBO2.TabIndex = 25;
            // 
            // TBO3
            // 
            this.TBO3.Location = new System.Drawing.Point(609, 253);
            this.TBO3.Name = "TBO3";
            this.TBO3.Size = new System.Drawing.Size(106, 20);
            this.TBO3.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Graphique";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TBF5
            // 
            this.TBF5.Location = new System.Drawing.Point(422, 305);
            this.TBF5.Name = "TBF5";
            this.TBF5.Size = new System.Drawing.Size(108, 20);
            this.TBF5.TabIndex = 29;
            this.TBF5.Text = "A,B,C...";
            // 
            // TBO4
            // 
            this.TBO4.Location = new System.Drawing.Point(609, 279);
            this.TBO4.Name = "TBO4";
            this.TBO4.Size = new System.Drawing.Size(106, 20);
            this.TBO4.TabIndex = 30;
            // 
            // TBO5
            // 
            this.TBO5.Location = new System.Drawing.Point(609, 305);
            this.TBO5.Name = "TBO5";
            this.TBO5.Size = new System.Drawing.Size(106, 20);
            this.TBO5.TabIndex = 31;
            // 
            // TBO6
            // 
            this.TBO6.Location = new System.Drawing.Point(609, 331);
            this.TBO6.Name = "TBO6";
            this.TBO6.Size = new System.Drawing.Size(106, 20);
            this.TBO6.TabIndex = 32;
            // 
            // TBF6
            // 
            this.TBF6.Location = new System.Drawing.Point(422, 331);
            this.TBF6.Name = "TBF6";
            this.TBF6.Size = new System.Drawing.Size(108, 20);
            this.TBF6.TabIndex = 33;
            this.TBF6.Text = "A,B,C...";
            // 
            // TBF4
            // 
            this.TBF4.Location = new System.Drawing.Point(422, 279);
            this.TBF4.Name = "TBF4";
            this.TBF4.Size = new System.Drawing.Size(108, 20);
            this.TBF4.TabIndex = 34;
            this.TBF4.Text = "A,B,C...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "F0 {";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(779, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Résolution";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 225);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(536, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "}";
            // 
            // Lcommentaire
            // 
            this.Lcommentaire.AutoSize = true;
            this.Lcommentaire.Location = new System.Drawing.Point(465, 387);
            this.Lcommentaire.Name = "Lcommentaire";
            this.Lcommentaire.Size = new System.Drawing.Size(10, 13);
            this.Lcommentaire.TabIndex = 39;
            this.Lcommentaire.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 457);
            this.Controls.Add(this.Lcommentaire);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBF4);
            this.Controls.Add(this.TBF6);
            this.Controls.Add(this.TBO6);
            this.Controls.Add(this.TBO5);
            this.Controls.Add(this.TBO4);
            this.Controls.Add(this.TBF5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBO3);
            this.Controls.Add(this.TBO2);
            this.Controls.Add(this.TBO1);
            this.Controls.Add(this.TBO0);
            this.Controls.Add(this.TBF3);
            this.Controls.Add(this.TBF2);
            this.Controls.Add(this.TBF1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBF0);
            this.Controls.Add(this.TreeViewRecherche);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bresolve);
            this.Controls.Add(this.TBnoeudFin);
            this.Controls.Add(this.TBnoeudIni);
            this.Controls.Add(this.Binit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView TreeViewRecherche;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bresolve;
        private System.Windows.Forms.TextBox TBnoeudFin;
        private System.Windows.Forms.TextBox TBnoeudIni;
        private System.Windows.Forms.Button Binit;
        private System.Windows.Forms.TextBox TBF0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBF1;
        private System.Windows.Forms.TextBox TBF2;
        private System.Windows.Forms.TextBox TBF3;
        private System.Windows.Forms.TextBox TBO0;
        private System.Windows.Forms.TextBox TBO1;
        private System.Windows.Forms.TextBox TBO2;
        private System.Windows.Forms.TextBox TBO3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBF5;
        private System.Windows.Forms.TextBox TBO4;
        private System.Windows.Forms.TextBox TBO5;
        private System.Windows.Forms.TextBox TBO6;
        private System.Windows.Forms.TextBox TBF6;
        private System.Windows.Forms.TextBox TBF4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Lcommentaire;
    }
}

