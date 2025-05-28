using System;
using System.Collections.Generic;

namespace GestionCabinetWeb.Models;

public partial class Patient
{
    public int Id { get; set; }

    public string Nom { get; set; } = null!;

    public string Prenom { get; set; } = null!;

    public DateOnly DateNaissance { get; set; }

    public string? Adresse { get; set; }

    public string? Telephone { get; set; }

    public virtual ICollection<Consultation> Consultations { get; set; } = new List<Consultation>();

    public virtual ICollection<Rdv> Rdvs { get; set; } = new List<Rdv>();
}
