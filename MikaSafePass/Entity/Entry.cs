using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikaSafePass.Entity
{
    public class Entry
    {
        private string uuid="";
        [Browsable(false)]
        public string UUID
        {
            get => uuid;
            set => uuid = value;
        }

        private string titre = "";
        [DisplayName("Titre")]
        public string Titre
        {
            get => titre;
            set => titre = value;
        }
        private string nomUser = "";
        [DisplayName("Nom d'utilisateur")]
        public string NomUser
        {
            get => nomUser;
            set => nomUser = value;
        }
        private string mdp = "";
        [DisplayName("Mot de Passe")]
        public string Mdp
        {
            get => mdp;
            set => mdp= value;
        }
        private string lien = "";
        [DisplayName("URL")]
        public string Lien
        {
            get => lien;
            set => lien = value;
        }
        private DateTime creeLe;
        [DisplayName("Date de création")]
        public DateTime CreeLe
        {
            get => creeLe;
            set => creeLe= value;
        }
    }
}
