using System;
using System.Collections.Generic;

namespace MVCCRUD2.Models;

public partial class Usuario : Persona
{
    public virtual Persona IdPersonaNavigation { get; set; } = null!;
}
