using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Resolvers;
using System.Xml.Linq;

namespace Partie_1
{
    public partial class Questionnaire : Form
    {

        public Questionnaire()
        {
            InitializeComponent();
           
        }

        private void BoutonCommencer_Click(object sender, EventArgs e)
        {
            Question1 questionnaire = new Question1();
            questionnaire.Show();
            
        }

       
    
        private void Titre_Click(object sender, EventArgs e)
        {

        }
    }
}
