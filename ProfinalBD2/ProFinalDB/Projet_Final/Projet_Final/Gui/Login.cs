using Projet_Final.donnees_IO;
using Projet_Final.Fomulaires;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Final.Gui
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button_connecter_Click(object sender, EventArgs e)
        {
            string mdp = textBox_MDP.Text;
            int id = Convert.ToInt32(textBox_id.Text);

            if(EmployesBD.UtilTrouve(id, mdp) != null)
            {
                Employes emp = new Employes();
                emp = EmployesBD.UtilTrouve(id, mdp);

                if (emp.Categorie == "Gestionnaire IT")
                {
                    Administration adm = new Administration();
                    adm.PersonneMP = emp.NoIdentifiant.ToString();
                    adm.Show();
                    this.Hide();
                }
                else if (emp.Categorie == "Gestionnaire Ventes")
                {
                    COMMIS com = new COMMIS();
                    com.PersonneMP = emp.NoIdentifiant.ToString();
                    com.Show();
                    this.Hide();
                }
                else if (emp.Categorie == "Commis")
                {
                    FeuilleCommis fCommis = new FeuilleCommis();
                    fCommis.PersonneMP = emp.NoIdentifiant.ToString();
                    fCommis.Show();
                    this.Hide();

                }
                else if (emp.Categorie == "Comptable")
                {
                    // formulaire à faire

                }
                else if (emp.Categorie == "Contrôleur")
                {
                    FeuilleControle fc = new FeuilleControle();
                    fc.PersonneMP = emp.NoIdentifiant.ToString();
                    fc.Show();
                    this.Hide();

                }
                else
                {
                    // Utilisateur lambda
                }


            }
            else
            {
                MessageBox.Show("Utilisateur inconnu", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
