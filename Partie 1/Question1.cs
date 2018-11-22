using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Resolvers;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Partie_1
{
    public partial class Question1 : Form
    {
        int index;
        int numeroQuestion;
        XmlDocument document;
        //XmlElement root;
        XmlNodeList elemList;
        List<int> numListe;
        Random rnd;
        ShowImgSupplementaire montrerImage;
        Resultats resultats;
        int points;

        public Question1()
        {
            
            InitializeComponent();


            index = 0;
            numeroQuestion = 0;
            points = 0;
         
            document = new XmlDocument();
            document.Load("../../listeQuestions.xml");
            //root = document.DocumentElement;
            elemList = document.GetElementsByTagName("question");

            rnd = new Random();

            numListe = new List<int>();
            for (int i = 0; i < elemList.Count ; i++)
            {
                numListe.Add(i);
            }

            resultats = new Resultats();

            Affiche();
            
        }

        private void Rep1_CheckedChanged(object sender, EventArgs e)
        {

               
        }

        private void Affiche()
        {

            if (numeroQuestion == 0)
            { index = NumeroQuestion(); }

            XmlReader doc = XmlReader.Create("../../listeQuestions.xml");

            numeroQuestion ++;

            NumeroQuest.Text =  "Question n°" + numeroQuestion ;

            Bcontinu.Hide();
            Bvalidate.Show();
            PictureBox.SendToBack();

            while (doc.Read())
             {

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

                     doc.Read();
                     doc.Read();
                    TexteExplication.Text = doc.GetAttribute("value");
                }
             }

            if (index == 6)
            {
                PictureBox.Image = Images.Rotation;
                PictureBox.Show();
            }

            if (index == 14)
            {
                PictureBox.Image = Images.Tableau;
                PictureBox.Show();
            }

            if (index == 15 || index == 16)
            {
                PictureBox.Image = Images.Texte;
                PictureBox.Show();
            }

            if (index == 17)
            {
                PictureBox.Image = Images.TexteAllumette;
                PictureBox.Show();
                montrerImage = new ShowImgSupplementaire();
                montrerImage.Show();
                montrerImage.pictureBox.Image = Images.arbre;
            }

            if (index == 18)
            {
              
                PictureBox.Image = Images.ArbreDecision;
                PictureBox.Show();
            }

            if (index == 19)
            {

                PictureBox.Image = Images.ReseauBayesien;
                PictureBox.Show();
            }  

        }

        private void Bvalidate_Click(object sender, EventArgs e)
        {
            XmlReader doc = XmlReader.Create("../../listeQuestions.xml");

            bool valide = false;

            while (doc.Read())
            {
                
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
                        TextComment.Show();
                        Lcomment.Show();
                        TexteExplication.Show();
                        Bcontinu.Show();

                    }
                    
                }
            }
        }

        private bool Verifier(XmlReader doc, CheckBox R)
        {
            bool reponse = true;

            doc.Read();
            doc.Read();
            if (R.Checked)
            {
                if (doc.GetAttribute("true_answer") == "false")
                {
                    reponse = false;
                }
            }

            else
            {
                if (doc.GetAttribute("true_answer") == "true")
                {
                    reponse = false;
                }
            }

            if (reponse)
            {
                points++;
            }

            return reponse;

        }

        private void Bcontinu_Click(object sender, EventArgs e)
        {          
            TextComment.Hide();
            Lcomment.Hide();
            TexteExplication.Hide();
            Suivant();
        }

        internal void Suivant ()
        {
           
            if(numListe.Count == 0)
            {
                resultats.Show();
                resultats.Total.Text = ""+points+"/20";
                Close();
            }
         

            //enlever les images s'il y en a
            PictureBox.Hide();
            if (index==17)
            {montrerImage.SendToBack();}

            //déchocher toutes les cases
            RemiseZeroCheck(Rep1);
            RemiseZeroCheck(Rep2);
            RemiseZeroCheck(Rep3);
            RemiseZeroCheck(Rep4);

            // Tirage au sort des questions parmis la liste (améliorer encore par rapport à la première question)  
            index = NumeroQuestion();

            Affiche();
        }

        internal int NumeroQuestion()
        {
            int j = rnd.Next(0, numListe.Count);
            int num = numListe[j];
            index = num;
            numListe.Remove(numListe[j]);

            return index;
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

        private void Rep2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RemiseZeroCheck(CheckBox c1)
        {
            if (c1.Checked)
            c1.Checked = false;
        }

        private void Lcomment_Click(object sender, EventArgs e)
        {

        }

        private void TexteExplication_Click(object sender, EventArgs e)
        {

        }

        

        private void ImageRobot_Click(object sender, EventArgs e)
        {

        }

      
    }
}
