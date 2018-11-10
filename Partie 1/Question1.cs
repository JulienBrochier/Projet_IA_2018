﻿using System;
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
        XmlElement root;
        XmlNodeList elemList;
        List<int> numListe;
        ShowImgSupplementaire montrerImage;

        public Question1(int index)
        {
            
            InitializeComponent();

            this.index = index;

            montrerImage = new ShowImgSupplementaire();

            numeroQuestion = 0;

            document = new XmlDocument();

            document.Load("../../listeQuestions.xml");

            //Préparer le tirage au sort
            root = document.DocumentElement;
            elemList = root.GetElementsByTagName("question");
            numListe = new List<int>();
            for (int i = 0; i<elemList.Count-1;i++)
            {
                numListe.Add(i);
            }

            Affiche();
            
        }

        private void Rep1_CheckedChanged(object sender, EventArgs e)
        {

               
        }

        private void Affiche()
        {
            XmlReader doc = XmlReader.Create("../../listeQuestions.xml");

            numeroQuestion ++;
            NumeroQuest.Text = "Question n°" + numeroQuestion;

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
                montrerImage.Show();
                montrerImage.pictureBox.Image = Images.Texte;
            }

            if (index == 17)
            {
                PictureBox.Image = Images.TexteAllumette;
                PictureBox.Show();
                montrerImage.Show();
                montrerImage.pictureBox.Image = Images.arbre;
            }

            if (index == 18)
            {
                montrerImage.Show();
                montrerImage.pictureBox.Image = Images.ArbreDecision;
            }

            if (index == 19)
            {
                montrerImage.Show();
                montrerImage.pictureBox.Image = Images.ReseauBayesien;
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
            doc.Read();
            doc.Read();
            if (R.Checked)
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
            TextComment.Hide();
            Lcomment.Hide();
            TexteExplication.Hide();
            Suivant();
        }

        private void Suivant ()
        {
            //enlever les images s'il y en a
            PictureBox.Hide();
            if (index==17 || index == 15 || index == 16)
            {montrerImage.Close(); }

            //déchocher toutes les cases
            RemiseZeroCheck(Rep1);
            RemiseZeroCheck(Rep2);
            RemiseZeroCheck(Rep3);
            RemiseZeroCheck(Rep4);

            // Tirage au sort des questions parmis la liste (améliorer encore par rapport à la première question) 
            Random rnd = new Random();
            int i = rnd.Next(0, numListe.Count);
            int num = numListe[i];
            index = num;
            numListe.Remove(numListe[i]);

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
