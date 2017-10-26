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
using System.Data.SqlClient;
using Projet_Final.Class;


namespace Projet_Final
{
    public partial class FeuilleControle : Form
    {
        // creation des dataset et datatable qui servirons de stockag transitoire.
        DataSet ds = new DataSet();
        DataTable dtLivre = new DataTable("Livres");
        SqlDataAdapter da;

       

        private string personneMP;
        public string PersonneMP
        {
            get { return personneMP; }
            set { personneMP = value; }
        }
        Livre lv = new Livre();
        public FeuilleControle()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aurevoir", "Quitter", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Asterisk);
            Application.Exit();
        }

        private void button_Ajouter_Click(object sender, EventArgs e)
        {
            
            DataRow newRow;
       
            label_detail.Text = "***";
            Livre livre = new Livre();
            Auteur auteur = new Auteur();
            
            
                livre.isBN = maskedTextBox_ISBN.Text;
                livre.Titre = textBox_Titre.Text;
                livre.Editeur = comboBox_Edition.Text;
                livre.QuantiteDispo = Convert.ToInt32(numericUpDown_Quantite.Value);
                livre.PUnitaire = Convert.ToDecimal(textBox_PrixUnitaire.Text);
                livre.AnneePublication = Convert.ToDateTime(maskedTextBox_DatePublication.Text);
                livre.AuteurPrenom = textBox_AuteurPrenom.Text;
                livre.AuteurNom = textBox_AuteurNom.Text;
                livre.CategorieL = comboBox_Categorie.Text;

                newRow = ds.Tables["Livres"].Rows.Add(livre.isBN, livre.Titre, livre.Editeur, livre.QuantiteDispo, livre.PUnitaire,
    livre.AnneePublication, livre.AuteurPrenom, livre.AuteurNom, livre.CategorieL);           

            MessageBox.Show("Un nouveau Livre a été crée.");
        }

        private void button_AfficherTout_Click(object sender, EventArgs e)
        {
            label_detail.Text = "***";
            listView1.Items.Clear();
            List<Livre> lLivre = LivresBD.getListLivres();
            
            foreach(Livre lv in lLivre)
            {
                lv.AuteurGnom = lv.AuteurPrenom + " " + lv.AuteurNom;
                
                ListViewItem item = new ListViewItem(lv.isBN);
                item.SubItems.Add(lv.Titre);
                item.SubItems.Add(lv.Editeur);
                item.SubItems.Add(lv.AuteurGnom);
                item.SubItems.Add(lv.QuantiteDispo.ToString());
                item.SubItems.Add(lv.PUnitaire.ToString());
                item.SubItems.Add(lv.CategorieL);
                item.SubItems.Add(lv.AnneePublication.ToShortDateString());

                listView1.Items.Add(item);
            }
        }

