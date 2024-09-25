using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetierExo4Couches;
using CommonExo4Couches;
using DataAccessExo4Couches;

namespace GGTexo4Couches
{
    public partial class frmcategListe : Form
    {
        public frmcategListe()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            // Assuming you have a method to load users into the ListView
            DataTable dtUsers = GGTCATEGORIE08.SelectAll("");
            listView.Items.Clear();
            foreach (DataRow row in dtUsers.Rows)
            {
                ListViewItem item = new ListViewItem(row["categorieId"].ToString());
                item.SubItems.Add(row["catDesignation"].ToString());
                
                listView.Items.Add(item);
            }
            lblCount.Text = listView.Items.Count.ToString();
        }
    }
}
