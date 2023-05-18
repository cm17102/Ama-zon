using System;
using System.Collections.Generic;

namespace Ama_zon.Models;

public partial class Sede
{
    public int Nombre { get; set; }

    public int Sedeid { get; set; }

    public int Codigosede { get; set; }

    public int Paisid { get; set; }

    public virtual Pai Pais { get; set; } = null!;

    public virtual ICollection<Telefono> Telefonos { get; set; } = new List<Telefono>();
}
