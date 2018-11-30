using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Interface_Dijkestra : Form
    {
        static public int nbGraphes = 1;
        static public double[,] matrice;
        static public int nbnodes;
        static public int numInitial;
        static public int numFinal;
        //static public SearchTree g;

        public List<TextBox> L_TextBoxs_Ouverts;
        public List<TextBox> L_TextBoxs_Fermes;
        char[] alphabet;


        public Interface_Dijkestra()
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



        private void Binitialise_Click(object sender, EventArgs e)
        //tire au sort un graphe dans un fichier texte
        //initialise les variables du programme à partir de ce graph
        //affiche le graphe
        {
            //Choix du graphe
            Random r = new Random();
            int numGraphe = r.Next(1, nbGraphes + 1);

            //lecture de fichier et modification de la matrice
            System.IO.StreamReader file = new System.IO.StreamReader("graphe" + numGraphe + ".txt");
            string line;

            line = file.ReadLine();
            nbnodes = (int)line[0];

            //initialisation de la matrice
            //matrice vide
            matrice = new double[nbnodes, nbnodes];
            for (int i = 0; i < nbnodes; i++)
                for (int j = 0; j < nbnodes; j++)
                    matrice[i, j] = -1;


            //ajout des noeuds
            while ((line = file.ReadLine()) != null)
            {
                matrice[line[0], line[2]] = line[4];
                matrice[line[2], line[0]] = line[4];

            }
            file.Close();
        }


        private void Bresolve_Click(object sender, EventArgs e)
        {
            //!! à modifier en lettres
            numInitial = Convert.ToInt32(TBnoeudIni.Text);
            numFinal = Convert.ToInt32(TBnoeudFin.Text);
            Dijkestra d = new Dijkestra();

            List<string> = Dijkestra.Execution(numInitial,numFinal,matrice);

        }




        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
