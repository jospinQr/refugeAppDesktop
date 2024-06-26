using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace refugeApp
{
    public partial class MenageForm : Form
    {
        public MenageForm(FirestoreDb db)
        {
            InitializeComponent();
        }

        private void MenageForm_Load(object sender, EventArgs e)
        {

        }
    }
}
