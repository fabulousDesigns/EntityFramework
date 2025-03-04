using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework.Models;

public class Author
{
    [Key]
    public int AuthorId { get; set; }

    [Required]
    [MaxLength(50)]
    public string? FirstName { get; set; }

    [Required]
    public int LastName { get; set; }

    public DateTime? BirthDate { get; set; }

    [MaxLength(50)]
    public string? Location { get; set; }

    [NotMapped]
    public string FullName => $"{FirstName} {LastName}";

    public List<Book> Books { get; set; }
}