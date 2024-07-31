using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace IjsOpReis.Data.Entities;

public class Distance
{
    [Key]
    public int Id { get; set; }

    public DateTime StartedAt { get; set; }

    public DateTime EndedAt { get; set; }

    public int Kilometers { get; set; }

    public double AmountOfDays => (EndedAt - StartedAt).TotalDays + 1;
}
