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
    public partial class ModifierPatientForm : Form
    {
        private int patientId; // Variable pour stocker l'ID du patient

        // Constructeur qui prend l'ID du patient en paramètre
        public ModifierPatientForm(int id)
        {
            InitializeComponent();
            patientId = id; // Initialiser l'ID du patient
            ChargerPatient(); // Charger les informations du patient
        }

        private void ChargerPatient()
        {
            using (var context = new CabinetMedicalContext())
            {
                var patient = context.Patients.SingleOrDefault(p => p.Id == patientId);
                if (patient != null)
                {
                    txtNom.Text = patient.Nom;
                    txtPrenom.Text = patient.Prenom;
                    txtAdresse.Text = patient.Adresse;
                    txtTelephone.Text = patient.Telephone;

                }
                else
                {
                    MessageBox.Show("Patient non trouvé.");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
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

        // Sauvegarder les modifications du patient
        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            using (var context = new CabinetMedicalContext())
            {
                var patient = context.Patients.SingleOrDefault(p => p.Id == patientId);
                if (patient != null)
                {
                    patient.Nom = txtNom.Text;
                    patient.Prenom = txtPrenom.Text;
                    patient.Adresse = txtAdresse.Text;
                    patient.Telephone = txtTelephone.Text;

                    context.SaveChanges(); // Sauvegarde les modifications dans la base de données
                    MessageBox.Show("Les informations du patient ont été mises à jour.");

                    // Fermer le formulaire après la mise à jour
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Patient non trouvé.");
                }
            }
        }
    }
}
