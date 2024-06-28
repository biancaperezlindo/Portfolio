namespace Portfolio;
public class ExperienceToAdd
{
    public required string Title { get; set; }
    public string? Resume { get; set; }
    public string? Description { get; set; }
    public string? ImagePath {get;set;}
    public ExperienceSkillEnum Skill {get;set;}
}