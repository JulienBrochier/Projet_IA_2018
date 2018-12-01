namespace Partie_1
{
    partial class Questionnaire
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
            this.NumeroQuest = new System.Windows.Forms.Label();
            this.Intitule = new System.Windows.Forms.Label();
            this.Bvalidate = new System.Windows.Forms.Button();
            this.Bcontinu = new System.Windows.Forms.Button();
            this.Lcomment = new System.Windows.Forms.Label();
            this.Rep1 = new System.Windows.Forms.CheckBox();
            this.TextComment = new System.Windows.Forms.GroupBox();
            this.TexteExplication = new System.Windows.Forms.Label();
            this.Rep2 = new System.Windows.Forms.CheckBox();
            this.Rep3 = new System.Windows.Forms.CheckBox();
            this.Rep4 = new System.Windows.Forms.CheckBox();
            this.AlerteFaux = new System.Windows.Forms.Label();
            this.BtnSortie = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.TextComment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NumeroQuest
            // 
            this.NumeroQuest.AutoSize = true;
            this.NumeroQuest.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroQuest.ForeColor = System.Drawing.Color.Teal;
            this.NumeroQuest.Location = new System.Drawing.Point(384, 9);
            this.NumeroQuest.Name = "NumeroQuest";
            this.NumeroQuest.Size = new System.Drawing.Size(96, 19);
            this.NumeroQuest.TabIndex = 0;
            this.NumeroQuest.Text = "Question n°1";
            this.NumeroQuest.Click += new System.EventHandler(this.NumeroQuest_Click);
            // 
            // Intitule
            // 
            this.Intitule.AutoSize = true;
            this.Intitule.Font = new System.Drawing.Font("Linux Biolinum G", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intitule.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Intitule.Location = new System.Drawing.Point(23, 58);
            this.Intitule.MaximumSize = new System.Drawing.Size(450, 0);
            this.Intitule.Name = "Intitule";
            this.Intitule.Size = new System.Drawing.Size(140, 15);
            this.Intitule.TabIndex = 1;
            this.Intitule.Text = "Intitulé de la question";
            // 
            // Bvalidate
            // 
            this.Bvalidate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Bvalidate.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bvalidate.Location = new System.Drawing.Point(388, 380);
            this.Bvalidate.Name = "Bvalidate";
            this.Bvalidate.Size = new System.Drawing.Size(114, 39);
            this.Bvalidate.TabIndex = 6;
            this.Bvalidate.Text = "Valider";
            this.Bvalidate.UseVisualStyleBackColor = false;
            this.Bvalidate.Click += new System.EventHandler(this.Bvalidate_Click);
            // 
            // Bcontinu
            // 
            this.Bcontinu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bcontinu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bcontinu.ForeColor = System.Drawing.Color.OliveDrab;
            this.Bcontinu.Location = new System.Drawing.Point(388, 571);
            this.Bcontinu.Name = "Bcontinu";
            this.Bcontinu.Size = new System.Drawing.Size(114, 39);
            this.Bcontinu.TabIndex = 7;
            this.Bcontinu.Text = "Continuer";
            this.Bcontinu.UseVisualStyleBackColor = false;
            this.Bcontinu.Click += new System.EventHandler(this.Bcontinu_Click);
            // 
            // Lcomment
            // 
            this.Lcomment.AutoSize = true;
            this.Lcomment.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lcomment.Location = new System.Drawing.Point(158, 428);
            this.Lcomment.Name = "Lcomment";
            this.Lcomment.Size = new System.Drawing.Size(162, 20);
            this.Lcomment.TabIndex = 8;
            this.Lcomment.Text = "Commentaire/Correction:";
            this.Lcomment.Visible = false;
            this.Lcomment.Click += new System.EventHandler(this.Lcomment_Click);
            // 
            // Rep1
            // 
            this.Rep1.AutoSize = true;
            this.Rep1.Location = new System.Drawing.Point(26, 141);
            this.Rep1.MaximumSize = new System.Drawing.Size(500, 0);
            this.Rep1.Name = "Rep1";
            this.Rep1.Size = new System.Drawing.Size(80, 17);
            this.Rep1.TabIndex = 9;
            this.Rep1.Text = "checkBox1";
            this.Rep1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Rep1.UseVisualStyleBackColor = true;
            this.Rep1.CheckedChanged += new System.EventHandler(this.Rep1_CheckedChanged_1);
            // 
            // TextComment
            // 
            this.TextComment.Controls.Add(this.TexteExplication);
            this.TextComment.Location = new System.Drawing.Point(161, 448);
            this.TextComment.Name = "TextComment";
            this.TextComment.Size = new System.Drawing.Size(644, 103);
            this.TextComment.TabIndex = 13;
            this.TextComment.TabStop = false;
            this.TextComment.Visible = false;
            // 
            // TexteExplication
            // 
            this.TexteExplication.AutoSize = true;
            this.TexteExplication.Location = new System.Drawing.Point(9, 25);
            this.TexteExplication.MaximumSize = new System.Drawing.Size(630, 0);
            this.TexteExplication.Name = "TexteExplication";
            this.TexteExplication.Size = new System.Drawing.Size(35, 13);
            this.TexteExplication.TabIndex = 0;
            this.TexteExplication.Text = "label1";
            this.TexteExplication.Visible = false;
            this.TexteExplication.Click += new System.EventHandler(this.TexteExplication_Click);
            // 
            // Rep2
            // 
            this.Rep2.AutoSize = true;
            this.Rep2.Location = new System.Drawing.Point(26, 193);
            this.Rep2.MaximumSize = new System.Drawing.Size(500, 0);
            this.Rep2.Name = "Rep2";
            this.Rep2.Size = new System.Drawing.Size(80, 17);
            this.Rep2.TabIndex = 15;
            this.Rep2.Text = "checkBox1";
            this.Rep2.UseVisualStyleBackColor = true;
            this.Rep2.CheckedChanged += new System.EventHandler(this.Rep2_CheckedChanged);
            // 
            // Rep3
            // 
            this.Rep3.AutoSize = true;
            this.Rep3.Location = new System.Drawing.Point(26, 248);
            this.Rep3.MaximumSize = new System.Drawing.Size(500, 0);
            this.Rep3.Name = "Rep3";
            this.Rep3.Size = new System.Drawing.Size(80, 17);
            this.Rep3.TabIndex = 16;
            this.Rep3.Text = "checkBox1";
            this.Rep3.UseVisualStyleBackColor = true;
            // 
            // Rep4
            // 
            this.Rep4.AutoSize = true;
            this.Rep4.Location = new System.Drawing.Point(26, 312);
            this.Rep4.MaximumSize = new System.Drawing.Size(600, 0);
            this.Rep4.Name = "Rep4";
            this.Rep4.Size = new System.Drawing.Size(80, 17);
            this.Rep4.TabIndex = 17;
            this.Rep4.Text = "checkBox1";
            this.Rep4.UseVisualStyleBackColor = true;
            // 
            // AlerteFaux
            // 
            this.AlerteFaux.AutoSize = true;
            this.AlerteFaux.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlerteFaux.ForeColor = System.Drawing.Color.Red;
            this.AlerteFaux.Location = new System.Drawing.Point(361, 391);
            this.AlerteFaux.Name = "AlerteFaux";
            this.AlerteFaux.Size = new System.Drawing.Size(211, 17);
            this.AlerteFaux.TabIndex = 18;
            this.AlerteFaux.Text = "MAUVAISE(S) REPONSE(S)!";
            this.AlerteFaux.Visible = false;
            // 
            // BtnSortie
            // 
            this.BtnSortie.BackColor = System.Drawing.Color.Firebrick;
            this.BtnSortie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSortie.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSortie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSortie.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BtnSortie.Location = new System.Drawing.Point(1039, 12);
            this.BtnSortie.Name = "BtnSortie";
            this.BtnSortie.Size = new System.Drawing.Size(25, 28);
            this.BtnSortie.TabIndex = 19;
            this.BtnSortie.Text = "X";
            this.BtnSortie.UseVisualStyleBackColor = false;
            this.BtnSortie.Click += new System.EventHandler(this.BtnSortie_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(623, 58);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(430, 303);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox.TabIndex = 14;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.ImageRobot_Click);
            // 
            // Questionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1084, 659);
            this.Controls.Add(this.BtnSortie);
            this.Controls.Add(this.Rep4);
            this.Controls.Add(this.Rep3);
            this.Controls.Add(this.Rep2);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.TextComment);
            this.Controls.Add(this.Bcontinu);
            this.Controls.Add(this.Rep1);
            this.Controls.Add(this.Lcomment);
            this.Controls.Add(this.Bvalidate);
            this.Controls.Add(this.Intitule);
            this.Controls.Add(this.NumeroQuest);
            this.Controls.Add(this.AlerteFaux);
            this.Name = "Questionnaire";
            this.Text = "Questionnaire";
            this.Load += new System.EventHandler(this.Question1_Load);
            this.TextComment.ResumeLayout(false);
            this.TextComment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumeroQuest;
        private System.Windows.Forms.Label Intitule;
        private System.Windows.Forms.Button Bvalidate;
        private System.Windows.Forms.Button Bcontinu;
        private System.Windows.Forms.Label Lcomment;
        private System.Windows.Forms.CheckBox Rep1;
        private System.Windows.Forms.GroupBox TextComment;
        private System.Windows.Forms.PictureBox PictureBox;
        internal System.Windows.Forms.Label TexteExplication;
        private System.Windows.Forms.CheckBox Rep2;
        private System.Windows.Forms.CheckBox Rep3;
        private System.Windows.Forms.CheckBox Rep4;
        private System.Windows.Forms.Label AlerteFaux;
        private System.Windows.Forms.Button BtnSortie;
    }
}