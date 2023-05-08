using Microsoft.Build.Framework;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace AAMG.AppMVC.Models;

public partial class Mascota
{
    public int Id { get; set; }
    [System.ComponentModel.DataAnnotations.Required] public string? Nombre { get; set; }
    public string? Tipo { get; set; }


    public string? Raza { get; set; }

    public int? Edad { get; set; }

    [System.ComponentModel.DataAnnotations.Required] public string? Dueño { get; set; }

    public string? Antecedentes { get; set; }
}