        private void button_Modifier_Click(object sender, EventArgs e)
        {
            int idLivre = Convert.ToInt32(maskedTextBox_ISBN.Text);

            foreach (DataRow dr in ds.Tables["Livre"].Rows)
            {
                if (idLivre == Convert.ToInt32(dr["Livre"]))
                {

                    label_detail.Text = "***";


                    Livre livre = new Livre();
                    dr["isbn"] = maskedTextBox_ISBN.Text;
                    dr["Titre"] = textBox_Titre.Text;
                    dr["Editeur"] = comboBox_Edition.Text;
                    dr["Quantite"] = Convert.ToInt32(numericUpDown_Quantite.Value);
                    dr["PUnitaire"] = Convert.ToDecimal(textBox_PrixUnitaire.Text);
                    dr["AnneePublication"] = Convert.ToDateTime(maskedTextBox_DatePublication.Text);
                    dr["AuteurNom"] = textBox_AuteurPrenom.Text;
                    dr["AuteurPrenom"] = textBox_AuteurNom.Text;
                    dr["Categorie"] = comboBox_Categorie.Text;

                    maskedTextBox_ISBN.Enabled = true;
                    break;
                    }
                }
            }
        private void button_Supprimer_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(maskedTextBox_ISBN.Text);
            foreach (DataRow dr in ds.Tables["Livre"].Rows)
            {
                if (Convert.ToInt32(dr["ISBN"]) == id)
                {
                    dr.Delete();
                    break;
                }
            }
            label_detail.Text = "Livre supprimé";
        }

        private void button_Rechercher_Click(object sender, EventArgs e)
        {
            label_detail.Text = "***";
            listView1.Items.Clear();
            

            if(radioButton_RechISBN.Checked)
            {
                int noLivre = Convert.ToInt32(maskedTextBox_ISBN.Text);
                foreach (DataRow dr in ds.Tables["Livre"].Rows)
                {
                    if (noLivre == Convert.ToInt32(dr["isbn"]))
                    {
                        textBox_Titre.Text = dr["Titre"].ToString();
                        textBox_AuteurNom.Text = dr["Nom"].ToString();
                        textBox_AuteurPrenom.Text = dr["Prenom"].ToString();
                        textBox_PrixUnitaire.Text = dr["PUnitaire"].ToString();
                        maskedTextBox_DatePublication.Text = dr["DatePublication"].ToString();
                        comboBox_Categorie.Text = dr["Categorie"].ToString();
                        numericUpDown_Quantite.Value = Convert.ToInt32(dr["Quantite"]);
                        break;
                    }

                }
                
                
            }
            else if(radioButton_RechTitre.Checked)
            {
                string titreLivre = textBox_Titre.Text;
                foreach (DataRow dr in ds.Tables["Livre"].Rows)
                {
                    if (titreLivre == dr["Titre"].ToString())
                    {
                        textBox_Titre.Text = dr["Titre"].ToString();
                        textBox_AuteurNom.Text = dr["Nom"].ToString();
                        textBox_AuteurPrenom.Text = dr["Prenom"].ToString();
                        textBox_PrixUnitaire.Text = dr["PUnitaire"].ToString();
                        maskedTextBox_DatePublication.Text = dr["DatePublication"].ToString();
                        comboBox_Categorie.Text = dr["Categorie"].ToString();
                        numericUpDown_Quantite.Value = Convert.ToInt32(dr["Quantite"]);
                        break;
                    }

                }

            }
   
            else {
                MessageBox.Show("Selectionnez une méthode de recherche", "Methode de recherche nécessaire", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

            maskedTextBox_ISBN.Enabled = true;
            textBox_AuteurNom.Enabled = true;
            textBox_AuteurPrenom.Enabled = true;
            textBox_PrixUnitaire.Enabled = true;
            textBox_Titre.Enabled = true;
            maskedTextBox_DatePublication.Enabled = true;
            comboBox_Categorie.Enabled = true;
            comboBox_Edition.Enabled = true;
            numericUpDown_Quantite.Enabled = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

                string livreISBN = "";
                livreISBN = listView1.SelectedItems[0].SubItems[0].Text.ToString();
               
                maskedTextBox_ISBN.Text = lv.isBN;
                textBox_AuteurNom.Text = lv.AuteurNom;
                textBox_AuteurPrenom.Text = lv.AuteurPrenom;
                comboBox_Edition.Text = lv.Editeur;
                textBox_PrixUnitaire.Text = lv.PUnitaire.ToString();
                numericUpDown_Quantite.Value = lv.QuantiteDispo;
                comboBox_Categorie.Text = lv.CategorieL;
                textBox_Titre.Text = lv.Titre;
                maskedTextBox_DatePublication.Text = lv.AnneePublication.ToString();

                maskedTextBox_ISBN.Enabled = true;
                textBox_AuteurNom.Enabled = true;
                textBox_AuteurPrenom.Enabled = true;
                textBox_PrixUnitaire.Enabled = true;
                textBox_Titre.Enabled = true;
                maskedTextBox_DatePublication.Enabled = true;
                comboBox_Categorie.Enabled = true;
                comboBox_Edition.Enabled = true;
                numericUpDown_Quantite.Enabled = true;
            
        }

        private void highTechToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HighTechPrecisions ht = new HighTechPrecisions();
            ht.Show();
        }

        private void radioButton_RechISBN_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox_ISBN.Enabled = true;
            textBox_AuteurNom.Enabled = false;
            textBox_AuteurPrenom.Enabled = false;
            textBox_PrixUnitaire.Enabled = false;
            textBox_Titre.Enabled = false;
            maskedTextBox_DatePublication.Enabled = false;
            comboBox_Categorie.Enabled = false;
            comboBox_Edition.Enabled = false;
            numericUpDown_Quantite.Enabled = false;
        }

        private void radioButton_RechTitre_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox_ISBN.Enabled = false;
            textBox_AuteurNom.Enabled = false;
            textBox_AuteurPrenom.Enabled = false;
            textBox_PrixUnitaire.Enabled = false;
            textBox_Titre.Enabled = true;
            maskedTextBox_DatePublication.Enabled = false;
            comboBox_Categorie.Enabled = false;
            comboBox_Edition.Enabled = false;
            numericUpDown_Quantite.Enabled = false;
        }

        private void radioButton_RechEdition_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox_ISBN.Enabled = false;
            textBox_AuteurNom.Enabled = false;
            textBox_AuteurPrenom.Enabled = false;
            textBox_PrixUnitaire.Enabled = false;
            textBox_Titre.Enabled = false;
            maskedTextBox_DatePublication.Enabled = false;
            comboBox_Categorie.Enabled = false;
            comboBox_Edition.Enabled = true;
            numericUpDown_Quantite.Enabled = false;
        }

        private void radioButton_RechAuteur_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox_ISBN.Enabled = false;
            textBox_AuteurNom.Enabled = true;
            textBox_AuteurPrenom.Enabled = true;
            textBox_PrixUnitaire.Enabled = false;
            textBox_Titre.Enabled = false;
            maskedTextBox_DatePublication.Enabled = false;
            comboBox_Categorie.Enabled = false;
            comboBox_Edition.Enabled = false;
            numericUpDown_Quantite.Enabled = false;
        }

        private void radioButton_RechCategorie_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox_ISBN.Enabled = false;
            textBox_AuteurNom.Enabled = false;
            textBox_AuteurPrenom.Enabled = false;
            textBox_PrixUnitaire.Enabled = false;
            textBox_Titre.Enabled = false;
            maskedTextBox_DatePublication.Enabled = false;
            comboBox_Categorie.Enabled = true;
            comboBox_Edition.Enabled = false;
            numericUpDown_Quantite.Enabled = false;
        }

        private void modifierLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifParametreCompte mod = new modifParametreCompte();
            mod.PersonneMP = label_passageMP.Text;
            mod.Show();


        }

        private void FeuilleControle_Load(object sender, EventArgs e)
        {
            label_passageMP.Text = personneMP;

            da = new SqlDataAdapter("SELECT * FROM Livre", UtilityBD.connectBD());
            da.FillSchema(ds, SchemaType.Source, "Livre");
            DataColumn pkIsbn = dtLivre.Columns.Add("ISBN", typeof(int));
            dtLivre.PrimaryKey = new DataColumn[] { dtLivre.Columns["ISBN"] };
            ds.Tables.Add(dtLivre);
            da.Fill(ds, "dtLivre");

        }

        private void button_update_BD_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(da);
            da.Update(ds.Tables["Livre"]);
            MessageBox.Show("Base de données mise à jour.");
        }

        private void button_affDataset_Click(object sender, EventArgs e)
        {
            listView_Dataset.Items.Clear();
            foreach (DataRow dr in ds.Tables["dtLivre"].Rows)
            {
                
                ListViewItem item = new ListViewItem(dr["ISBN"].ToString());
                item.SubItems.Add(dr["Titre"].ToString());
                item.SubItems.Add(dr["Edition"].ToString());
                item.SubItems.Add(dr["Nom"].ToString());
                item.SubItems.Add(dr["Quantite"].ToString());
                item.SubItems.Add(dr["PUnitaire"].ToString());
                item.SubItems.Add(dr["Categorie"].ToString());
                item.SubItems.Add(dr["AnneePublication"].ToString());
                item.SubItems.Add(dr.RowState.ToString());
                listView_Dataset.Items.Add(item);

            }
        }
    }
}
