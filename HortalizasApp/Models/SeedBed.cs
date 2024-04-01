using System.ComponentModel.DataAnnotations;

namespace HortalizasApp.Models;

public class SeedBed
{
    [Key]
    public string Id { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    [Required]
    public int SeedsPlanted { get; set; }
}