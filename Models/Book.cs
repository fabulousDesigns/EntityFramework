using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework.Models;

public class Book
{
    [Key]
    public int BookId { get; set; }

    [Required]
    [MaxLength(50)]
    public string? Title { get; set; }

    [MaxLength(13)]
    public string? ISBN { get; set; }

    public decimal? Price { get; set; }

    public BookDetail? BookDetail { get; set; }

    [ForeignKey("Publisher")]
    public int PublisherId { get; set; }

    public Publisher? Publisher { get; set; }

    public List<Author> Authors { get; set; }
}