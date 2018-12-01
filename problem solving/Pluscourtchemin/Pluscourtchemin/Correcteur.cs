﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pluscourtchemin
{
    public class Correcteur
    {
        public string debug;


        // Renvoie -1 si il n'y a pas d'erreur, sinon renvoie le numéro de l'étape où l'erreur s'est produite
        public int CorrigeOuverts(List<TextBox> L_TextBoxs, string noeuds, char[]alphabet)
        {
            int indexString = 0;

            for (int indexEtape = 0; indexEtape < L_TextBoxs.Count; indexEtape++)   //Pour chaque TextBox
            {

                if (L_TextBoxs[indexEtape].Text != "")
                {
                    if (indexString < noeuds.Length)
                    {
                        
                        int indexCaractere = 0;


                        while (noeuds[indexString] != ',')
                        {



                            //debug += Convert.ToInt32(noeuds[indexString])-48 + "   ";
 
                            if ((L_TextBoxs[indexEtape].Text.Length +1) > indexCaractere*2) //Vérifier que le nombre d'élément dans chaque liste correspond, 
                                                                                                    //cette étape est nécessaire car comparer les contenus de 2 listes de tailles différentes amène à un out of range.
                                                                                                    //on rajoute 1 puis divise par 2 pour ne pas tenir compte des virgules séparant chaque lettre
                            {
                                    char LettreSaisie = L_TextBoxs[indexEtape].Text[indexCaractere * 2];

                                    //char noeud = noeudsEtape[indexCaractere];
                                    //return Convert.ToInt32(noeud);

                                    if (LettreSaisie != alphabet[Convert.ToInt32(noeuds[indexString])-48])
                                    {
                                        return indexEtape;
                                    }

                                //debug += LettreSaisie + "," + alphabet[Convert.ToInt32(noeuds[indexString])] + "%";

                                    //L_TextBoxs[indexEtape].Text += alphabet[Convert.ToInt32(ouverts[0])];
                            }
                            else { return indexEtape; }
                                             

                            indexCaractere++;
                            indexString++;
                        }
                        //debug += "Etape" + indexEtape +"TB "+(L_TextBoxs[indexEtape].Text.Length) + "string " + indexString;



                        indexString++; // passe la virgule
                    }
                    else { return indexEtape; }
                }

                
                else
                {
                    debug += noeuds.Length;

                    if (indexString < noeuds.Length && noeuds[indexString] != ',')
                    //L'utilisateur a fait une faute en ne remplissant pas la case, on renvoit l'étape d'erreur
                    //Sinon les 2 listes sont identiques (vides), la réponse est juste, on ne fait rien
                    {
                        return indexEtape;
                    }
                } 
                

            }
            return -1;
        }

        public int CorrigeFermes(List<TextBox> L_TextBoxs, string noeuds, char[] alphabet)
        {
            if (L_TextBoxs[0].Text.Length !=0  ) //le premier ensemble de fermés doit être vide
            {
                return 0;
            }

            for (int indexEtape = 0; indexEtape < (noeuds.Length) /2; indexEtape++) //le nombre d'étapes correspond au nombre de fermés puisqu'il y en a un nouveau par étape. On ne compte pas les virgules
            //pour chaque étape
            {
                if (L_TextBoxs[indexEtape + 1].Text == "")   //index Etape+1 car on avait traité séparemment l'étape 0.
                {
                    return indexEtape+1;
                }

                else
                {
                    for (int indexCaractere = 0; indexCaractere < indexEtape; indexCaractere++)
                    {
                        if (L_TextBoxs[indexEtape + 1].Text.Length > indexCaractere * 2)         
                        {
                            
                        }

                        else
                        {
                            return indexEtape;
                        }
                    }
                }


            }
            //  A,B,C,D






                /*
            for(int indexEtape =0; indexEtape<(noeuds.Length-1)/2; indexEtape++)    //pour chaque étape
            {
                for (int indexCaractere = 0; indexCaractere < indexEtape+1; indexCaractere++)
                {
                    if (L_TextBoxs[indexEtape].Text.Length < indexCaractere*2)
                    {
                        return indexEtape;
                    }

                    else
                    {
                        if (L_TextBoxs[indexEtape].Text[indexCaractere * 2] == alphabet[Convert.ToInt32(noeuds[indexCaractere * 2]) - 48])
                        {

                        }
                    }
                }
            }
            
    */
                return -1;

        }
    }
}
