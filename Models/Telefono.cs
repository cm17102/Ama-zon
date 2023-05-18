using System;
using System.Collections.Generic;

namespace Ama_zon.Models;

public partial class Telefono
{
    public int Telefonoid { get; set; }

    public int Numero { get; set; }

    public int Sedeid { get; set; }

    public int Empleadoid { get; set; }

    public virtual Empleado Empleado { get; set; } = null!;

    public virtual Sede Sede { get; set; } = null!;
}
