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
      
        public Resultats()
        {
            InitializeComponent();
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
            Form1 algo = new Form1();
            algo.Show();
            if (algo.reussite)
            {
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
