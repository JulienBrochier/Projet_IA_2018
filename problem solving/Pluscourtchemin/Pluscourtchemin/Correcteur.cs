using System;
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
        // Renvoie -1 si il n'y a pas d'erreur, sinon renvoie le numéro de l'étape où l'erreur s'est produite
        public int Corrige(List<TextBox> L_TextBoxs, string ouverts, char[]alphabet)
        {
            for (int indexEtape = 0; indexEtape < L_TextBoxs.Count; indexEtape++)   //Pour chaque TextBox
            {

                if ((L_TextBoxs[indexEtape].Text.Length + 1) / 2 == ouverts.Length) //Vérifier que le nombre d'élément dans chaque liste correspond, 
                                                                                    //cette étape est nécessaire car comparer les contenus de 2 listes de tailles différentes amène à un out of range.
                                                                                    //on rajoute 1 puis divise par 2 pour ne pas tenir compte des virgules séparant chaque lettre
                {
                    if (ouverts.Length != 0) //on ne compare pas les listes dans le cas où elles sont toutes les deux vides, dans un tel cas, la réponse est juste
                    {

                        //for (int indexCaractere = 0; indexCaractere < ouverts.Length; indexCaractere++)

                        int indexCaractere = 0;
                        while (ouverts != "" && ouverts[0] != 'S')
                        {
                            char LettreSaisie = L_TextBoxs[indexEtape].Text[indexCaractere * 2];

                            if (LettreSaisie != alphabet[Convert.ToInt32(ouverts[0])])
                            { return indexEtape; }

                            ouverts.Remove(0); //supprime la lettre vue
                            indexCaractere++;
                        }
                        ouverts.Remove(0); //supprime le S
                    }
                }

                else { return indexEtape; }
            }
            return -1;
        }
    }
}
