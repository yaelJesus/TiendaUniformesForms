using System;
using System.Collections.Generic;

namespace TiendaUniformes.Models;

public partial class Garment : BaseEntity
{
    public int idG { get; set; }

    public string type { get; set; } = null!;

    public string? desctiption { get; set; }

    public int idS { get; set; }

    public int idSc { get; set; }
}
