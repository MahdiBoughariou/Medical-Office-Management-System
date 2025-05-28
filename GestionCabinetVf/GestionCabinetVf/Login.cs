using GestionCabinetVf.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionCabinetVf
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void lblConnecter_Click(object sender, EventArgs e)
        {

        }

        private void lblUtilisateur_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMdp_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lblMessage.Text = "Tous les champs sont obligatoires.";
                lblMessage.Visible = true;
                return;
            }

            using (var context = new CabinetMedicalContext())
            {
                var user = context.Utilisateurs
                                  .FirstOrDefault(u => u.Username == username && u.Password == password);

                if (user != null)
                {
                    lblMessage.Visible = false;
                    MessageBox.Show("Connexion réussie !");

                    // Vérifier le rôle
                    if (user.Role == "secretaire")
                    {
                        SecretaireDashboard secretaireForm = new SecretaireDashboard();
                        secretaireForm.Show();
                        this.Hide();
                    }
                    else if (user.Role == "medecin")
                    {
                        MedecinDashboard medecinForm = new MedecinDashboard();
                        medecinForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Rôle inconnu.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    lblMessage.Text = "Nom d'utilisateur ou mot de passe incorrect.";
                    lblMessage.Visible = true;
                }
            }
        }
    }
}
