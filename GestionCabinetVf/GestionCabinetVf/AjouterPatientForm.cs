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
    public partial class AjouterPatientForm : Form
    {
        public AjouterPatientForm()
        {
            InitializeComponent();
        }

        private void lblAjouterPatient_Click(object sender, EventArgs e)
        {

        }

        private void lblNom_Click(object sender, EventArgs e)
        {

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPrenom_Click(object sender, EventArgs e)
        {

        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNaissance_Click(object sender, EventArgs e)
        {

        }

        private void dtpNaissance_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblAdresse_Click(object sender, EventArgs e)
        {

        }

        private void txtAdresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTelephone_Click(object sender, EventArgs e)
        {

        }

        private void txtTelephone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // Vérification que tous les champs sont remplis
            if (string.IsNullOrWhiteSpace(txtNom.Text) ||
                string.IsNullOrWhiteSpace(txtPrenom.Text) ||
                string.IsNullOrWhiteSpace(txtAdresse.Text) ||
                string.IsNullOrWhiteSpace(txtTelephone.Text) ||
                dtpNaissance.Value == null)
            {
                lblResultat.Text = "Tous les champs sont obligatoires";
                lblResultat.ForeColor = Color.Red;
                return; // Quitte la méthode sans ajouter le patient
            }

            using (var context = new CabinetMedicalContext())
            {
                try
                {
                    var patient = new Patient
                    {
                        Nom = txtNom.Text,
                        Prenom = txtPrenom.Text,
                        DateNaissance = DateOnly.FromDateTime(dtpNaissance.Value),
                        Adresse = txtAdresse.Text,
                        Telephone = txtTelephone.Text
                    };

                    context.Patients.Add(patient);
                    context.SaveChanges();

                    lblResultat.Text = "Patient ajouté avec succès !";
                    lblResultat.ForeColor = Color.Green; // Ou la couleur par défaut
                }
                catch (Exception ex)
                {
                    lblResultat.Text = "Erreur lors de l'ajout du patient: " + ex.Message;
                    lblResultat.ForeColor = Color.Red;
                }
            }
        }

        private void lblResultat_Click(object sender, EventArgs e)
        {

        }
    }
}
