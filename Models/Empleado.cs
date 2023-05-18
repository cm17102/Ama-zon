using System;
using System.Collections.Generic;

namespace Ama_zon.Models;

public partial class Empleado
{
    public int Nombre { get; set; }

    public int Correo { get; set; }

    public int Empleadoid { get; set; }

    public int FechaNacimiento { get; set; }

    public int Cargo { get; set; }

    public virtual ICollection<Contrato> Contratos { get; set; } = new List<Contrato>();

    public virtual ICollection<Telefono> Telefonos { get; set; } = new List<Telefono>();
}
