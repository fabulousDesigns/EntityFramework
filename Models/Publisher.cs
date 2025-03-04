using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Models;

public class Publisher
{
    [Key]
    public int PublisherId { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; }

    [MaxLength(50)]
    public string Location { get; set; }
}