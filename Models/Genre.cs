using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Models;

public class Genre
{
    [Key]
    public int GenreId { get; set; }

    [StringLength(50)]
    public string? GenreName { get; set; }

    public int Display { get; set; }
}