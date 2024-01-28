using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Person
{
    public int PersonId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? ContactInfo { get; set; }

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();

    public virtual ICollection<ChargingStation> ChargingStations { get; set; } = new List<ChargingStation>();
}
