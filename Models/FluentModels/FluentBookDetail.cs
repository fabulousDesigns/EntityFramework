namespace EntityFramework.Models.FluentModels;

public class FluentBookDetail
{
   
    public int BookDetailId { get; set; }

    
    public int NumberOfChapters { get; set; }

    public int NumberOfPages { get; set; }

    public string? Weight { get; set; }

    public int BookId { get; set; }
    public FluentBook? Book { get; set; }

}