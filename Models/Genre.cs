using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework.Models;


[Table("Category")]
public class Category
{
    [Key]
    public int CategoryId { get; set; }

    [Required]
    [Column("Name")]
    [StringLength(50)]
    public string? CategoryName { get; set; }

    public int DisplayOrder { get; set; }
}