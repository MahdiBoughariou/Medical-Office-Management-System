using System;
using System.Collections.Generic;

namespace GestionCabinetVf.Models;

public partial class Ordonnance
{
    public int Id { get; set; }

    public int ConsultationId { get; set; }

    public virtual Consultation Consultation { get; set; } = null!;

    public virtual ICollection<MedicamentOrdonnance> MedicamentOrdonnances { get; set; } = new List<MedicamentOrdonnance>();
}
