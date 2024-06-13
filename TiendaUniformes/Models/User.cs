using System;
using System.Collections.Generic;

namespace TiendaUniformesAPI.Models;

public partial class User
{
    public int idU { get; set; }

    public string userName { get; set; } = null!;

    public string email { get; set; } = null!;

    public string pass { get; set; } = null!;

    public bool isActive { get; set; }
}