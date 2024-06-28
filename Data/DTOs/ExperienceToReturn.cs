using System.Text.Json.Serialization;
namespace Portfolio;
public class ExperienceToReturn
{
    public required string Title {get; set;}
    public required string Resume {get; set;}
    public required string Description {get; set;}
    public string? ImagePath {get;set;}
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ExperienceSkillEnum Skill {get; set;}
}