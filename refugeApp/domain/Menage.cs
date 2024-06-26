using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refugeApp.domain
{

    [FirestoreData]
 class Menage
    {

        [FirestoreProperty]
        public string id { get; set; } = string.Empty;
        [FirestoreProperty]
        public string commune { get; set; } = string.Empty;
        [FirestoreProperty]
        public string quartier { get; set; } = string.Empty;
        [FirestoreProperty]
        public string cellule { get; set; } = string.Empty;
        [FirestoreProperty]
        public int numParc { get; set; } = 0;
        [FirestoreProperty]
        public DateTime dateEnregistrement { get; set; } = DateTime.Now;
        [FirestoreProperty]
        public int nbrMembre { get; set; } = 0;
    }
}
