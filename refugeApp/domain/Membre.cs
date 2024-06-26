using Google.Rpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace refugeApp.domain
{
    class Membre
    {

        public int idMembre { get; set; }
        public string nom { get; set; }
        public string postNom { get; set; }
        public string prenom { get; set; }
        public DateTime dateNaiss { get; set; }
        public string lieuNaiss { get; set; }
        public string motifDeplacement { get; set; }
        public string relationRespo { get; set; }
        public string sexe { get; set; }
        public string menage { get; set; } 




    }
}
