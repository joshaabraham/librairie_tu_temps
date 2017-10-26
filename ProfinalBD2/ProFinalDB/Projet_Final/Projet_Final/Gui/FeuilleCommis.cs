using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet_Final.donnees_IO;
using Projet_Final.Fomulaires;

using Projet_Final.Class;

namespace Projet_Final.Fomulaires
{
    public partial class FeuilleCommis : Form
    {
        List<Livre> listeLivres = new List<Livre>();
        List<Commande> listeCommande = new List<Commande>();
        List<Commande> listeCoco = new List<Commande>();
        List<Client> listeClient = new List<Client>();

        Commande commande = new Commande();

        string idCommandeSelectionnee = "0";
        string idClientSelectionne;
        int indexCommandeSelectionnee;
        decimal totalLivre;
        public FeuilleCommis()
        {
            InitializeComponent();
        }
        private string personneMP;
        public string PersonneMP
        {
            get { return personneMP; }
            set { personneMP = value; }
        }

        private void FeuilleCommis_Load(object sender, EventArgs e)
        {

        }
        public void remplirComboClient()
        {
            foreach (Client client in listeClient)
            {
                comboBox_Client.Items.Add(client.ClientNom);
            }
        }
        private void afficherListeLivresStockees(List<Livre> listeLivresAfficher)
        {
            listView_Livre.Items.Clear();
            foreach (Livre livre in listeLivresAfficher)
            {
                ListViewItem item = new ListViewItem(livre.isBN);
                item.SubItems.Add(livre.Titre);
                item.SubItems.Add(livre.PUnitaire.ToString());
                item.SubItems.Add(livre.QuantiteDispo.ToString());

                listView_Livre.Items.Add(item);

            }
        }

