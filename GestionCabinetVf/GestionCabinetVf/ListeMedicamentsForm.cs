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
    public partial class ListeMedicamentsForm : Form
    {
        public ListeMedicamentsForm()
        {
            InitializeComponent();
            ChargerMedicaments(); // Charger tous les médicaments au début
        }

        private void ChargerMedicaments(string recherche = "")
        {
            using (var context = new CabinetMedicalContext())
            {
                var medicaments = context.Medicaments
                    .Where(m => string.IsNullOrEmpty(recherche) ||
                                m.Nom.Contains(recherche))
                    .Select(m => new
                    {
                        m.Id,
                        m.Nom,
                        m.Description,
                        CategorieNom = m.Categorie.Nom // <-- On récupère aussi le nom de la catégorie
                    })
                    .ToList();

                dgvMedicaments.DataSource = medicaments;
                dgvMedicaments.Columns["Id"].Visible = false; // Cacher l'ID
                dgvMedicaments.Columns["CategorieNom"].HeaderText = "Catégorie"; // Renommer l'en-tête proprement
            }
        }


        private void lblListeMedicaments_Click(object sender, EventArgs e)
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
            ChargerMedicaments(recherche);
        }

        private void dgvMedicaments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvMedicaments.SelectedRows.Count > 0)
            {
                // Récupérer l'ID du médicament sélectionné
                int medicamentId = Convert.ToInt32(dgvMedicaments.SelectedRows[0].Cells["Id"].Value);

                // Ouvrir le formulaire de modification avec l'ID du médicament
                ModifierMedicamentForm modifierForm = new ModifierMedicamentForm(medicamentId);
                modifierForm.ShowDialog(); // Ouvre en modal

                // Après la modification, recharger les médicaments
                ChargerMedicaments();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un médicament à modifier.");
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvMedicaments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un médicament à supprimer.");
                return;
            }

            int medicamentId = (int)dgvMedicaments.SelectedRows[0].Cells["Id"].Value;

            var confirmResult = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce médicament ?",
                                                 "Confirmation",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                using (var context = new CabinetMedicalContext())
                {
                    var medicament = context.Medicaments.Find(medicamentId);
                    if (medicament != null)
                    {
                        context.Medicaments.Remove(medicament);
                        context.SaveChanges();
                    }
                }

                ChargerMedicaments(); // Rafraîchir la liste
            }
        }
    }
}
