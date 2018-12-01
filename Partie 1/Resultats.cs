using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pluscourtchemin;

namespace Partie_1
{
    public partial class Resultats : Form
    {
        public double points;
        private bool dijkstra;
        Form1 algo;
        public Resultats()
        {
            InitializeComponent();
            dijkstra = false;
            algo = new Form1();
        }

        private void Titre_Click(object sender, EventArgs e)
        {

        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Total_Click(object sender, EventArgs e)
        {

        }

        internal void BtnPartie2_Click(object sender, EventArgs e)
        {
            if (!dijkstra)
            {
                algo.Show();

                Total.Text = "" + (points) + "/17";

                label1.Text = "Vous venez de résoudre l'algorithme de Dijsktra, pour actualiser votre score cliquez-ici";
                dijkstra = true;
            }

            else
            {
                Total.Text = "" + (points+algo.reussite) + "/20";
                label1.Text = "Merci d'avoir complété ce test !!";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
