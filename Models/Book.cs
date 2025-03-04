using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Models;

public class Book
{
    [Key]
    public int BookId { get; set; }
    public string? Title { get; set; }
    public string? ISBN { get; set; }
    public double? Price { get; set; }
}