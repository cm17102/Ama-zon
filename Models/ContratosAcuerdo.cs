using System;
using System.Collections.Generic;

namespace Ama_zon.Models;

public partial class ContratosAcuerdo
{
    public int Pivoteid { get; set; }

    public virtual ICollection<Acuerdo> Acuerdos { get; set; } = new List<Acuerdo>();

    public virtual ICollection<Contrato> Contratos { get; set; } = new List<Contrato>();
}
