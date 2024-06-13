using System;
using System.Collections.Generic;

namespace TiendaUniformesAPI.Models;

public partial class OrderDetail : BaseEntity
{
    public int idOd { get; set; }

    public int idO { get; set; }

    public int idG { get; set; }

    public int quantitaty { get; set; }
}
