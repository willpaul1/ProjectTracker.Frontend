using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ProjectTracker.Frontend.Converters;

namespace ProjectTracker.Frontend.Models;

public class ProjectDetails
{
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public required string Name { get; set; }

    [Required (ErrorMessage = "Please enter a language.")]
    [JsonConverter(typeof(StringConverter))]
    public string? LanguageId { get; set; }

    [Required]
    public string? Level { get; set; }

    public DateOnly CompletionDate { get; set; }

}
