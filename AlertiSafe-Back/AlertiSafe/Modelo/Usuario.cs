using System;
using System.Collections.Generic;

namespace AlertiSafe.Modelo;

public partial class Usuario
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Email { get; set; } = null!;
    
    public string contrasenia { get; set; } = null!;
}
