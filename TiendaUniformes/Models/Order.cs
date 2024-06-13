using System;
using System.Collections.Generic;

namespace TiendaUniformesAPI.Models;

public partial class Order : BaseEntity
{
    public int idO { get; set; }

    public DateOnly dateOrder { get; set; }

    public DateOnly deadLine { get; set; }

    public int idC { get; set; }

    public decimal totalPrice { get; set; }
}
