using Google.Cloud.Firestore;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using MaterialSkin.Controls;
using refugeApp.domain;
namespace refugeApp
{
    public partial class form1 : MaterialForm
    {

        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        FirestoreDb db;

        private IEnumerable<dynamic> combinedMenageData;
        private List<dynamic> filteredMenageData;


        public form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme =
                new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Blue100, MaterialSkin.TextShade.WHITE);

            NetworkChange.NetworkAvailabilityChanged += NetworkChange_NetworkAvailabilityChanged;
            ConnecteToFireBase();
        }


        private void NetworkChange_NetworkAvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        {
            // L'événement est déclenché lorsqu'il y a un changement d'état de la connexion internet
            UpdateInternetConnectionStatus();
        }


        //pour la connetion a la DB
        private void ConnecteToFireBase()
        {
            UpdateInternetConnectionStatus();

            try
            {
                string pathTocreditials = "D:/Personel/refugeAppDesk/refugeApp/refugeApp/bin/Debug/net8.0-windows/application_default_credentials.json";

                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", pathTocreditials);
                db = FirestoreDb.Create("refugedb");

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }


        private async Task FetchData()
        {
            try
            {
                CollectionReference collection = db.Collection("Membre");

                Query query = collection.OrderBy("idMembre");
                QuerySnapshot snapshot = await query.GetSnapshotAsync();

                foreach (DocumentSnapshot doc in snapshot.Documents)
                {

                    MessageBox.Show(doc.GetValue<string>("nom"));
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching data: {ex.Message}");
            }
        }




        private async void form1_Load(object sender, EventArgs e)
        {

            //affichage de progression
            progressBarMenage.Visible = true;
            progressBarMenage.Style = ProgressBarStyle.Marquee;
            progressBarDeplace.Visible = true;
            progressBarDeplace.Style = ProgressBarStyle.Marquee;
            progressBarDeplaceF.Visible = true;
            progressBarDeplaceF.Style = ProgressBarStyle.Marquee;
            progressBarDeplaceM.Visible = true;
            progressBarDeplaceM.Style = ProgressBarStyle.Marquee;

            //pour le nombre de menages
            int nbrMange = await getDocumentCount("Menage", progressBarMenage);
            lblNbrMenage.Text = nbrMange.ToString();

            //pour le nombre de deplacer 
            int nbrMembre = await getDocumentCount("Membre", progressBarDeplace);
            int nbrResponsable = await getDocumentCount("Responsable", progressBarDeplace);
            int nbrDplace = nbrMembre + nbrResponsable;
            lblNbrDeplace.Text = nbrDplace.ToString();


            //Nombre de deplacer Feminin
            int nbrMembreF = await getDocumentCount("Membre", "F", progressBarDeplaceF);
            int nbrResponsableF = await getDocumentCount("Responsable", "F", progressBarDeplaceF);
            int nbrDplaceF = nbrMembreF + nbrResponsableF;
            lblNbrDeplaceF.Text = nbrDplaceF.ToString();


            //Nombre de deplacer Masulin
            int nbrMembreM = await getDocumentCount("Membre", "M", progressBarDeplaceM);
            int nbrResponsableM = await getDocumentCount("Responsable", "M", progressBarDeplaceM);
            int nbrDplaceM = nbrMembreM + nbrResponsableM;
            lblNbrDeplaceM.Text = nbrDplaceM.ToString();


            //Nombre de placerMineur
            int nbrDeplacerMinineur = await getMineurCount();
            lblNbrEnfant.Text = nbrDeplacerMinineur.ToString();

            //Nombre de placerMineur
            int nbrDeplacerMajeur = await getMajeur() + nbrMange;
            lblnbrDeplaceAdulte.Text = nbrDeplacerMajeur.ToString();

            fetchMenageData();
        }







        private async Task<int> getDocumentCount(string collectionRef, ProgressBar progress)
        {

            try
            {
                CollectionReference collectionRe = db.Collection(collectionRef);
                QuerySnapshot snapshot = await collectionRe.GetSnapshotAsync();

                int total = snapshot.Count;

                return total;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
                return 0;
            }
            finally
            {
                progress.Visible = false;

            }
        }
        private async Task<int> getDocumentCount(string collectionRef, string critere, ProgressBar progress)
        {

            try
            {
                CollectionReference collectionRe = db.Collection(collectionRef);
                QuerySnapshot snapshot = await collectionRe.WhereEqualTo("sexe", critere).GetSnapshotAsync();

                int total = snapshot.Count;

                return total;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
                return 0;
            }
            finally
            {
                progress.Visible = false;
            }
        }

        /// <summary>
        /// Methode pour voir le nombre de minieur mineurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 


        private async Task<int> getMineurCount()
        {

            DateTime mineurAge = DateTime.UtcNow.AddYears(-18);
            CollectionReference collectionRef = db.Collection("Membre");
            QuerySnapshot snapshots = await collectionRef.WhereGreaterThan("datenaiss", mineurAge).GetSnapshotAsync();

            int total = snapshots.Count;

            return total;
        }


        /// <summary>
        /// Methode pour voir le nombre de minieur jeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 


        private async Task<int> getMajeur()
        {

            DateTime mineurAge = DateTime.UtcNow.AddYears(-18);


            CollectionReference collectionRef = db.Collection("Membre");
            QuerySnapshot snapshots = await collectionRef.WhereLessThanOrEqualTo("datenaiss", mineurAge).GetSnapshotAsync();

            int total = snapshots.Count;

            return total;
        }

        private async void fetchMenageData()
        {

            CollectionReference menageCollection = db.Collection("Menage");
            CollectionReference responsableCollection = db.Collection("Responsable");

            QuerySnapshot snapshot = await menageCollection.GetSnapshotAsync();
            QuerySnapshot snapshot2 = await responsableCollection.GetSnapshotAsync();



            Dictionary<string, Menage> menageDic = snapshot.Documents.ToDictionary(doc => doc.Id, doc => doc.ConvertTo<Menage>());
            Dictionary<string, Responsable> respoDic = snapshot2.Documents.ToDictionary(doc => doc.Id, doc => doc.ConvertTo<Responsable>());


            combinedMenageData = from item1 in menageDic.Values
                                 join item2 in respoDic.Values
                                 on item1.id equals item2.manageId
                                 select new
                                 {
                                     Menage = item1,
                                     Responsable = item2,
                                 };

            // colone pour la listeview
            lstvMenage.Columns.Add("Commune", 150, HorizontalAlignment.Center);
            lstvMenage.Columns.Add("Quartier", 150);
            lstvMenage.Columns.Add("Cellule", 150);
            lstvMenage.Columns.Add("Num Parcelle", 150);
            lstvMenage.Columns.Add("Nombre de deplacés", 170);
            lstvMenage.Columns.Add("Responsable", 170);




            foreach (var document in combinedMenageData)
            {

                // Récupérer les données du document

                // Ajouter les données à votre ListView
                ListViewItem item = new ListViewItem();

                // par exemple, utilisez l'ID du document comme texte principal
                item.SubItems[0].Text = document.Menage.commune;
                // remplacer champ1 par le nom de vos champs Firestore
                item.SubItems.Add(document.Menage.quartier); // ajouter autant de sous-éléments que nécessaire
                item.SubItems.Add(document.Menage.cellule); // ajouter autant de sous-éléments que nécessaire
                item.SubItems.Add(document.Menage.numParc.ToString()); // ajouter autant de sous-éléments que nécessaire
                item.SubItems.Add(document.Menage.nbrMembre.ToString()); // ajouter autant de sous-éléments que nécessaire
                item.SubItems.Add(document.Responsable.nom + " " + document.Responsable.postnom + " " + document.Responsable.prenom);                                                       // ajouter autant de sous-éléments que nécessaire

                // Ajouter l'élément à la ListView
                lstvMenage.Items.Add(item);


            }
            lblTotalMenage.Text = lstvMenage.Items.Count.ToString();
        }


        private void lstvMenage_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // Define colors for header background and text
            Color headerBackColor = Color.LightBlue;
            Color headerTextColor = Color.Black;

            // Create brushes for header background and text
            using (Brush backBrush = new SolidBrush(headerBackColor))
            using (Brush textBrush = new SolidBrush(headerTextColor))
            {
                // Fill background
                e.Graphics.FillRectangle(backBrush, e.Bounds);

                // Draw header text
                e.Graphics.DrawString(e.Header.Text, lstvMenage.Font, textBrush, e.Bounds.X + 2, e.Bounds.Y + 2);
            }
        }
        private void progressDeplaceAdulte_Click(object sender, EventArgs e)
        {

        }

        private void materialTabControl1_Selected(object sender, TabControlEventArgs e)
        {

        }

        private async void tabPage2_Enter(object sender, EventArgs e)
        {

        }

        private void materialTextBox21_Click(object sender, EventArgs e)
        {

        }


        //onSe
        private void materialTextBox21_TextChanged(object sender, EventArgs e)
        {



        }


        private void DisplayMenageData(List<dynamic> data)
        {
            // Efface toutes les lignes existantes de la ListView
            lstvMenage.Items.Clear();

            // Ajoute les données filtrées à la ListView
            foreach (var document in data)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems[0].Text = document.Menage.commune;
                item.SubItems.Add(document.Menage.quartier);
                item.SubItems.Add(document.Menage.cellule);
                item.SubItems.Add(document.Menage.numParc.ToString());
                item.SubItems.Add(document.Menage.nbrMembre.ToString());
                item.SubItems.Add(document.Responsable.nom + " " + document.Responsable.postnom + " " + document.Responsable.prenom);
                lstvMenage.Items.Add(item);
            }

            // Met à jour le label du total
            lblTotalMenage.Text = lstvMenage.Items.Count.ToString();
        }



        //pour la verification de la connectivite a internet
        private Boolean UpdateInternetConnectionStatus()
        {
            bool isConnected = NetworkInterface.GetIsNetworkAvailable();
            if (isConnected)
            {
                try
                {
                    Ping myPing = new Ping();
                    PingReply reply = myPing.Send("google.com", 1000);
                    if (reply != null && reply.Status == IPStatus.Success)
                    {
                        return true;

                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void lstvMenage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchMenage_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtSearchMenage.Text.ToLower(); // Texte de filtre en minuscules

            if (string.IsNullOrWhiteSpace(filterText))
            {
                // Si le texte de filtre est vide ou seulement des espaces, affiche toutes les données non filtrées
                DisplayMenageData(combinedMenageData.ToList());
            }
            else
            {
                // Filtrer les données en fonction du texte de filtre
                filteredMenageData = combinedMenageData
                    .Where(item =>
                        item.Menage.commune.ToLower().Contains(filterText) || // Exemple de condition de filtre sur le champ 'commune'
                        item.Menage.quartier.ToLower().Contains(filterText) ||
                        item.Menage.cellule.ToLower().Contains(filterText) ||
                        item.Responsable.nom.ToLower().Contains(filterText) ||
                        item.Responsable.postnom.ToLower().Contains(filterText) ||
                        item.Responsable.prenom.ToLower().Contains(filterText) ||
                        item.Menage.nbrMembre.ToString().Contains(filterText)


                        )

                    .ToList();

                DisplayMenageData(filteredMenageData);
            }
        }

        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
