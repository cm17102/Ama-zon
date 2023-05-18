using System;
using System.Collections.Generic;

namespace Ama_zon.Models;

public partial class Contrato
{
    public int FechaInicio { get; set; }

    public int FechaFin { get; set; }

    public int Tipo { get; set; }

    public int Contratoid { get; set; }

    public int Empleadoid { get; set; }

    public int Pivoteid { get; set; }

    public virtual Empleado Empleado { get; set; } = null!;

    public virtual ContratosAcuerdo Pivote { get; set; } = null!;
}
