using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class ChargingStation
{
    public int ChargingStationId { get; set; }

    public int? OwnerId { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public virtual Person? Owner { get; set; }
}
