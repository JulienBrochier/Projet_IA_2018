using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Partie_1
{
    public partial class Question1 : Form
    {
        int index;
        int numeroQuestion;
        public Question1(int index)
        {
            InitializeComponent();
            this.index = index;
            numeroQuestion = 0;
            Affiche();
            
        }

        private void Rep1_CheckedChanged(object sender, EventArgs e)
        {

               
        }

        private void Affiche()
        {

            /*XmlDocument doc = new XmlDocument();
            doc.Load("H:/IA/Projet/Partie 1/Partie 1/listeQuestions.xml");
            XmlElement elem = (XmlElement)doc.GetElementById("question1");
            Rep1.Text = elem.value;*/

            numeroQuestion ++;
            NumeroQuest.Text = "Question n°" + numeroQuestion;


            Bcontinu.Hide();
            Bvalidate.Show();

            XmlReader doc = XmlReader.Create("../../listeQuestions.xml");
            XDocument xdoc = XDocument.Load("../../listeQuestions.xml");

            while (doc.Read())
            {
                //if ((doc.NodeType == XmlNodeType.Element) && (doc.Name == "question"))
                if(doc.GetAttribute("id")==""+index)
                {
                    Intitule.Text = doc.GetAttribute("value");

                    doc.Read();
                    doc.Read();
                    Rep1.Text = doc.GetAttribute("value");

                    doc.Read();
                    doc.Read();
                    Rep2.Text = doc.GetAttribute("value");

                    doc.Read();
                    doc.Read();
                    Rep3.Text = doc.GetAttribute("value");

                    doc.Read();
                    doc.Read();
                    Rep4.Text = doc.GetAttribute("value");

                }
            }

        }

        private void Bvalidate_Click(object sender, EventArgs e)
        {
            XmlReader doc = XmlReader.Create("../../listeQuestions.xml");
            bool valide = false;

            while (doc.Read())
            {
                //if ((doc.NodeType == XmlNodeType.Element) && (doc.Name == "question"))
                if (doc.GetAttribute("id") == "" + index)
                {
                    if (Verifier(doc, Rep1))
                    {
                        if (Verifier(doc, Rep2))
                        {
                            if (Verifier(doc, Rep3))
                            {
                                if (Verifier(doc, Rep4))
                                {
                                    valide = true;
                                }
                            }
                        }
                    } 
                  
                   if (valide)
                    {
                       
                        Suivant();
                    }

                   else
                    {
                        Bvalidate.Hide();
                        Bcontinu.Show();

                    }
                    
                }
            }
        }

        private bool Verifier(XmlReader doc, CheckBox R)
        {
            doc.Read();
            doc.Read();
            if (Rep1.Checked)
            {
                if (doc.GetAttribute("true_answer") == "false")
                {
                    return false;
                }
            }

            else
            {
                if (doc.GetAttribute("true_answer") == "true")
                {
                    return false;
                }
            }

            return true;

        }

        private void Bcontinu_Click(object sender, EventArgs e)
        {
            Suivant();
        }

        private void Suivant ()
        {
            
            Random rnd = new Random();
            index = rnd.Next(1, 4);
            Affiche();
        }

        private void Question1_Load(object sender, EventArgs e)
        {

        }

        private void NumeroQuest_Click(object sender, EventArgs e)
        {

        }

        private void Rep1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
