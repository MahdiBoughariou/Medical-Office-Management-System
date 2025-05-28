using System;
using System.Collections.Generic;

namespace GestionCabinetVf.Models;

public partial class Categorie
{
    public int Id { get; set; }

    public string Nom { get; set; } = null!;

    public virtual ICollection<Medicament> Medicaments { get; set; } = new List<Medicament>();
}
