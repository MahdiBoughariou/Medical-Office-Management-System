using System;
using System.Collections.Generic;

namespace GestionCabinetWeb.Models;

public partial class Rdv
{
    public int Id { get; set; }

    public int PatientId { get; set; }

    public DateTime DateRdv { get; set; }

    public virtual Patient Patient { get; set; } = null!;
}
