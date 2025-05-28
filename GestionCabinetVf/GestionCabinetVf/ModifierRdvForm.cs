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
    public partial class ModifierRdvForm : Form
    {
        private int _rdvId;

        public ModifierRdvForm(int rdvId)
        {
            InitializeComponent();
            _rdvId = rdvId;

            using (var context = new CabinetMedicalContext())
            {
                var rdv = context.Rdvs
                                 .Where(r => r.Id == rdvId)
                                 .Select(r => new {
                                     r.DateRdv,
                                     Nom = r.Patient.Nom,
                                     Prenom = r.Patient.Prenom
                                 }).FirstOrDefault();

                if (rdv != null)
                {
                    txtPatient.Text = $"{rdv.Nom} {rdv.Prenom}";
                    dtpDateRdv.Value = rdv.DateRdv;
                }
            }
        }

        private void lblModifierRdv_Click(object sender, EventArgs e)
        {

        }

        private void lblPatient_Click(object sender, EventArgs e)
        {

        }

        private void txtPatient_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void dtpDateRdv_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            using (var context = new CabinetMedicalContext())
            {
                var rdv = context.Rdvs.Find(_rdvId);
                if (rdv != null)
                {
                    rdv.DateRdv = dtpDateRdv.Value;
                    context.SaveChanges();
                    MessageBox.Show("Rendez-vous mis à jour avec succès !");
                    this.Close();
                }
            }
        }
    }
}
