using System;
using System.Collections.Generic;

namespace AAMG.AppMVC.Models;

public partial class Mascota
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Tipo { get; set; }

    public string? Raza { get; set; }

    public int? Edad { get; set; }

    public string? Dueño { get; set; }

    public string? Antecedentes { get; set; }
}
