using GestionCabinetVf.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class ListeConsultationsForm : Form
    {
        private CabinetMedicalContext _context = new CabinetMedicalContext();
        private List<ConsultationDetail> _consultations = new List<ConsultationDetail>();

        public ListeConsultationsForm()
        {
            InitializeComponent();
            ChargerConsultations();
        }

        private void ChargerConsultations(string searchName = "")
        {
            _consultations = _context.Consultations
                .Include(c => c.Patient)
                .Include(c => c.Ordonnances)
                    .ThenInclude(o => o.MedicamentOrdonnances)
                        .ThenInclude(mo => mo.Medicament)
                .OrderByDescending(c => c.DateConsultation)
                .Where(c => string.IsNullOrEmpty(searchName) || c.Patient.Nom.Contains(searchName))
                .Select(c => new ConsultationDetail
                {
                    ConsultationId = c.Id,
                    DateConsultation = c.DateConsultation,
                    NomPatient = c.Patient.Nom,
                    PrenomPatient = c.Patient.Prenom,
                    QuestionsReponses = c.QuestionsReponses,
                    Maladie = c.Maladie,
                    Remarques = c.Remarques,
                    Medicaments = c.Ordonnances
                        .SelectMany(o => o.MedicamentOrdonnances)
                        .Select(mo => $"{mo.Medicament.Nom} ({mo.Dose})")
                        .ToList()
                })
                .ToList();

            dgvConsultations.DataSource = _consultations
                .Select(c => new
                {
                    c.DateConsultation,
                    Patient = $"{c.NomPatient} {c.PrenomPatient}",
                    c.QuestionsReponses,
                    c.Maladie,
                    c.Remarques,
                    Medicaments = string.Join(", ", c.Medicaments)
                })
                .ToList();
        }

        private void lblListeConsultations_Click(object sender, EventArgs e)
        {

        }

        private void lblRecherche_Click(object sender, EventArgs e)
        {

        }

        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            ChargerConsultations(txtRechercher.Text);
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {

        }

        private void dgvConsultations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
