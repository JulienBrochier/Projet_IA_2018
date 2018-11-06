namespace Formulaire
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(486, 145);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(152, 180);
            this.treeView1.TabIndex = 17;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(333, 201);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(125, 134);
            this.listBox1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Noeud final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Noeud initial";
            // 
            // Bresolve
            // 
            this.Bresolve.Location = new System.Drawing.Point(486, 94);
            this.Bresolve.Name = "Bresolve";
            this.Bresolve.Size = new System.Drawing.Size(114, 23);
            this.Bresolve.TabIndex = 13;
            this.Bresolve.Text = "Lancer la résolution";
            this.Bresolve.UseVisualStyleBackColor = true;
            // 
            // TBnoeudFin
            // 
            this.TBnoeudFin.Location = new System.Drawing.Point(303, 97);
            this.TBnoeudFin.Name = "TBnoeudFin";
            this.TBnoeudFin.Size = new System.Drawing.Size(100, 20);
            this.TBnoeudFin.TabIndex = 12;
            this.TBnoeudFin.Text = "6";
            // 
            // TBnoeudIni
            // 
            this.TBnoeudIni.Location = new System.Drawing.Point(163, 97);
            this.TBnoeudIni.Name = "TBnoeudIni";
            this.TBnoeudIni.Size = new System.Drawing.Size(100, 20);
            this.TBnoeudIni.TabIndex = 11;
            this.TBnoeudIni.Text = "0";
            // 
            // Binit
            // 
            this.Binit.Location = new System.Drawing.Point(27, 81);
            this.Binit.Name = "Binit";
            this.Binit.Size = new System.Drawing.Size(75, 23);
            this.Binit.TabIndex = 10;
            this.Binit.Text = "Initialiser";
            this.Binit.UseVisualStyleBackColor = true;
            this.Binit.Click += new System.EventHandler(this.Binit_Click);
            // 
            // TBF0
            // 
            this.TBF0.Location = new System.Drawing.Point(44, 175);
            this.TBF0.Name = "TBF0";
            this.TBF0.Size = new System.Drawing.Size(100, 20);
            this.TBF0.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Etapes";
            // 
            // TBF1
            // 
            this.TBF1.Location = new System.Drawing.Point(44, 201);
            this.TBF1.Name = "TBF1";
            this.TBF1.Size = new System.Drawing.Size(100, 20);
            this.TBF1.TabIndex = 20;
            // 
            // TBF2
            // 
            this.TBF2.Location = new System.Drawing.Point(44, 227);
            this.TBF2.Name = "TBF2";
            this.TBF2.Size = new System.Drawing.Size(100, 20);
            this.TBF2.TabIndex = 21;
            // 
            // TBF3
            // 
            this.TBF3.Location = new System.Drawing.Point(44, 253);
            this.TBF3.Name = "TBF3";
            this.TBF3.Size = new System.Drawing.Size(100, 20);
            this.TBF3.TabIndex = 22;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(193, 175);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 23;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(193, 201);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 24;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(193, 227);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 25;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(193, 253);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Graphe";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(44, 305);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 29;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(193, 279);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 30;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(193, 305);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 31;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(193, 331);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 32;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(44, 331);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 33;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 279);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 385);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.TBF3);
            this.Controls.Add(this.TBF2);
            this.Controls.Add(this.TBF1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBF0);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bresolve);
            this.Controls.Add(this.TBnoeudFin);
            this.Controls.Add(this.TBnoeudIni);
            this.Controls.Add(this.Binit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListBox listBox1;
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
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox1;
    }
}

