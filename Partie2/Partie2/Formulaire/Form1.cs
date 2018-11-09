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

        public Form1()
        {
            InitializeComponent();
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

            System.IO.StreamReader monStreamReader = new System.IO.StreamReader("graphe"+numGraphe+".txt");


            //lecture de fichier et modification de la matrice
            System.IO.StreamReader file = new System.IO.StreamReader("graphe1.txt");
            string line;

            line = file.ReadLine();
            nbnodes = (int) line[0];

                //initialisation matrice vide
                matrice = new double[nbnodes, nbnodes];
                for (int i = 0; i < nbnodes; i++)
                    for (int j = 0; j < nbnodes; j++)
                        matrice[i, j] = -1;


                while ((line = file.ReadLine()) != null)
                {
                    matrice[line[0],line[2]] = line[4];
                    matrice[line[2],line[0]] = line[4];
                    LBgraphe.Items.Add(Convert.ToString(line[0])
                       + "--->" + Convert.ToString(line[2])
                       + "   : " + Convert.ToString(line[4]));
                }


            file.Close();

    
        }

  

        private void Bresolve_Click(object sender, EventArgs e)
        {
            numinitial = Convert.ToInt32(TBnoeudIni.Text);
            numfinal = Convert.ToInt32(TBnoeudFin.Text);
            SearchTree g = new SearchTree();
            Node2 N0 = new Node2();
            N0.numero = numinitial;
            List<GenericNode> solution = g.RechercheSolutionAEtoile(N0);

            Node2 N1 = N0;
            for (int i = 1; i < solution.Count; i++)
            {
                Node2 N2 = (Node2)solution[i];
                LBgraphe.Items.Add(Convert.ToString(N1.numero)
                     + "--->" + Convert.ToString(N2.numero)
                     + "   : " + Convert.ToString(matrice[N1.numero, N2.numero]));
                N1 = N2;
            }

            g.GetSearchTree(TreeViewRecherche);
        }



        private void TBnoeudIni_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBnoeudFin_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
