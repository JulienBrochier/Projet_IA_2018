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
using System.Windows.Forms;
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
            XmlDocument document = new XmlDocument();
            document.Load("../../listeQuestions.xml");
            XmlElement root=document.DocumentElement;
            XmlNodeList elemList= root.GetElementsByTagName("question"); 
            Random rnd = new Random();
            int index = rnd.Next(1, elemList.Count);
            Question1 question = new Question1(index);
            question.Show();
            
        }
    }
}
