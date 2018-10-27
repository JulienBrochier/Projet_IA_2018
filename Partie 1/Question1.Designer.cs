namespace Partie_1
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
            this.Rep2 = new System.Windows.Forms.CheckBox();
            this.Rep3 = new System.Windows.Forms.CheckBox();
            this.Rep4 = new System.Windows.Forms.CheckBox();
            this.TextComment = new System.Windows.Forms.GroupBox();
            this.TexteExplication = new System.Windows.Forms.Label();
            this.TextComment.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumeroQuest
            // 
            this.NumeroQuest.AutoSize = true;
            this.NumeroQuest.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroQuest.Location = new System.Drawing.Point(359, 18);
            this.NumeroQuest.Name = "NumeroQuest";
            this.NumeroQuest.Size = new System.Drawing.Size(96, 19);
            this.NumeroQuest.TabIndex = 0;
            this.NumeroQuest.Text = "Question n°1";
            this.NumeroQuest.Click += new System.EventHandler(this.NumeroQuest_Click);
            // 
            // Intitule
            // 
            this.Intitule.AutoSize = true;
            this.Intitule.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intitule.Location = new System.Drawing.Point(84, 70);
            this.Intitule.Name = "Intitule";
            this.Intitule.Size = new System.Drawing.Size(113, 16);
            this.Intitule.TabIndex = 1;
            this.Intitule.Text = "Intitulé de la question";
            // 
            // Bvalidate
            // 
            this.Bvalidate.Location = new System.Drawing.Point(254, 359);
            this.Bvalidate.Name = "Bvalidate";
            this.Bvalidate.Size = new System.Drawing.Size(114, 39);
            this.Bvalidate.TabIndex = 6;
            this.Bvalidate.Text = "Valider";
            this.Bvalidate.UseVisualStyleBackColor = true;
            this.Bvalidate.Click += new System.EventHandler(this.Bvalidate_Click);
            // 
            // Bcontinu
            // 
            this.Bcontinu.Location = new System.Drawing.Point(471, 359);
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
            this.Lcomment.Location = new System.Drawing.Point(501, 128);
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
            this.Rep1.Location = new System.Drawing.Point(148, 128);
            this.Rep1.Name = "Rep1";
            this.Rep1.Size = new System.Drawing.Size(80, 17);
            this.Rep1.TabIndex = 9;
            this.Rep1.Text = "checkBox1";
            this.Rep1.UseVisualStyleBackColor = true;
            this.Rep1.CheckedChanged += new System.EventHandler(this.Rep1_CheckedChanged_1);
            // 
            // Rep2
            // 
            this.Rep2.AutoSize = true;
            this.Rep2.Location = new System.Drawing.Point(148, 174);
            this.Rep2.Name = "Rep2";
            this.Rep2.Size = new System.Drawing.Size(80, 17);
            this.Rep2.TabIndex = 10;
            this.Rep2.Text = "checkBox1";
            this.Rep2.UseVisualStyleBackColor = true;
            this.Rep2.CheckedChanged += new System.EventHandler(this.Rep2_CheckedChanged);
            // 
            // Rep3
            // 
            this.Rep3.AutoSize = true;
            this.Rep3.Location = new System.Drawing.Point(148, 216);
            this.Rep3.Name = "Rep3";
            this.Rep3.Size = new System.Drawing.Size(80, 17);
            this.Rep3.TabIndex = 11;
            this.Rep3.Text = "checkBox1";
            this.Rep3.UseVisualStyleBackColor = true;
            // 
            // Rep4
            // 
            this.Rep4.AutoSize = true;
            this.Rep4.Location = new System.Drawing.Point(148, 262);
            this.Rep4.Name = "Rep4";
            this.Rep4.Size = new System.Drawing.Size(80, 17);
            this.Rep4.TabIndex = 12;
            this.Rep4.Text = "checkBox1";
            this.Rep4.UseVisualStyleBackColor = true;
            // 
            // TextComment
            // 
            this.TextComment.Controls.Add(this.TexteExplication);
            this.TextComment.Location = new System.Drawing.Point(504, 158);
            this.TextComment.Name = "TextComment";
            this.TextComment.Size = new System.Drawing.Size(265, 151);
            this.TextComment.TabIndex = 13;
            this.TextComment.TabStop = false;
            this.TextComment.Visible = false;
            // 
            // TexteExplication
            // 
            this.TexteExplication.AutoSize = true;
            this.TexteExplication.Location = new System.Drawing.Point(23, 20);
            this.TexteExplication.Name = "TexteExplication";
            this.TexteExplication.Size = new System.Drawing.Size(35, 13);
            this.TexteExplication.TabIndex = 0;
            this.TexteExplication.Text = "label1";
            this.TexteExplication.Visible = false;
            // 
            // Question1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 447);
            this.Controls.Add(this.TextComment);
            this.Controls.Add(this.Rep4);
            this.Controls.Add(this.Rep3);
            this.Controls.Add(this.Rep2);
            this.Controls.Add(this.Rep1);
            this.Controls.Add(this.Lcomment);
            this.Controls.Add(this.Bcontinu);
            this.Controls.Add(this.Bvalidate);
            this.Controls.Add(this.Intitule);
            this.Controls.Add(this.NumeroQuest);
            this.Name = "Question1";
            this.Text = "Question1";
            this.Load += new System.EventHandler(this.Question1_Load);
            this.TextComment.ResumeLayout(false);
            this.TextComment.PerformLayout();
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
        private System.Windows.Forms.CheckBox Rep2;
        private System.Windows.Forms.CheckBox Rep3;
        private System.Windows.Forms.CheckBox Rep4;
        private System.Windows.Forms.GroupBox TextComment;
        private System.Windows.Forms.Label TexteExplication;
    }
}