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
    public partial class AjouterMedicamentForm : Form
    {
        public AjouterMedicamentForm()
        {
            InitializeComponent();
            this.Load += AjouterMedicamentForm_Load;
        }

        private void AjouterMedicamentForm_Load(object sender, EventArgs e)
        {
            // Charger les catégories dans la ComboBox au chargement du formulaire
            using (var context = new CabinetMedicalContext())
            {
                var categories = context.Categories
                    .Select(c => new { c.Id, c.Nom })
                    .ToList();

                cmbCategorie.DataSource = categories;
                cmbCategorie.DisplayMember = "Nom";
                cmbCategorie.ValueMember = "Id";
            }
        }

        private void lblAjouterMedicament_Click(object sender, EventArgs e)
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

        private void btnAjouterMedicament_Click(object sender, EventArgs e)
        {
            // Vérifier que tous les champs sont remplis
            if (string.IsNullOrWhiteSpace(txtNom.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                cmbCategorie.SelectedValue == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new CabinetMedicalContext())
            {
                // Créer un nouveau médicament
                var medicament = new Medicament
                {
                    Nom = txtNom.Text,
                    Description = txtDescription.Text,
                    CategorieId = (int)cmbCategorie.SelectedValue
                };

                context.Medicaments.Add(medicament);
                context.SaveChanges();

                lblMessage.Text = "Médicament ajouté avec succès !";

                // Vider les champs après l'ajout
                txtNom.Clear();
                txtDescription.Clear();
                cmbCategorie.SelectedIndex = 0;
            }
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
