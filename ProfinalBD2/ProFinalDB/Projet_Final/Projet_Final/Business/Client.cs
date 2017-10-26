using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projet_Final.donnees_IO;

namespace Projet_Final
{
    class Client
    {
        // Les clients de Hi-Tech sont des collèges et universités du Québec.
        //L’information d'un client doit inclure : 
        //  -  id
        //  -  le nom
        //  -  rue 
        //  -  ville
        //  -  code postal
        //  -  numéro de téléphone
        //  -  limite de crédit 
        //  -  le numéro de télécopieur.

        private string clientNo;
        public string ClientNo
        {
            get { return clientNo; }
            set { clientNo = value; }
        }
        
        private string clientNom;
        public string ClientNom
        {
            get { return clientNom; }
            set { clientNom = value; }
        }

        private string clientRue;
        public string ClientRue
        {
            get { return clientRue; }
            set { clientRue = value; }

        }

        private string clientVille;
        public string ClientVille
        {
            get { return clientVille; }
            set { clientVille = value; }

        }

        private string clientCP;
        public string ClientCP
        {
            get { return clientCP; }
            set { clientCP = value; }
        }

        private string clientNTel;
        public string ClientNTel
        {
            get { return clientNTel; }
            set { clientNTel = value; }
        }

        private decimal clientCreditLim;
        public decimal ClientCeditLim
        {
            get { return clientCreditLim; }
            set { clientCreditLim = value; }
        }

        private string clientTelecopieur;
        public string ClientTelecopieur
        {
            get { return clientTelecopieur; }
            set { clientTelecopieur = value; }
        }

        public static bool SaveClient(Client cli)
        {
            return (ClientsBD.SaveData(cli));
        }

        public static bool DeleteClient(Client cli)
        {
            return (ClientsBD.DeleteData(cli));
        }
        public static List<Client> ListeClient()
        {
            return (ClientsBD.getListClient());
        }
        public static bool modifyData(Client cli)
        {
            return (ClientsBD.ModifyData(cli));
        }


    }
}
