using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCabinetVf.Models
{
    internal class ConsultationDetail
    {
        public int ConsultationId { get; set; }
        public DateTime? DateConsultation { get; set; }
        public string NomPatient { get; set; }
        public string PrenomPatient { get; set; }
        public string QuestionsReponses { get; set; }
        public string Maladie { get; set; }
        public string Remarques { get; set; }
        public List<string> Medicaments { get; set; }
    }
}
