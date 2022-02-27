using System.ComponentModel.DataAnnotations;

namespace backend.Models;

public class Option
{

    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string? Title { get; set; }

    public int Votes { get; set; }
}