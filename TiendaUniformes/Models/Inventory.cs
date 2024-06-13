using System;
using System.Collections.Generic;

namespace TiendaUniformesAPI.Models;

public partial class Inventory : BaseEntity
{
    public int idI { get; set; }

    public int idSc { get; set; }

    public int idG { get; set; }

    public int quantitaty { get; set; }
}
