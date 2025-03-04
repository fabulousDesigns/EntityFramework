using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Models;

public class Book
{
    [Key]
    public int BookId { get; set; }

    [StringLength(50)]
    public string? Title { get; set; }

    [StringLength(13)]
    public string? ISBN { get; set; }

    public decimal? Price { get; set; }
}