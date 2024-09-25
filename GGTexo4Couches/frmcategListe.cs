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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmcategdetails frmDetail = new frmcategdetails(null, 'n');
            frmDetail.ShowDialog();
            LoadUsers();
        }
        private void UpdateUserCount()
        {
            int visibleCount = listView.Items.Cast<ListViewItem>().Count(item => item.BackColor == SystemColors.Window);
            lblCount.Text = $"Total: {visibleCount} utilisateurs";
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtFilter.Text.Trim();
            DataTable dtFilteredUsers = GGTCATEGORIE08.SelectAll(filterText);
            listView.Items.Clear();
            foreach (DataRow row in dtFilteredUsers.Rows)
            {
                ListViewItem item = new ListViewItem(row["categorieId"].ToString());
                
                listView.Items.Add(item);
            }
            lblCount.Text = listView.Items.Count.ToString();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                string selectedLogin = listView.SelectedItems[0].Text;
                GGTCATEGORIE08 selectedUser = new GGTCATEGORIE08(selectedLogin);
                frmcategdetails frmDetail = new frmcategdetails(selectedUser, 'c');
                frmDetail.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à afficher.");
            }
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                string selectedLogin = listView.SelectedItems[0].Text;
                GGTCATEGORIE08 selectedUser = new GGTCATEGORIE08(selectedLogin);
                frmcategdetails frmDetail = new frmcategdetails(selectedUser, 'm');
                frmDetail.ShowDialog();
                LoadUsers(); // Refresh the list after modification
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à modifier.");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                string selectedLogin = listView.SelectedItems[0].Text;
                GGTCATEGORIE08 selectedUser = new GGTCATEGORIE08(selectedLogin);
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet utilisateur ?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    selectedUser.Supprimer(selectedLogin);
                    MessageBox.Show("L'utilisateur a été supprimé.");
                    LoadUsers(); // Refresh the list after deletion
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à supprimer.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
