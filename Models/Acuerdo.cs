using System;
using System.Collections.Generic;

namespace Ama_zon.Models;

public partial class Acuerdo
{
    public int Nombre { get; set; }

    public int Contenido { get; set; }

    public int Tipo { get; set; }

    public int Acuerdoid { get; set; }

    public int Paisid { get; set; }

    public int Pivoteid { get; set; }

    public virtual Pai Pais { get; set; } = null!;

    public virtual ContratosAcuerdo Pivote { get; set; } = null!;
}
