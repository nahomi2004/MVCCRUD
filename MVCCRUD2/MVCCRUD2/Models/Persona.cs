using System;
using System.Collections.Generic;

namespace MVCCRUD2.Models;

public partial class Persona
{
    public int IdPersona { get; set; }

    public string? Apellido { get; set; }

    public string? Nombre { get; set; }

    public string? Cel { get; set; }

    public string? Email { get; set; }

    public string? Direcc { get; set; }

    public string? Contrasenia { get; set; }

    public string? Rol { get; set; }

    public virtual Administrador? Administrador { get; set; }

    public virtual Usuario? Usuario { get; set; }
}
