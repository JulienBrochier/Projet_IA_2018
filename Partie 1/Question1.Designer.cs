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
            this.Rep1 = new System.Windows.Forms.RadioButton();
            this.Rep4 = new System.Windows.Forms.RadioButton();
            this.Rep3 = new System.Windows.Forms.RadioButton();
            this.Rep2 = new System.Windows.Forms.RadioButton();
            this.Bvalidate = new System.Windows.Forms.Button();
            this.Bcontinu = new System.Windows.Forms.Button();
            this.Lcomment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NumeroQuest
            // 
            this.NumeroQuest.AutoSize = true;
            this.NumeroQuest.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroQuest.Location = new System.Drawing.Point(255, 45);
            this.NumeroQuest.Name = "NumeroQuest";
            this.NumeroQuest.Size = new System.Drawing.Size(96, 19);
            this.NumeroQuest.TabIndex = 0;
            this.NumeroQuest.Text = "Question n°1";
            // 
            // Intitule
            // 
            this.Intitule.AutoSize = true;
            this.Intitule.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intitule.Location = new System.Drawing.Point(77, 89);
            this.Intitule.Name = "Intitule";
            this.Intitule.Size = new System.Drawing.Size(144, 18);
            this.Intitule.TabIndex = 1;
            this.Intitule.Text = "Intitulé de la question";
            // 
            // Rep1
            // 
            this.Rep1.AutoSize = true;
            this.Rep1.Location = new System.Drawing.Point(148, 129);
            this.Rep1.Name = "Rep1";
            this.Rep1.Size = new System.Drawing.Size(69, 17);
            this.Rep1.TabIndex = 2;
            this.Rep1.TabStop = true;
            this.Rep1.Text = "reponse1";
            this.Rep1.UseVisualStyleBackColor = true;
            this.Rep1.CheckedChanged += new System.EventHandler(this.Rep1_CheckedChanged);
            // 
            // Rep4
            // 
            this.Rep4.AutoSize = true;
            this.Rep4.Location = new System.Drawing.Point(148, 238);
            this.Rep4.Name = "Rep4";
            this.Rep4.Size = new System.Drawing.Size(69, 17);
            this.Rep4.TabIndex = 3;
            this.Rep4.TabStop = true;
            this.Rep4.Text = "reponse4";
            this.Rep4.UseVisualStyleBackColor = true;
            // 
            // Rep3
            // 
            this.Rep3.AutoSize = true;
            this.Rep3.Location = new System.Drawing.Point(148, 201);
            this.Rep3.Name = "Rep3";
            this.Rep3.Size = new System.Drawing.Size(69, 17);
            this.Rep3.TabIndex = 4;
            this.Rep3.TabStop = true;
            this.Rep3.Text = "reponse3";
            this.Rep3.UseVisualStyleBackColor = true;
            // 
            // Rep2
            // 
            this.Rep2.AutoSize = true;
            this.Rep2.Location = new System.Drawing.Point(148, 163);
            this.Rep2.Name = "Rep2";
            this.Rep2.Size = new System.Drawing.Size(69, 17);
            this.Rep2.TabIndex = 5;
            this.Rep2.TabStop = true;
            this.Rep2.Text = "reponse2";
            this.Rep2.UseVisualStyleBackColor = true;
            // 
            // Bvalidate
            // 
            this.Bvalidate.Location = new System.Drawing.Point(148, 282);
            this.Bvalidate.Name = "Bvalidate";
            this.Bvalidate.Size = new System.Drawing.Size(114, 39);
            this.Bvalidate.TabIndex = 6;
            this.Bvalidate.Text = "Valider";
            this.Bvalidate.UseVisualStyleBackColor = true;
            this.Bvalidate.Click += new System.EventHandler(this.Bvalidate_Click);
            // 
            // Bcontinu
            // 
            this.Bcontinu.Location = new System.Drawing.Point(346, 282);
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
            this.Lcomment.Location = new System.Drawing.Point(319, 113);
            this.Lcomment.Name = "Lcomment";
            this.Lcomment.Size = new System.Drawing.Size(68, 13);
            this.Lcomment.TabIndex = 8;
            this.Lcomment.Text = "Commentaire";
            // 
            // Question1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 348);
            this.Controls.Add(this.Lcomment);
            this.Controls.Add(this.Bcontinu);
            this.Controls.Add(this.Bvalidate);
            this.Controls.Add(this.Rep2);
            this.Controls.Add(this.Rep3);
            this.Controls.Add(this.Rep4);
            this.Controls.Add(this.Rep1);
            this.Controls.Add(this.Intitule);
            this.Controls.Add(this.NumeroQuest);
            this.Name = "Question1";
            this.Text = "Question1";
            this.Load += new System.EventHandler(this.Question1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumeroQuest;
        private System.Windows.Forms.Label Intitule;
        private System.Windows.Forms.RadioButton Rep1;
        private System.Windows.Forms.RadioButton Rep4;
        private System.Windows.Forms.RadioButton Rep3;
        private System.Windows.Forms.RadioButton Rep2;
        private System.Windows.Forms.Button Bvalidate;
        private System.Windows.Forms.Button Bcontinu;
        private System.Windows.Forms.Label Lcomment;
    }
}