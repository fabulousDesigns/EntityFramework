namespace EntityFramework.Models.FluentModels;

public class FluentPublisher
{
    public int PublisherId { get; set; }
    
    public string? Name { get; set; }
    
    public string? Location { get; set; }

    public List<FluentBook>? Books { get; set; }
}