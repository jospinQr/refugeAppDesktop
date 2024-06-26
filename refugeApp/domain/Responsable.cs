using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refugeApp.domain
{
    [FirestoreData]
    class Responsable
    {

        [FirestoreProperty]
        public int id { get; set; }  =0;
        [FirestoreProperty]
        public string nom { get; set; } = string.Empty;
        [FirestoreProperty]
        public string postnom { get; set; }= string.Empty;
        [FirestoreProperty]
        public string prenom { get; set; } = string.Empty;
        [FirestoreProperty]
        public string sexe { get; set; } = string.Empty;
        [FirestoreProperty]
        public DateTime dateNaissance { get; set; } =DateTime.Now;
        [FirestoreProperty]
        public string lieuNaissance { get; set; } = string.Empty;
        [FirestoreProperty]
        public string provinveorigine { get; set; } = string.Empty;
        [FirestoreProperty]
        public string territoireOrigine { get; set;} = string.Empty;
        [FirestoreProperty]
        public string groupementQuartier { get; set;} = string.Empty;
        [FirestoreProperty]
        public string secteurCommuneOrigine { get; set; } = string.Empty;
        [FirestoreProperty]
        public string manageId { get; set; } = string.Empty;
        [FirestoreProperty]
        public string fonction { get; set; } = string.Empty;
        [FirestoreProperty]
        public string contact { get; set; } = string.Empty;



    }
}
