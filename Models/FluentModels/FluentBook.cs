namespace EntityFramework.Models.FluentModels;

public class FluentBook
{
    public int BookId { get; set; }

    public string? Title { get; set; }

    public string? ISBN { get; set; }

    public decimal? Price { get; set; }

    public FluentBookDetail? BookDetail { get; set; }
   
    public int PublisherId { get; set; }
    
    public FluentPublisher? Publisher { get; set; }
    
    public List<FluentAuthor> Authors { get; set; }
}