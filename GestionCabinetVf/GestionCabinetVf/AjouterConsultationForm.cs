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
    public partial class AjouterConsultationForm : Form
    {
        public AjouterConsultationForm()
        {
            InitializeComponent();
            // S'assurer que l'événement Load est bien lié
            this.Load += AjouterConsultationForm_Load;
        }

        private void AjouterConsultationForm_Load(object sender, EventArgs e)
        {
            using (var context = new CabinetMedicalContext())
            {
                var patients = context.Patients
                    .Select(p => new
                    {
                        p.Id,
                        NomComplet = p.Nom + " " + p.Prenom
                    })
                    .ToList();

                cmbPatients.DataSource = patients;
                cmbPatients.DisplayMember = "NomComplet";
                cmbPatients.ValueMember = "Id";
            }
        }

        private void lblCreerConsultation_Click(object sender, EventArgs e)
        {

        }

        private void lblPatient_Click(object sender, EventArgs e)
        {

        }

        private void cmbPatients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblQR_Click(object sender, EventArgs e)
        {

        }

        private void txtQuestionsReponses_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMaladie_Click(object sender, EventArgs e)
        {

        }

        private void txtMaladie_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRemarques_Click(object sender, EventArgs e)
        {

        }

        private void txtRemarques_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreerOrdonnance_Click(object sender, EventArgs e)
        {
            using (var context = new CabinetMedicalContext())
            {
                // Vérification que tout est rempli
                if (cmbPatients.SelectedValue == null || string.IsNullOrWhiteSpace(txtQuestionsReponses.Text) ||
                    string.IsNullOrWhiteSpace(txtMaladie.Text))
                {
                    MessageBox.Show("Veuillez remplir tous les champs de la consultation.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Créer la consultation
                var consultation = new Consultation
                {
                    PatientId = (int)cmbPatients.SelectedValue,
                    QuestionsReponses = txtQuestionsReponses.Text,
                    Maladie = txtMaladie.Text,
                    Remarques = txtRemarques.Text
                };

                context.Consultations.Add(consultation);
                context.SaveChanges(); // Il faut sauvegarder pour obtenir l'ID auto-généré

                int consultationId = consultation.Id; // Maintenant on a l'ID !

                // Afficher un message de confirmation
                lblMessage.Text = "Consultation ajoutée avec succès !";
                lblMessage.ForeColor = System.Drawing.Color.Green;

                // Ouvrir AjouterOrdonnanceForm et passer l'ID
                AjouterOrdonnanceForm ordonnanceForm = new AjouterOrdonnanceForm(consultationId);
                ordonnanceForm.Show();

                // (optionnel) Tu peux fermer l'interface d'ajout consultation si tu veux :
                // this.Close();
            }
        }


        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
