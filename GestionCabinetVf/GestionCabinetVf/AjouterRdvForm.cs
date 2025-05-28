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
    public partial class AjouterRdvForm : Form
    {
        private int _patientId;

        public AjouterRdvForm(int patientId, string nom, string prenom)
        {
            InitializeComponent();
            _patientId = patientId;
            txtPatient.Text = $"{nom} {prenom}";
        }

        private void lblAjouterRdv_Click(object sender, EventArgs e)
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

        private void btnAjouterRdv_Click(object sender, EventArgs e)
        {
            using (var context = new CabinetMedicalContext())
            {
                var rdv = new Rdv
                {
                    PatientId = _patientId,
                    DateRdv = dtpDateRdv.Value
                };

                context.Rdvs.Add(rdv);
                context.SaveChanges();
                MessageBox.Show("Rendez-vous ajouté avec succès.");
                this.Close(); // Fermer la fenêtre après ajout
            }
        }
    }
}
