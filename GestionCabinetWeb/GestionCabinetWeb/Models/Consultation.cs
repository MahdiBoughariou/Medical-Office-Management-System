using System;
using System.Collections.Generic;

namespace GestionCabinetWeb.Models;

public partial class Consultation
{
    public int Id { get; set; }

    public int PatientId { get; set; }

    public DateTime? DateConsultation { get; set; }

    public string? QuestionsReponses { get; set; }

    public string? Maladie { get; set; }

    public string? Remarques { get; set; }

    public virtual ICollection<Ordonnance> Ordonnances { get; set; } = new List<Ordonnance>();

    public virtual Patient Patient { get; set; } = null!;
}
