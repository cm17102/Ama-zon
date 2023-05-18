using System;
using System.Collections.Generic;

namespace Ama_zon.Models;

public partial class Pai
{
    public int Nombre { get; set; }

    public int Paisid { get; set; }

    public int Isoalfa2 { get; set; }

    public int Idioma { get; set; }

    public virtual ICollection<Acuerdo> Acuerdos { get; set; } = new List<Acuerdo>();

    public virtual ICollection<Sede> Sedes { get; set; } = new List<Sede>();
}
