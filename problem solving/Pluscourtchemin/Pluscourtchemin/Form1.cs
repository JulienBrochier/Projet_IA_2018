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


namespace Pluscourtchemin
{
    public partial class Form1 : Form
    {
        static public double[,] matrice;
        static public int nbnodes = 10;
        static public int numinitial;
        static public int numfinal;

        //new
        public List<TextBox> L_TextBoxs_Ouverts;
        public List<TextBox> L_TextBoxs_Fermes;
        char[] alphabet;

        public Form1()
        {
            InitializeComponent();

            //new
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

        private void button1_Click(object sender, EventArgs e)
        {
           
            matrice = new double[nbnodes, nbnodes];
            for (int i = 0; i < nbnodes; i++)
                for (int j = 0; j < nbnodes; j++)
                    matrice[i, j] = -1;

            matrice[0, 1] = 3;      matrice[1, 0] = 3;
            matrice[0, 2] = 5;      matrice[2, 0] = 5;
            matrice[0, 3] = 7;      matrice[3, 0] = 7;
            matrice[1, 4] = 8;      matrice[4, 1] = 8;
            matrice[2, 4] = 3;      matrice[4, 2] = 3;
            matrice[4, 5] = 7;      matrice[5, 4] = 7;
            matrice[5, 6] = 4;      matrice[6, 5] = 4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numinitial = Convert.ToInt32(textBox1.Text);
            numfinal = Convert.ToInt32(textBox2.Text);
            SearchTree g = new SearchTree();
            Node2 N0 = new Node2();
            N0.numero = numinitial;
            List<GenericNode> solution = g.RechercheSolutionAEtoile(N0);

            Node2 N1 = N0;
            for (int i=1; i < solution.Count; i++)
            {
                Node2 N2 = (Node2)solution[i];
                listBox1.Items.Add(Convert.ToString(N1.numero) 
                     + "--->"  + Convert.ToString(N2.numero)
                     + "   : " +Convert.ToString(matrice[N1.numero,N2.numero]));
                N1 = N2;
            }

            g.GetSearchTree(treeView1);


            /*
            foreach (char ch in g.ouverts)
            {
                TBtests.Text += ch;
                
            }
            */

            /*
            foreach (TextBox TB in L_TextBoxs_Ouverts)
            {
                TBtests.Text += TB.Text;
            }
            */

            //TBtests.Text = g.ouverts;

            
            Correcteur c = new Correcteur();
            int resultat = c.Corrige(L_TextBoxs_Ouverts, g.ouverts, alphabet);


            if (resultat == -1)
            { resultat = c.Corrige(L_TextBoxs_Fermes, g.fermes, alphabet); }

            AfficheCorrection(resultat);
            TBtests.Text = c.debug;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            StreamReader monStreamReader = new StreamReader("graphe1.txt");

            // Lecture du fichier avec un while, évidemment !
            // 1ère ligne : "nombre de noeuds du graphe
            string ligne = monStreamReader.ReadLine();
            int i = 0;
            while (ligne[i] != ':') i++;
            string strnbnoeuds = "";
            i++; // On dépasse le ":"
            while (ligne[i] == ' ') i++; // on saute les blancs éventuels
            while (i < ligne.Length) { strnbnoeuds = strnbnoeuds + ligne[i];
                i++; 
            }
            nbnodes = Convert.ToInt32(strnbnoeuds);

            matrice = new double[nbnodes, nbnodes];
            for (i = 0; i < nbnodes; i++)
                for (int j = 0; j < nbnodes; j++)
                    matrice[i, j] = -1;

            // Ensuite on a ls tructure suivante : 
            //  arc : n°noeud départ    n°noeud arrivée  valeur
            //  exemple 4 : 
            ligne = monStreamReader.ReadLine();
            while (ligne != null)
            {
                i = 0;
                while (ligne[i] != ':') i++;
                i++; // on passe le :
                while (ligne[i] == ' ') i++; // on saute les blancs éventuels
                string strN1 = "";
                while (ligne[i] != ' ')
                {
                    strN1 = strN1 + ligne[i];
                    i++;
                }
                int N1 = Convert.ToInt32(strN1);

                // On saute les blancs éventuels
                while (ligne[i] == ' ') i++;
                string strN2 = "";
                while (ligne[i] != ' ')
                {
                    strN2 = strN2 + ligne[i];
                    i++;
                }
                int N2 = Convert.ToInt32(strN2);

                // On saute les blancs éventuels
                while (ligne[i] == ' ') i++;
                string strVal = "";
                while ((i < ligne.Length) && (ligne[i] !=' '))
                {
                    strVal = strVal + ligne[i];
                    i++;
                }
                double val = Convert.ToDouble(strVal);

                matrice[N1, N2] = val;
                matrice[N2, N1] = val;
                listBoxgraphe.Items.Add(Convert.ToString(N1)
                   + "--->" + Convert.ToString(N2)
                   + "   : " + Convert.ToString(matrice[N1, N2]));            

                ligne = monStreamReader.ReadLine();
            }
            // Fermeture du StreamReader (obligatoire) 
            monStreamReader.Close();



        }

        private void TBtests_TextChanged(object sender, EventArgs e)
        {

        }

        private void AfficheCorrection(int resultat)
        {
            if (resultat == -1)
            { Lcorrection.Text = "Bravo !! Vous avez réussi !"; }

            else { Lcorrection.Text = "Vous avez fait une erreur à l'étape"+resultat; }
        }

        private void TBF0_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