        private void button_Ajout_Click(object sender, EventArgs e)
        {
            if (Validateur.itemSelectionneLV(listView_Livre) && !Validateur.estVide(textBox_Quantite)
                && Validateur.EstNumerique(textBox_Quantite))
            {
                int itemLivreSelectionne = listView_Livre.FocusedItem.Index;

                decimal totalPourunlivre = 0;
                int stockLivre;

                Livre unLivre = new Livre();
                unLivre = listeLivres.ElementAt(itemLivreSelectionne);


                Client unClient = new Client();
                unClient.ClientNom = comboBox_Client.Text;
                MessageBox.Show(unClient.ClientNom.ToString());
                //ListeClients.rechercherClNom(unClient.ClientNom.ToString());



                totalPourunlivre = decimal.Parse(textBox_Quantite.Text.Trim()) * decimal.Parse(unLivre.PUnitaire.ToString());
                totalLivre += totalPourunlivre;

                ListViewItem item = new ListViewItem(unLivre.isBN);
                item.SubItems.Add(unLivre.Titre);
                item.SubItems.Add(unLivre.PUnitaire.ToString());
                item.SubItems.Add(textBox_Quantite.Text.Trim());
                item.SubItems.Add(totalPourunlivre.ToString());
                item.SubItems.Add(comboBox_Client.Text);
                listView_Commande.Items.Add(item);

                label_total.Text = totalLivre.ToString();

                stockLivre = int.Parse(unLivre.QuantiteDispo.ToString()) - int.Parse(textBox_Quantite.Text.Trim());
                unLivre.QuantiteDispo = Convert.ToInt32(stockLivre);

                listeLivres[itemLivreSelectionne] = unLivre;
                afficherListeLivresStockees(listeLivres);
                textBox_Quantite.Text = "";
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aurevoir", "Quitter", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Asterisk);
            Application.Exit();
        }

        private void button_Retrait_Click(object sender, EventArgs e)
        {
            if (Validateur.itemSelectionneLV(listView_Commande))
            {
                int itemCommandeSelectionne = listView_Commande.FocusedItem.Index;
                string quantiteCommandee;
                string isbnCommande;


                Commande uneCommande = new Commande();

                isbnCommande = listView_Commande.SelectedItems[0].Text;

                quantiteCommandee = listView_Commande.SelectedItems[0].SubItems[3].Text;

                livreVersStock(isbnCommande, quantiteCommandee);

                afficherListeLivresStockees(listeLivres);
                totalLivre -= decimal.Parse(listView_Commande.SelectedItems[0].SubItems[3].Text.ToString());
                listView_Commande.Items.RemoveAt(listView_Commande.FocusedItem.Index);

                label_total.Text = totalLivre.ToString();
                MessageBox.Show("La commande a été retirée", "Supression commande", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }
        private void livreVersStock(string sIsbn, string sQty)
        {
            int i = listeLivres.FindIndex(x => x.isBN.Contains(sIsbn));
            listeLivres[i].QuantiteDispo = (int.Parse(listeLivres[i].QuantiteDispo.ToString()) + int.Parse(sQty));
        }

        private void button_Enre_Com_Click(object sender, EventArgs e)
        {
            if (listView_Commande.SelectedIndices != null)
            {
                if (listView_Commande.Items.Count > 0)
                {
                    List<Commande> listeLivresCommandePanier = new List<Commande>();

                    for (int i = 0; i < listView_Commande.Items.Count; i++)
                    {


                        Commande unCommande = new Commande();

                       

                        unCommande.CoisBN = listView_Commande.Items[i].Text;
                        unCommande.CoTitre = listView_Commande.Items[i].SubItems[1].Text;
                        unCommande.EnregistrementDate = DateTime.Now;
                        unCommande.LivraisonDate = DateTime.Now.AddDays(10);
                        unCommande.QuantiteCommandee = Convert.ToInt32(listView_Commande.Items[i].SubItems[3].Text);
                        unCommande.TarifCommande = Convert.ToDecimal(listView_Commande.Items[i].SubItems[4].Text);
                        unCommande.coClientNo = listView_Commande.Items[i].SubItems[5].Text;
                         unCommande.NoCom = unCommande.CoisBN + unCommande.coClientNo.Substring(0, 2).ToUpper();
                        listeLivresCommandePanier.Add(unCommande);
                    }

                    listeCommande = listeLivresCommandePanier;


                   
                    //string strCommandeDonneGeneral = lblCommis.Text + "," + cbClient.Text + "," + lblaTotal.Text;
                    //CommandeIO.saveIdCommandeInList(strCommandeDonneGeneral);
                    MessageBox.Show("Commande finalisée");


                    listView_Commande.Items.Clear();
                    comboBox_Client.SelectedIndex = 0;

                }

                else
                {
                    MessageBox.Show("Vous n'avez pas creer une liste pour sauvegarder");
                }
            }
            else
            {

                MessageBox.Show("Vous n'avez pas selectione une commande");
            }


        }

        private void modifierPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifParametreCompte mod = new modifParametreCompte();
            mod.PersonneMP = label_personne.Text;
            mod.Show();
            this.Hide();

        }

        private void button_Afficher_Click(object sender, EventArgs e)
        {
           
        }

        private void afficherListeCommandes(List<Commande> listAfficher)
        {
            
            foreach (Commande uneCommande in listAfficher)
            {
                ListViewItem item = new ListViewItem(uneCommande.NoCom);
                item.SubItems.Add(uneCommande.CoisBN);
                item.SubItems.Add(uneCommande.CoTitre);
                item.SubItems.Add(uneCommande.coClientNo);
                item.SubItems.Add(uneCommande.EnregistrementDate.ToString());
                item.SubItems.Add(uneCommande.LivraisonDate.ToString());
                item.SubItems.Add(uneCommande.QuantiteCommandee.ToString());
                item.SubItems.Add(uneCommande.TarifCommande.ToString());
                listView_CommandeF.Items.Add(item);

            }
        }

        private void button_Supprimer_Click(object sender, EventArgs e)
        {

        }
    }

}

