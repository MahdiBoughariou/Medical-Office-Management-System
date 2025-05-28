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
    public partial class ListePatientsForm : Form
    {
        public ListePatientsForm()
        {
            InitializeComponent();
            ChargerPatients(); // Charger tous les patients au début
        }

        private void ChargerPatients(string recherche = "")
        {
            using (var context = new CabinetMedicalContext())
            {
                var patients = context.Patients
                    .Where(p => string.IsNullOrEmpty(recherche) ||
                                p.Nom.Contains(recherche) ||
                                p.Prenom.Contains(recherche) ||
                                p.Telephone.Contains(recherche))
                    .Select(p => new
                    {
                        p.Id,
                        p.Nom,
                        p.Prenom,
                        p.Adresse,
                        p.Telephone,
                        p.DateNaissance
                    })
                    .ToList();

                dgvPatients.DataSource = patients;
                dgvPatients.Columns["Id"].Visible = false; // Ne pas afficher l'ID
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string recherche = txtRecherche.Text.Trim();
            ChargerPatients(recherche);
        }

        private void lblListePatients_Click(object sender, EventArgs e)
        {

        }

        private void lblRecherche_Click(object sender, EventArgs e)
        {

        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModifierPatient_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count > 0)
            {
                // Récupérer l'ID du patient sélectionné dans la DataGridView
                int patientId = Convert.ToInt32(dgvPatients.SelectedRows[0].Cells["Id"].Value);

                // Ouvrir le formulaire ModifierPatientForm avec l'ID du patient
                ModifierPatientForm modifierForm = new ModifierPatientForm(patientId);
                modifierForm.ShowDialog(); // Ouvre le formulaire de modification en mode modal
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un patient à modifier.");
            }
        }

        private void btnSupprimerPatient_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un patient à supprimer.");
                return;
            }

            int patientId = (int)dgvPatients.SelectedRows[0].Cells["Id"].Value;

            var confirmResult = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce patient ?",
                                                 "Confirmation",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                using (var context = new CabinetMedicalContext())
                {
                    var patient = context.Patients.Find(patientId);
                    if (patient != null)
                    {
                        context.Patients.Remove(patient);
                        context.SaveChanges();
                    }
                }

                ChargerPatients(); // Rafraîchir la liste
            }
        }

        private void btnRdv_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count > 0)
            {
                int patientId = Convert.ToInt32(dgvPatients.SelectedRows[0].Cells["Id"].Value);
                string nom = dgvPatients.SelectedRows[0].Cells["Nom"].Value.ToString();
                string prenom = dgvPatients.SelectedRows[0].Cells["Prenom"].Value.ToString();

                AjouterRdvForm rdvForm = new AjouterRdvForm(patientId, nom, prenom);
                rdvForm.ShowDialog(); // Ouvre le formulaire en mode modal
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un patient pour ajouter un rendez-vous.");
            }
        }

    }
}
