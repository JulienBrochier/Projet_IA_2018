﻿namespace Partie_1
{
    partial class Question1
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
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.TextComment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NumeroQuest
            // 
            this.NumeroQuest.AutoSize = true;
            this.NumeroQuest.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Intitule.Font = new System.Drawing.Font("Linux Biolinum G", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intitule.Location = new System.Drawing.Point(23, 58);
            this.Intitule.MaximumSize = new System.Drawing.Size(413, 0);
            this.Intitule.Name = "Intitule";
            this.Intitule.Size = new System.Drawing.Size(122, 15);
            this.Intitule.TabIndex = 1;
            this.Intitule.Text = "Intitulé de la question";
            // 
            // Bvalidate
            // 
            this.Bvalidate.Location = new System.Drawing.Point(388, 381);
            this.Bvalidate.Name = "Bvalidate";
            this.Bvalidate.Size = new System.Drawing.Size(114, 39);
            this.Bvalidate.TabIndex = 6;
            this.Bvalidate.Text = "Valider";
            this.Bvalidate.UseVisualStyleBackColor = true;
            this.Bvalidate.Click += new System.EventHandler(this.Bvalidate_Click);
            // 
            // Bcontinu
            // 
            this.Bcontinu.Location = new System.Drawing.Point(388, 571);
            this.Bcontinu.Name = "Bcontinu";
            this.Bcontinu.Size = new System.Drawing.Size(114, 39);
            this.Bcontinu.TabIndex = 7;
            this.Bcontinu.Text = "Continuer";
            this.Bcontinu.UseVisualStyleBackColor = true;
            this.Bcontinu.Click += new System.EventHandler(this.Bcontinu_Click);
            // 
            // Lcomment
            // 
            this.Lcomment.AutoSize = true;
            this.Lcomment.Font = new System.Drawing.Font("Poiret One", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lcomment.Location = new System.Drawing.Point(158, 428);
            this.Lcomment.Name = "Lcomment";
            this.Lcomment.Size = new System.Drawing.Size(107, 17);
            this.Lcomment.TabIndex = 8;
            this.Lcomment.Text = "Commentaire:";
            this.Lcomment.Visible = false;
            this.Lcomment.Click += new System.EventHandler(this.Lcomment_Click);
            // 
            // Rep1
            // 
            this.Rep1.AutoSize = true;
            this.Rep1.Location = new System.Drawing.Point(148, 109);
            this.Rep1.MaximumSize = new System.Drawing.Size(281, 0);
            this.Rep1.Name = "Rep1";
            this.Rep1.Size = new System.Drawing.Size(80, 17);
            this.Rep1.TabIndex = 9;
            this.Rep1.Text = "checkBox1";
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
            this.TexteExplication.Location = new System.Drawing.Point(23, 20);
            this.TexteExplication.MaximumSize = new System.Drawing.Size(640, 0);
            this.TexteExplication.Name = "TexteExplication";
            this.TexteExplication.Size = new System.Drawing.Size(35, 13);
            this.TexteExplication.TabIndex = 0;
            this.TexteExplication.Text = "label1";
            this.TexteExplication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TexteExplication.Visible = false;
            this.TexteExplication.Click += new System.EventHandler(this.TexteExplication_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(431, 54);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(533, 303);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox.TabIndex = 14;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.ImageRobot_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(148, 170);
            this.checkBox1.MaximumSize = new System.Drawing.Size(281, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(148, 235);
            this.checkBox2.MaximumSize = new System.Drawing.Size(281, 0);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 16;
            this.checkBox2.Text = "checkBox1";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(148, 291);
            this.checkBox3.MaximumSize = new System.Drawing.Size(281, 0);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 17;
            this.checkBox3.Text = "checkBox1";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // Question1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(976, 659);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.TextComment);
            this.Controls.Add(this.Bcontinu);
            this.Controls.Add(this.Rep1);
            this.Controls.Add(this.Lcomment);
            this.Controls.Add(this.Bvalidate);
            this.Controls.Add(this.Intitule);
            this.Controls.Add(this.NumeroQuest);
            this.Name = "Question1";
            this.Text = "Question1";
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}