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

        public List<TextBox> L_TextBoxs_Ouverts;
        public List<TextBox> L_TextBoxs_Fermes;
        char[] alphabet;

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

            alphabet = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
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

            

            
            if (CorrigeLignes(g.L_MaListe_Ouverts, L_TextBoxs_Ouverts) == false)
            {
                Lcommentaire.Text = "Vous vous êtes trompé dans les ouverts";
            }

            else
            { Lcommentaire.Text = "Bravo vous avez réussi toutes les étapes"; }
            

            TBdebug.Text = "A* effectué";
            
            //TBcontenu.Text = L_TextBoxs_Ouverts[0].Text;
            //Lcommentaire.Text = TBnoeudIni.Text;

        }


        public bool CorrigeLignes(List<List<GenericNode>> listeDeListe, List<TextBox> L_TB)
        {
            int indexEtape = 0;
            bool reussite = true;

            //!! pour debug
            //string solution = "";

            foreach (List<GenericNode> MaListe_Ouverts in listeDeListe)
            {
                foreach (GenericNode G in MaListe_Ouverts)
                {
                    TBcorrection.Text += G.Name;

                }

                //!! A supprimer
                int L_Count = 0;

                

                //!! remplacer L_Count par L_.Count
                if ((L_TB[indexEtape].Text.Length + 1) / 2 == MaListe_Ouverts.Count) //Vérifier que le nombre d'élément dans chaque liste correspond, 
                //cette étape est nécessaire car comparer les contenus de 2 listes de tailles différentes amène à un out of range.
                //on rajoute 1 puis divise par 2 pour ne pas tenir compte des virgules séparant chaque lettre
                {
                    

                    if (MaListe_Ouverts.Count != 0) //on ne compare pas les listes dans le cas où elles sont toutes les deux vides
                    {
                        //!!
                        TBcorrection.Text = "On est passé par là";

                        //!! remplacer L_Count par L_.Count
                        for (int indexCaractere = 0; indexCaractere < MaListe_Ouverts.Count; indexCaractere++)
                        {
                            char LettreSaisie = L_TB[indexEtape].Text[indexCaractere * 2];

                            //!!
                            TBcorrection.Text += alphabet[MaListe_Ouverts[indexCaractere].Name];

                            if (LettreSaisie != alphabet[MaListe_Ouverts[indexCaractere].Name])
                            { return false; }

                            //!! pour debug
                            //solution += LettreSaisie;

                        }
                    }
                    /*
                    for (int indexCaractere = 0; indexCaractere < L_TB[indexEtape].Text.Length%2; indexCaractere++) //division euclidienne, sert à ignorer les virgules
                    {
                        char LettreSaisie = L_TB[indexEtape].Text[indexCaractere * 2];

                        if(Convert.ToChar(LettreSaisie) - 65 != L_[indexCaractere].Name)
                            { reussite = false; }
                    }
                    */


                    //}
                }

                else { return false; }

                indexEtape++;
            }

            //!! pour debug
            //TBcorrection.Text = solution;

            return reussite;

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

        private void button1_Click(object sender, EventArgs e)
        {
            // Test CorrigeLigne()

                //Création des variables

                List<TextBox> L_TB = L_TextBoxs_Ouverts;


            GenericNode G0 = new Node2();
            GenericNode G1 = new Node2();
            GenericNode G2 = new Node2();

            List < GenericNode > L_G0 = new List<GenericNode>();
            L_G0.Add(G0);

            List<GenericNode> L_G1 = new List<GenericNode>();
            L_G1.Add(G0);
            L_G1.Add(G1);

            List<GenericNode> L_G2 = new List<GenericNode>();
            L_G1.Add(G2);
            L_G1.Add(G1);


            List<List<GenericNode>> listeDeListe = new List<List<GenericNode>>();
            listeDeListe.Add(L_G0);
            listeDeListe.Add(L_G1);
            listeDeListe.Add(L_G2);



            //Execution
            CorrigeLignes(listeDeListe, L_TB);
            
        }

        private void TBdebug_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void TBF0_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
