using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Final.Fomulaires
{
    public partial class modifParametreCompte : Form
    {
        

        public modifParametreCompte()
        {
            InitializeComponent();
        }

        private string personneMP;
        public string PersonneMP
        {
            get { return personneMP; }
            set { personneMP = value; }
        }

        
        

        private void button_Valider_Click(object sender, EventArgs e)
        {
           
        }

        private void modifParametreCompte_Load(object sender, EventArgs e)
        {
            label_MP_Actuel.Text = PersonneMP;
            
        }
    }
}
