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

namespace GGTexo4Couches
{
    public partial class frmcategdetails : Form
    {
        char vOptionAppel = 'n'; // Attribute to define the call context ('n','m','c','s')
        string vTitre = ""; // Title of the form based on call context
        GGTCATEGORIE08 CurrentUser = null;
        public frmcategdetails()
        {
            InitializeComponent();
            InitForm(vOptionAppel);
        }
        public frmcategdetails(GGTCATEGORIE08 leUser, char pOptionAppel)
        {
            InitializeComponent();
            CurrentUser = leUser; // Set the current user
            vOptionAppel = pOptionAppel; // Set the call context
            InitForm(vOptionAppel); // Initialize the form title and controls based on the context
            ChargerLeUser(leUser);
        }


        private void InitForm(char optionAppel)
        {
            switch (optionAppel)
            {
                case 'n': // New user
                    vTitre = "Créer un nouvel utilisateur";
                    this.Text = vTitre;
                    // Initialize fields for a new user
                    txtLogin.Enabled = true;
                    txtMotPass.Enabled = true;

                    break;
                case 'm': // Modify user
                    vTitre = "Modifier l'utilisateur";
                    this.Text = vTitre;
                    txtLogin.Enabled = false; // Assuming login is unique and shouldn't change
                    break;
                case 'c': // Consult user
                    vTitre = "Consulter l'utilisateur";
                    this.Text = vTitre;
                    // Disable all fields since it's just for viewing
                    txtLogin.Enabled = false;
                    txtMotPass.Enabled = false;

                    break;
                case 's': // Delete user
                    vTitre = "Supprimer l'utilisateur";
                    this.Text = vTitre;
                    // Make fields read-only to confirm the details of the user to delete
                    txtLogin.Enabled = false;
                    txtMotPass.Enabled = false;

                    break;
                default:
                    break;
            }
        }

        private void ChargerLeUser(GGTCATEGORIE08 leUser)
        {
            if (leUser != null)
            {
                txtLogin.Text = leUser.UserLogin;
                txtMotPass.Text = leUser.UserMotPass;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OkSaisie())
            {
                MappFormToObject();
                switch (vOptionAppel)
                {
                    case 'n':
                        if (!Divers.ExisteUtilisateur(txtLogin.Text))
                        {
                            CurrentUser.Insert();
                            MessageBox.Show("L'utilisateur a été enregistré.", Application.ProductName, MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Risque de doublon. La saisie ne sera pas enregistrée.", Application.ProductName, MessageBoxButtons.OK);
                        }
                        break;
                    case 'c':
                        // No action needed for consult mode
                        break;
                    case 'm':
                        if (Divers.ExisteUtilisateur(txtLogin.Text))
                        {
                            CurrentUser.Update();
                            MessageBox.Show("Les modifications ont été enregistrées.", Application.ProductName, MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Code utilisateur inexistant! Les modifications ont été ignorées.", Application.ProductName, MessageBoxButtons.OK);
                        }
                        break;
                    case 's':
                        CurrentUser.Supprimer(txtLogin.Text);
                        MessageBox.Show("L'utilisateur a été supprimé.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    default:
                        break;
                }
                this.Close();
            }
        }

        private void MappFormToObject()
        {
            // Map form fields to the user object
            CurrentUser = new GGTCATEGORIE08();
            CurrentUser.UserLogin = txtLogin.Text;
            CurrentUser.UserMotPass = txtMotPass.Text;
            
        }

        private bool OkSaisie()
        {
            // Validate form input
            if (string.IsNullOrEmpty(txtLogin.Text))
            {
                MessageBox.Show("Login d'utilisateur attendu.", Application.ProductName, MessageBoxButtons.OK);
                txtLogin.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMotPass.Text))
            {
                MessageBox.Show("Mot de passe attendu.", Application.ProductName, MessageBoxButtons.OK);
                txtMotPass.Focus();
                return false;
            }
            
            return true;
        }
    }
}
