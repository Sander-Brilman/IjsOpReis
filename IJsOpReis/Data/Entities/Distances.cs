using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace IJsOpReis.Data.Entities;

public class Distance
{
    [Key]
    public int Id { get; set; }

    public DateTime StartedAt { get; set; } = DateTime.UtcNow;

    public DateTime EndedAt { get; set; } = DateTime.UtcNow;

    public int Kilometers { get; set; }

    public double AmountOfDays => (EndedAt - StartedAt).TotalDays + 1;
}
