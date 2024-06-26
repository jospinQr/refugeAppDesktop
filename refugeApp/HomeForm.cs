using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ProgressBar = System.Windows.Forms.ProgressBar;

namespace refugeApp
{
    public partial class HomeForm : Form
    {


        FirestoreDb db;
        public HomeForm(FirestoreDb db)
        {
            InitializeComponent();
            this.db = db;
        }

        private async void HomeForm_Load(object sender, EventArgs e)
        {

        }



        private void label4_Click(object sender, EventArgs e)
        {

          

        }
    }
}
