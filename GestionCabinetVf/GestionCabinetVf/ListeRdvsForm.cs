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
    public partial class ListeRdvsForm : Form
    {
        public ListeRdvsForm()
        {
            InitializeComponent();
            ChargerRdvs(); // Charger tous les RDVs au lancement
        }

        private void ChargerRdvs(string recherche = "")
        {
            using (var context = new CabinetMedicalContext())
            {
                var rdvs = context.Rdvs
                    .Where(r => string.IsNullOrEmpty(recherche) ||
                                r.Patient.Nom.Contains(recherche) ||
                                r.Patient.Prenom.Contains(recherche) ||
                                r.DateRdv.ToString().Contains(recherche))
                    .Select(r => new
                    {
                        r.Id,
                        Nom = r.Patient.Nom,
                        Prenom = r.Patient.Prenom,
                        DateRendezVous = r.DateRdv
                    })
                    .ToList();

                dgvListeRdvs.DataSource = rdvs;
                dgvListeRdvs.Columns["Id"].Visible = false;
            }
        }

        private void lblListeRdvs_Click(object sender, EventArgs e)
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
            ChargerRdvs(recherche);
        }

        private void dgvListeRdvs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvListeRdvs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un rendez-vous à modifier.");
                return;
            }

            int rdvId = (int)dgvListeRdvs.SelectedRows[0].Cells["Id"].Value;

            ModifierRdvForm modifierForm = new ModifierRdvForm(rdvId);
            modifierForm.ShowDialog();

            ChargerRdvs(); // Recharger après modification
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvListeRdvs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un rendez-vous à supprimer.");
                return;
            }

            int rdvId = (int)dgvListeRdvs.SelectedRows[0].Cells["Id"].Value;

            var confirm = MessageBox.Show("Confirmez-vous la suppression ?", "Confirmation", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                using (var context = new CabinetMedicalContext())
                {
                    var rdv = context.Rdvs.Find(rdvId);
                    if (rdv != null)
                    {
                        context.Rdvs.Remove(rdv);
                        context.SaveChanges();
                    }
                }

                ChargerRdvs(); // Rafraîchir la liste
            }
        }

    }
}
