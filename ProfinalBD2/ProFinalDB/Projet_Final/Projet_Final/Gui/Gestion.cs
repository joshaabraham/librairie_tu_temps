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
using Projet_Final.Properties;

namespace Projet_Final
{
    public partial class COMMIS : Form
    {
        Client clientissimo = new Client();

        public COMMIS()
        {
            InitializeComponent();
        }
        private string personneMP;
        public string PersonneMP
        {
            get { return personneMP; }
            set { personneMP = value; }
        }

        private void button_Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void COMMIS_Load(object sender, EventArgs e)
        {
            label_passageMP.Text = personneMP;
        }

        private void button_Ajouter_Click(object sender, EventArgs e)
        {
            Client cl = new Client();
        string msg = "";          
            {

                cl.ClientNo = maskedTextBox1.Text;
                cl.ClientNom = textBox_nom.Text;
                cl.ClientRue = textBox_rue.Text;
                cl.ClientVille = textBox_ville.Text;
                cl.ClientCP = maskedTextBox_codePostal.Text;
                cl.ClientCeditLim = Convert.ToDecimal(maskedTextBox_credit.Text);
                cl.ClientTelecopieur = maskedTextBox_telecopieur.Text;
                cl.ClientNTel = maskedTextBox_telephone.Text;

            }
            
            label_Detail.Text = msg;

        }

        private void button_Afficher_Click(object sender, EventArgs e)
        {
            listView_Clients.Items.Clear();

          /*
 
            foreach(Client cl in lClient)
            {
                ListViewItem item = new ListViewItem(cl.ClientNo.ToString());
                item.SubItems.Add(cl.ClientNom);
                item.SubItems.Add(cl.ClientRue);
                item.SubItems.Add(cl.ClientVille);
                item.SubItems.Add(cl.ClientCP);
                item.SubItems.Add(cl.ClientNTel);
                item.SubItems.Add(Convert.ToString(cl.ClientCeditLim));
                item.SubItems.Add(cl.ClientTelecopieur);
                listView_Clients.Items.Add(item);
                               
            }
            */
        }

        private void button_Supprimer_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Etes-vous sur de vouloir supprimer ce client ?", "Suppression de client", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            List<Client> lCli = new List<Client>();
            
          
            label_Detail.Text = "Client supprimé";

        }

        private void button_Modifier_Click(object sender, EventArgs e)
        {
            listView_Clients.Items.Clear();
             List<Client> lClients = new List<Client>();
            //if (Validateur.EstPresent(maskedTextBox1))
            //{
                
                if (radioButton_modNom.Checked)
                {
                   
                    label_Detail.Text = "Information client modifiée.";
                }
                else if (radioButton_modRue.Checked)
                {
                   
                    label_Detail.Text = "Information client modifiée.";
                }
                else if (radioButton_modVille.Checked)
                {
                  
                    label_Detail.Text = "Information client modifiée.";
                }
                else if (radioButton_modCP.Checked)
                {
                  
                    label_Detail.Text = "Information client modifiée.";
                }
                else if (radioButton_modTel.Checked)
                {
                   
                    label_Detail.Text = "Information client modifiée.";
                }
                else if (radioButton_modCredit.Checked)
                {
                   
                    label_Detail.Text = "Information client modifiée.";
                }
                else if (radioButton_modCopieur.Checked)
                {
                  
                    label_Detail.Text = "Information client modifiée.";
                }
            //}
            //else { label_Detail.Text = " Veuillez saisir le numero ID pour clibler le client à modifier.";}
            
            
        }

        private void button_Rechercher_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void compteEmployéToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void modifierParametresDuCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifParametreCompte mod = new modifParametreCompte();
            mod.PersonneMP = label_passageMP.Text;
            mod.Show();
        }

        private void aProposDeNousToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void highTechToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HighTechPrecisions ht = new HighTechPrecisions();
            ht.Show();
        }

        private void listView_Clients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
