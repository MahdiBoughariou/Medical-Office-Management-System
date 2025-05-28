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
    public partial class AjouterOrdonnanceForm : Form
    {
        private int _consultationId;
        private List<(int MedicamentId, string Nom, string Dose)> medicamentsSelectionnes = new List<(int, string, string)>();

        public AjouterOrdonnanceForm(int consultationId)
        {
            InitializeComponent();
            _consultationId = consultationId;
        }

        private void AjouterOrdonnanceForm_Load(object sender, EventArgs e)
        {
            ChargerMedicaments();
        }

        private void ChargerMedicaments()
        {
            using (var context = new CabinetMedicalContext())
            {
                var medicaments = context.Medicaments
                    .Select(m => new
                    {
                        m.Id,
                        m.Nom,
                        Categorie = m.Categorie.Nom, // Récupérer le nom de la catégorie
                        m.Description
                    })
                    .ToList();

                dgvMedicaments.DataSource = medicaments;

                // Renommer les en-têtes du DataGridView pour plus de clarté
                dgvMedicaments.Columns["Id"].Visible = false; // cacher l'ID
                dgvMedicaments.Columns["Nom"].HeaderText = "Nom du Médicament";
                dgvMedicaments.Columns["Categorie"].HeaderText = "Catégorie";
                dgvMedicaments.Columns["Description"].HeaderText = "Description";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblRecherche_Click(object sender, EventArgs e)
        {

        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string recherche = txtRecherche.Text.Trim();
            using (var context = new CabinetMedicalContext())
            {
                var medicaments = context.Medicaments
                    .Where(m => m.Nom.Contains(recherche))
                    .Select(m => new
                    {
                        m.Id,
                        m.Nom,
                        Categorie = m.Categorie.Nom,
                        m.Description
                    })
                    .ToList();

                dgvMedicaments.DataSource = medicaments;

                dgvMedicaments.Columns["Id"].Visible = false;
                dgvMedicaments.Columns["Nom"].HeaderText = "Nom du Médicament";
                dgvMedicaments.Columns["Categorie"].HeaderText = "Catégorie";
                dgvMedicaments.Columns["Description"].HeaderText = "Description";
            }
        }

        private void dgvMedicaments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblDose_Click(object sender, EventArgs e)
        {

        }

        private void txtDose_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouterMedicament_Click(object sender, EventArgs e)
        {
            if (dgvMedicaments.CurrentRow != null && !string.IsNullOrWhiteSpace(txtDose.Text))
            {
                int medicamentId = (int)dgvMedicaments.CurrentRow.Cells["Id"].Value;
                string medicamentNom = dgvMedicaments.CurrentRow.Cells["Nom"].Value.ToString();
                string dose = txtDose.Text.Trim();

                medicamentsSelectionnes.Add((medicamentId, medicamentNom, dose));
                lstMedicamentsAjoutes.Items.Add($"{medicamentNom} - {dose}");
                txtDose.Clear(); // Réinitialiser le champ de dose
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un médicament et entrer une dose.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstMedicamentsAjoutes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEnregistrerOrdonnance_Click(object sender, EventArgs e)
        {
            if (medicamentsSelectionnes.Count == 0)
            {
                MessageBox.Show("Ajoutez au moins un médicament avant d'enregistrer l'ordonnance.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new CabinetMedicalContext())
            {
                var ordonnance = new Ordonnance
                {
                    ConsultationId = _consultationId
                };
                context.Ordonnances.Add(ordonnance);
                context.SaveChanges();

                foreach (var med in medicamentsSelectionnes)
                {
                    var medicamentOrdonnance = new MedicamentOrdonnance
                    {
                        OrdonnanceId = ordonnance.Id,
                        MedicamentId = med.MedicamentId,
                        Dose = med.Dose
                    };
                    context.MedicamentOrdonnances.Add(medicamentOrdonnance);
                }

                context.SaveChanges();
                lblMessage.Text = "Ordonnance enregistrée avec succès !";
                lblMessage.ForeColor = System.Drawing.Color.Green;

                // Vider le panier après enregistrement
                medicamentsSelectionnes.Clear();
                lstMedicamentsAjoutes.Items.Clear();
            }
        }


        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
