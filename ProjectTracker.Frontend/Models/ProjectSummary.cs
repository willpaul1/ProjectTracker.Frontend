namespace ProjectTracker.Frontend.Models;

public class ProjectSummary
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public required string Language { get; set; }

    public required string Level { get; set; }

    public DateOnly CompletionDate { get; set; }

}
