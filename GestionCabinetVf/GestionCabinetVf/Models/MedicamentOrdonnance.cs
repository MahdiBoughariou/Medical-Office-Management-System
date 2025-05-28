using System;
using System.Collections.Generic;

namespace GestionCabinetVf.Models;

public partial class MedicamentOrdonnance
{
    public int Id { get; set; }

    public int OrdonnanceId { get; set; }

    public int MedicamentId { get; set; }

    public string? Dose { get; set; }

    public virtual Medicament Medicament { get; set; } = null!;

    public virtual Ordonnance Ordonnance { get; set; } = null!;
}
