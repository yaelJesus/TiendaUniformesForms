using System;
using System.Collections.Generic;

namespace TiendaUniformes.Models;

public partial class Customer : BaseEntity
{
    public int idC { get; set; }

    public string name { get; set; } = null!;

    public string phone { get; set; } = null!;
}
