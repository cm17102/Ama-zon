using System;
using System.Collections.Generic;

namespace Ama_zon.Models;

public partial class Direccion
{
    public int Zip { get; set; }

    public int Calle { get; set; }

    public int Direccionid { get; set; }

    public int Direccion1 { get; set; }

    public int Sedeid { get; set; }

    public int Empleadoid { get; set; }

    public virtual Empleado Empleado { get; set; } = null!;

    public virtual Sede Sede { get; set; } = null!;
}
