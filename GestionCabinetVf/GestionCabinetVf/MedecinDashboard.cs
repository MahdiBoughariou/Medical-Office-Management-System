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
    public partial class MedecinDashboard : Form
    {
        public MedecinDashboard()
        {
            InitializeComponent();
        }

        private void lblBienvenue_Click(object sender, EventArgs e)
        {

        }

        private void lblGestionPatient_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouterPatient_Click(object sender, EventArgs e)
        {
            AjouterPatientForm ajouterPatientForm = new AjouterPatientForm();
            ajouterPatientForm.ShowDialog();
        }

        private void btnVoirPatients_Click(object sender, EventArgs e)
        {
            ListePatientsForm ListePatientsForm = new ListePatientsForm();
            ListePatientsForm.ShowDialog();
        }

        private void lblGestionMedicament_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouterMedicament_Click(object sender, EventArgs e)
        {
            AjouterMedicamentForm ajouterMedicamentForm = new AjouterMedicamentForm();
            ajouterMedicamentForm.ShowDialog();
        }

        private void btnVoirMedicaments_Click(object sender, EventArgs e)
        {
            ListeMedicamentsForm ListeMedicamentsForm = new ListeMedicamentsForm();
            ListeMedicamentsForm.ShowDialog();
        }

        private void lblGestionConsultation_Click(object sender, EventArgs e)
        {

        }

        private void btnCreerConsultation_Click(object sender, EventArgs e)
        {
            AjouterConsultationForm ajouterConsultationForm = new AjouterConsultationForm();
            ajouterConsultationForm.ShowDialog();
        }

        private void btnVoirConsultations_Click(object sender, EventArgs e)
        {
            ListeConsultationsForm ListeConsultationsForm = new ListeConsultationsForm();
            ListeConsultationsForm.ShowDialog();
        }

        private void btnVoirRdvs_Click(object sender, EventArgs e)
        {
            ListeRdvsForm ListeRdvsForm = new ListeRdvsForm();
            ListeRdvsForm.ShowDialog();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Voulez-vous vraiment vous déconnecter ?", "Déconnexion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Fermer toutes les fenêtres ouvertes
                foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
                {
                    if (!(form is Login)) // Fermer tout sauf Login
                    {
                        form.Close();
                    }
                }

                // Afficher la fenêtre de login
                Login login = new Login();
                login.Show();
            }
        }
    }
}
