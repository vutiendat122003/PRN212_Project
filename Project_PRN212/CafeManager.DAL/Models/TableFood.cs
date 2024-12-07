using System;
using System.Collections.Generic;

namespace CafeManager.DAL.Models;

public partial class TableFood
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool Status { get; set; }

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();
}
