using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio;
public class Experience
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Title { get; set; }
    [MaxLength(70)]
    public string Resume { get; set; }
    [MaxLength(230)]
    public string Description { get; set; }
    public string ImagePath {get;set;}
    public string State {get; set;} = "Active";
    public ExperienceSkillEnum Skill { get; set;} = ExperienceSkillEnum.Management;

}