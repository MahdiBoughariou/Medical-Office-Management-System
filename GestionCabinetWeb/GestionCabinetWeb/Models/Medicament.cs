using System;
using System.Collections.Generic;

namespace GestionCabinetWeb.Models;

public partial class Medicament
{
    public int Id { get; set; }

    public string Nom { get; set; } = null!;

    public int? CategorieId { get; set; }

    public string? Description { get; set; }

    public virtual Categorie? Categorie { get; set; }

    public virtual ICollection<MedicamentOrdonnance> MedicamentOrdonnances { get; set; } = new List<MedicamentOrdonnance>();
}
