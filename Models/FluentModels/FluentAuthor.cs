namespace EntityFramework.Models.FluentModels;

public class FluentAuthor
{
    public int AuthorId { get; set; }
    
    public string? FirstName { get; set; }
    
    public int LastName { get; set; }

    public DateTime? BirthDate { get; set; }
    
    public string? Location { get; set; }
    
    public string FullName => $"{FirstName} {LastName}";

    public List<FluentBook>? Books { get; set; }
}