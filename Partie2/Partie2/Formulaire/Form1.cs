using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Formulaire
{
    public partial class Form1 : Form
    {
        static public int nbGraphes = 1;
        static public double[,] matrice;
        static public int nbnodes;
        static public int numinitial;
        static public int numfinal;
        static public SearchTree g;
        static int numLigne;
        public List<TextBox> L_TextBoxs_Ouverts;
        public List<TextBox> L_TextBoxs_Fermes;

        public Form1()
        {
            InitializeComponent();

            L_TextBoxs_Ouverts = new List<TextBox>();
            L_TextBoxs_Ouverts.Add(TBO0);
            L_TextBoxs_Ouverts.Add(TBO1);
            L_TextBoxs_Ouverts.Add(TBO2);
            L_TextBoxs_Ouverts.Add(TBO3);
            L_TextBoxs_Ouverts.Add(TBO4);
            L_TextBoxs_Ouverts.Add(TBO5);
            L_TextBoxs_Ouverts.Add(TBO6);

            L_TextBoxs_Fermes = new List<TextBox>();
            L_TextBoxs_Fermes.Add(TBF0);
            L_TextBoxs_Fermes.Add(TBF1);
            L_TextBoxs_Fermes.Add(TBF2);
            L_TextBoxs_Fermes.Add(TBF3);
            L_TextBoxs_Fermes.Add(TBF4);
            L_TextBoxs_Fermes.Add(TBF5);
            L_TextBoxs_Fermes.Add(TBF6);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Binit_Click(object sender, EventArgs e)
            //tire au sort un graphe dans un fichier texte
            //initialise les variables du programme à partir de ce graph
            //affiche le graphe
        {
            //Choix du graphe
            Random r = new Random();
            int numGraphe = r.Next(1,nbGraphes+1);

            //lecture de fichier et modification de la matrice
            System.IO.StreamReader file = new System.IO.StreamReader("graphe"+numGraphe+".txt");
            string line;

            line = file.ReadLine();
            nbnodes = (int) line[0];

            //initialisation de la matrice
                //matrice vide
                matrice = new double[nbnodes, nbnodes];
                for (int i = 0; i < nbnodes; i++)
                    for (int j = 0; j < nbnodes; j++)
                        matrice[i, j] = -1;


                //ajout des noeuds
                while ((line = file.ReadLine()) != null)
                {
                    matrice[line[0],line[2]] = line[4];
                    matrice[line[2],line[0]] = line[4];
                    
                }


            file.Close();

    
        }

        private void Bresolve_Click(object sender, EventArgs e)
        {

            numinitial = Convert.ToInt32(TBnoeudIni.Text);
            numfinal = Convert.ToInt32(TBnoeudFin.Text);
            g = new SearchTree();
            Node2 N0 = new Node2();
            N0.numero = numinitial;
            List<GenericNode> solution = g.RechercheSolutionAEtoile(N0);

            //
            Node2 N1 = N0;
            for (int i = 1; i < solution.Count; i++)
            {
                Node2 N2 = (Node2)solution[i];
                N1 = N2;
            }
            //

            g.GetSearchTree(TreeViewRecherche);
        }


        public void CorrigeLigne()
        {
            int indexEtapeOuverts = 0;
            int indexEtapeFermes = 0;
            bool ReussiteOuverts = true;

           //

            foreach (TextBox tb in L_TextBoxs_Ouverts)
            {
                //comment attribuer les noms aux noeuds ?
                if (tb.Text==null)
                { }

                else
                {
                    for (int indexCaratere = 0; indexCaratere < tb.Text.Length%2; indexCaratere++) //division euclidienne, sert à ignorer les virgules
                    {

                    }
                }

                //TBF0.Text += node.Name;
                indexEtapeOuverts++;
            }


            foreach (GenericNode node in Form1.g.L_Fermes)
            {

            }

            numLigne++;

            
            //
        }


        private void TBnoeudIni_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBnoeudFin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
