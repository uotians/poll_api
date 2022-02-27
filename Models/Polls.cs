using System.ComponentModel.DataAnnotations;

namespace backend.Models;

public class Poll
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string? Title { get; set; }

    public ICollection<Option>? Options { get; set; }
}