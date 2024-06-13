using System;
using System.Collections.Generic;

namespace TiendaUniformesAPI.Models;

public partial class School : BaseEntity
{
    public int idSc { get; set; }

    public string name { get; set; } = null!;
}

public partial class Schools
{
    public List<School>? results { get; set; }
}