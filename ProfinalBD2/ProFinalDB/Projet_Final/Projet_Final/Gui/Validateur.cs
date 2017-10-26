using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Projet_Final.Fomulaires;

namespace Projet_Final.Fomulaires
{
    public static class Validateur
    {
        const string err = "Entree invalide";
        public static bool EstPresent(MaskedTextBox textbox)
        {
            if (textbox.Text == "")
            {
                MessageBox.Show(textbox.Tag.ToString() + " est un champ obligatoire.", err, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public static bool EstPresent(TextBox textbox)
        {
            if (textbox.Text == "")
            {
                MessageBox.Show(textbox.Tag.ToString() + " est un champ obligatoire.", err, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public static bool EstNumerique(TextBox textbox)
        {
            int temp = 0;
            if (!(int.TryParse(textbox.Text, out temp)))
            {
                MessageBox.Show(textbox.Tag.ToString() + " doit etre numerique.", "Erreure avec la quantité", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public static bool EstValideTaille(TextBox textbox, int taille)
        {
            if (textbox.Text.Length != taille)
            {
                MessageBox.Show(textbox.Tag.ToString() + " doit contenir " + taille + " chiffres", err, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public static bool EstValidUtilisateur(TextBox textbox, string prenom, string nom, int taille)
        {
            //Appel aux methodes 
            bool valid = EstPresent(textbox) && EstNumerique(textbox) && EstValideTaille(textbox, taille)
                && EstValidString(prenom, "prenom") && EstValidString(nom, "nom");
            return valid;
        }
        public static bool EstValidString(string str, string info)
        {
            bool estValide = true;

            for (int i = 0; i < str.Length; i++)
            {
                if (!Char.IsLetter(str, i))
                {
                    MessageBox.Show("Le " + info + " n'est pas valide");
                    return false;
                }

            }
            return estValide;
        }
        public static void mettreMajuscule (String chaine)
        {
            chaine.Substring(0, 1).ToUpper();
        }
        public static void verififerCredit (decimal credit)
        {

            if (credit <= 0)
            {

                MessageBox.Show("La limite de crédit est dépassée !", "Attention !", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }

        }
        public static bool itemSelectionneLV(ListView listView)
        {

            if (listView.Items.Count > 0 && listView.SelectedItems.Count > 0)
            {
                if (listView.FocusedItem.Index > -1)
                {
                    return true;
                }
            }

            MessageBox.Show("Vous devez Selectionner une ligne dans la liste.", "Selection incomplete",MessageBoxButtons.OK,MessageBoxIcon.Error);
            return false;
        }
        public static bool emailCorrect (string email)
        {
            // alphaNum@alphaNum.com
            Regex rx1 = new Regex("^[a-zA-Z0-9]{1,20}@[a-zA-Z0-9]{1,20}.[a-zA-Z]{2,3}$");
            Regex rx2 = new Regex("^[a-zA-Z0-9]{1,20}.[a-zA-Z0-9]{1,20}@[a-zA-Z0-9]{1,20}.[a-zA-Z]{2,3}$");
            if (rx1.IsMatch( email) || rx2.IsMatch(email))
            {
                return true;
            }
            else
            {
                MessageBox.Show("L'adresse email a un format incorrect", "Erreure dans la saisie de l'adresse email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }


        }
        public static bool comparerChaine(string chaine1 , string chaine2)
    {
        chaine1.ToUpper();
        chaine2.ToUpper();
            if    (chaine1 == chaine2)
            {
                return true;
            }
            else
            {
             return false;
            }          
    }
        public static bool stockSUffisant(int qtStock, int qtDemandee)
        {
            if(qtStock > qtDemandee)
            {
                return true;
            }
            else
            {
                return false;
            }
         
            
        }
        public static bool creditSuffisant(decimal tarif , decimal credit)
        {
            if (credit > tarif)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Le montant de la commande excède votre Crédit", "Solde insuffisant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

        }
        public static bool estVide(TextBox tb)
        {
            bool estVide = false;

            if (string.IsNullOrEmpty(tb.Text.Trim()))
            {
                MessageBox.Show("VOus devez entrer une quantité","Quantité non renseignée", MessageBoxButtons.OK,MessageBoxIcon.Hand);
                return true;
            }

            return estVide;
        }
       
    }
}
