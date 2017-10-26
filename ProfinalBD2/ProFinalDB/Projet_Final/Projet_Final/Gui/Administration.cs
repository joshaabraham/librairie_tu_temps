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
    public partial class Administration : Form
    {
  
        public Administration()
        {
            InitializeComponent();
            
        }
        private string personneMP;
        public string PersonneMP
        {
            get { return personneMP; }
            set { personneMP = value; }
        }

       private void button_Rechercher_Click(object sender, EventArgs e)
        {
            if (radioButtonId.Checked == true)
            {
                //recherche avec ID
                listView1.Items.Clear();
                Employes emp = new Employes();
                int empId = Convert.ToInt32(textBoxNoID.Text);
                emp = emp.rechercheParId(empId);

                ListViewItem item = new ListViewItem(emp.NoIdentifiant.ToString());
                item.SubItems.Add(emp.MPasse);
                item.SubItems.Add(emp.NomUtil);
                item.SubItems.Add(emp.PrenomAdmin);
                item.SubItems.Add(emp.Categorie);

                listView1.Items.Add(item);
            }
            else if (radioButtonNom.Checked == true)
            {
                listView1.Items.Clear();
                Employes emp = new Employes();
                string nom = textBox_nom.Text;
                List<Employes> listEmp = emp.rechercheParNom(nom);
                foreach (Employes em in listEmp)
                {
                    ListViewItem item = new ListViewItem(em.NoIdentifiant.ToString());
                    item.SubItems.Add(em.MPasse);
                    item.SubItems.Add(em.NomUtil);
                    item.SubItems.Add(em.PrenomAdmin);
                    item.SubItems.Add(em.Categorie);

                    listView1.Items.Add(item);
                }
            }
            else if (radioButtonPren.Checked == true)
            {
                listView1.Items.Clear();
                Employes emp = new Employes();
                string prenom = textBox_prenom.Text;
                List<Employes> listEmp = emp.rechercheParPrenom(prenom);
                foreach (Employes em in listEmp)
                {
                    ListViewItem item = new ListViewItem(em.NoIdentifiant.ToString());
                    item.SubItems.Add(em.MPasse);
                    item.SubItems.Add(em.NomUtil);
                    item.SubItems.Add(em.PrenomAdmin);
                    item.SubItems.Add(em.Categorie);

                    listView1.Items.Add(item);
                }
            }
            else if (radioButtonCateg.Checked == true)
            {
                listView1.Items.Clear();
                Employes emp = new Employes();
                string fonction = comboBox_Categorie.Text;
                List<Employes> listEmp = emp.rechercheParFonction(comboBox_Categorie.Text);
                foreach (Employes em in listEmp)
                {
                    ListViewItem item = new ListViewItem(em.NoIdentifiant.ToString());
                    item.SubItems.Add(em.MPasse);
                    item.SubItems.Add(em.NomUtil);
                    item.SubItems.Add(em.PrenomAdmin);
                    item.SubItems.Add(em.Categorie);

                    listView1.Items.Add(item);
                }
            }
            else if (radioButtonNomPrenom.Checked == true)
            {
                listView1.Items.Clear();
                Employes emp = new Employes();
                string nom = textBox_nom.Text;
                string prenom = textBox_prenom.Text;
                List<Employes> listEmp = emp.rechercheParNomPrenom(nom, prenom);
                foreach (Employes em in listEmp)
                {
                    ListViewItem item = new ListViewItem(em.NoIdentifiant.ToString());
                    item.SubItems.Add(em.MPasse);
                    item.SubItems.Add(em.NomUtil);
                    item.SubItems.Add(em.PrenomAdmin);
                    item.SubItems.Add(em.Categorie);

                    listView1.Items.Add(item);
                }
            }
           
           

           

       }

       private void button_Ajouter_Click(object sender, EventArgs e)
       {
           int empId = Convert.ToInt32(textBoxNoID.Text);
           string mdp = textBoxMDP.Text;
           string empPrenom = textBox_prenom.Text;
           string empNom = textBox_nom.Text;
           string fonction = comboBox_Categorie.Text;
           Employes emp = new Employes();
           emp.NoIdentifiant = empId;
           emp.MPasse = mdp;
           emp.PrenomAdmin = empPrenom;
           emp.NomUtil = empNom;
           emp.Categorie = fonction;
           try
           {
               emp.SaveEmploye(emp);
               MessageBox.Show("Employé ajouté");
           }
           catch(Exception)
           {
               MessageBox.Show("Employé déjà existé");
           }
           
           
       }

       private void button_Supprimer_Click(object sender, EventArgs e)
       {
           int empId = Convert.ToInt32(textBoxNoID.Text);
           Employes emp = new Employes();
           emp.NoIdentifiant = empId;
           emp.DeleteEmploye(emp);
           MessageBox.Show("Etes-vous sur de vouloir supprimer cet employé ?", "Suppression d'employé", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          
        }

       private void button_Modifier_Click(object sender, EventArgs e)
       {
           int empId = Convert.ToInt32(textBoxNoID.Text);
           string mdp = textBoxMDP.Text;
           string empPrenom = textBox_prenom.Text;
           string empNom = textBox_nom.Text;
           string fonction = comboBox_Categorie.Text;
           Employes emp = new Employes();
           emp.NoIdentifiant = empId;
           emp.MPasse = mdp;
           emp.PrenomAdmin = empPrenom;
           emp.NomUtil = empNom;
           emp.Categorie = fonction;
           emp.modifyData(emp);
       }

       private void button_Afficher_Click(object sender, EventArgs e)
       {
           listView1.Items.Clear();
           Employes emp = new Employes();
           List<Employes> listEmp=emp.ListeEmployee();
           foreach (Employes em in listEmp)
           {
               ListViewItem item = new ListViewItem(em.NoIdentifiant.ToString());
               item.SubItems.Add(em.MPasse);
               item.SubItems.Add(em.NomUtil);
               item.SubItems.Add(em.PrenomAdmin);
               item.SubItems.Add(em.Categorie);

               listView1.Items.Add(item);
           }
       }

       private void button_Quitter_Click(object sender, EventArgs e)
       {
           if (MessageBox.Show("Voulez-vous quitter l'application?", "Hi-Tech", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
           {
               Application.Exit();
           }
       }


       private void highTechToolStripMenuItem_Click(object sender, EventArgs e)
       {
           HighTechPrecisions ht = new HighTechPrecisions();
           ht.Show();
       }

       private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
       {
           if (MessageBox.Show("Voulez-vous quitter l'application?", "Hi-Tech", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
           {
               Application.Exit();
           }
       }

       private void radioButtonId_CheckedChanged(object sender, EventArgs e)
       {
           textBoxNoID.Enabled = true;
           textBoxMDP.Enabled = false;
           textBox_nom.Enabled = false;
           textBox_prenom.Enabled = false;
           comboBox_Categorie.Enabled = false;
       }

       private void radioButtonNom_CheckedChanged(object sender, EventArgs e)
       {
           textBoxNoID.Enabled = false;
           textBoxMDP.Enabled = false;
           textBox_nom.Enabled = true;
           textBox_prenom.Enabled = false;
           comboBox_Categorie.Enabled = false;
       }

       private void radioButtonPren_CheckedChanged(object sender, EventArgs e)
       {
           textBoxNoID.Enabled = false;
           textBoxMDP.Enabled = false;
           textBox_nom.Enabled = false;
           textBox_prenom.Enabled = true;
           comboBox_Categorie.Enabled = false;
       }

       private void radioButtonCateg_CheckedChanged(object sender, EventArgs e)
       {
           textBoxNoID.Enabled = false;
           textBoxMDP.Enabled = false;
           textBox_nom.Enabled = false;
           textBox_prenom.Enabled = false;
           comboBox_Categorie.Enabled = true;
       }

       private void radioButtonNomPrenom_CheckedChanged(object sender, EventArgs e)
       {
           textBoxNoID.Enabled = false;
           textBoxMDP.Enabled = false;
           textBox_nom.Enabled = true;
           textBox_prenom.Enabled = true;
           comboBox_Categorie.Enabled = false;
       }

       private void listView1_SelectedIndexChanged(object sender, EventArgs e)
       {
           if (listView1.SelectedItems.Count > 0)
           {
               foreach (ListViewItem it in listView1.SelectedItems)
               {
                   textBoxNoID.Text = it.SubItems[0].Text;
                   textBoxMDP.Text = it.SubItems[1].Text;
                   textBox_nom.Text = it.SubItems[2].Text;
                   textBox_prenom.Text = it.SubItems[3].Text;
                   comboBox_Categorie.Text = it.SubItems[4].Text;
               }
           }
       }

       private void radioButton_modNom_CheckedChanged(object sender, EventArgs e)
       {
           textBoxNoID.Enabled = false;
           textBoxMDP.Enabled = false;
           textBox_nom.Enabled = true;
           textBox_prenom.Enabled = false;
           comboBox_Categorie.Enabled = false;
       }

       private void radioButton_modPrenom_CheckedChanged(object sender, EventArgs e)
       {
           textBoxNoID.Enabled = false;
           textBoxMDP.Enabled = false;
           textBox_nom.Enabled = false;
           textBox_prenom.Enabled = true;
           comboBox_Categorie.Enabled = false;
       }

       private void radioButton_modCategorie_CheckedChanged(object sender, EventArgs e)
       {
           textBoxNoID.Enabled = false;
           textBoxMDP.Enabled = false;
           textBox_nom.Enabled = false;
           textBox_prenom.Enabled = false;
           comboBox_Categorie.Enabled = true;
       }

       private void radioButton3_CheckedChanged(object sender, EventArgs e)
       {
           textBoxNoID.Enabled = false;
           textBoxMDP.Enabled = true;
           textBox_nom.Enabled = false;
           textBox_prenom.Enabled = false;
           comboBox_Categorie.Enabled = false;
       }
    }
}
