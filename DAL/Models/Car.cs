using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Car
{
    public int CarId { get; set; }

    public int? OwnerId { get; set; }

    public string? Make { get; set; }

    public string? Model { get; set; }

    public int? Year { get; set; }

    public virtual Person? Owner { get; set; }
}
