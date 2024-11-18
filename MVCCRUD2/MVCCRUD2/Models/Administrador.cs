using System;
using System.Collections.Generic;

namespace MVCCRUD2.Models;

public partial class Administrador : Persona
{
    public string? Cdl { get; set; }

    public virtual Persona IdPersonaNavigation { get; set; } = null!;
}
