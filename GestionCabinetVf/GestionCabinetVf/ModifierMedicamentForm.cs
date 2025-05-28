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
    public partial class ModifierMedicamentForm : Form
    {
        private int medicamentId; // Variable pour stocker l'ID du médicament

        public ModifierMedicamentForm(int id)
        {
            InitializeComponent();
            medicamentId = id; // On récupère l'ID
            ChargerCategories(); // Charger toutes les catégories
            ChargerMedicament(); // Charger les informations du médicament
        }

        // Charger toutes les catégories dans la liste déroulante
        private void ChargerCategories()
        {
            using (var context = new CabinetMedicalContext())
            {
                var categories = context.Categories.ToList();
                cmbCategorie.DataSource = categories;
                cmbCategorie.DisplayMember = "Nom"; // Afficher le nom de la catégorie
                cmbCategorie.ValueMember = "Id"; // La valeur sera l'Id
            }
        }

        // Charger les informations du médicament sélectionné
        private void ChargerMedicament()
        {
            using (var context = new CabinetMedicalContext())
            {
                var medicament = context.Medicaments.SingleOrDefault(m => m.Id == medicamentId);
                if (medicament != null)
                {
                    txtNom.Text = medicament.Nom;
                    txtDescription.Text = medicament.Description;
                    if (medicament.CategorieId.HasValue)
                    {
                        cmbCategorie.SelectedValue = medicament.CategorieId.Value; // Sélectionner la bonne catégorie
                    }
                }
                else
                {
                    MessageBox.Show("Médicament non trouvé.");
                    this.Close(); // Fermer si on ne trouve pas
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

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCategorie_Click(object sender, EventArgs e)
        {

        }

        private void cmbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Sauvegarder les modifications du médicament
        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            using (var context = new CabinetMedicalContext())
            {
                var medicament = context.Medicaments.SingleOrDefault(m => m.Id == medicamentId);
                if (medicament != null)
                {
                    medicament.Nom = txtNom.Text;
                    medicament.Description = txtDescription.Text;
                    medicament.CategorieId = (int)cmbCategorie.SelectedValue; // Mettre à jour la catégorie correctement

                    context.SaveChanges(); // Sauvegarder dans la base
                    MessageBox.Show("Les informations du médicament ont été mises à jour.");

                    this.Close(); // Fermer le formulaire
                }
                else
                {
                    MessageBox.Show("Médicament non trouvé.");
                }
            }
        }
    }
}
