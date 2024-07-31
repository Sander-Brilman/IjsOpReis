using IjsOpReis.Extentions;
using System.ComponentModel.DataAnnotations;

namespace IjsOpReis.Data.Entities;

public class IcecreamRecord
{
    [Key]
    public int Id { get; set; }

    [Required]
    public required string Flavor { get; set; }
    
    [Required]
    public required string Location { get; set; }

    [Required]
    public required string Shop { get; set; }

    [Required]
    public decimal Amount { get; set; }

    public DateTime EatenAt { get; set; } = DateTimeExtentions.GetCurrentNlTime();
}

