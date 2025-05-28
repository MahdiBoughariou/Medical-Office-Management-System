using System;
using System.Collections.Generic;

namespace GestionCabinetVf.Models;

public partial class Utilisateur
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string Role { get; set; } = null!;
}
