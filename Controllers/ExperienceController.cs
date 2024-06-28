using Microsoft.AspNetCore.Mvc;
using Portfolio;
using Portfolio.Data;
using Swashbuckle.AspNetCore;

namespace Controllers;

[ApiController]
[Route("api/Experience")]

public class ExperienceController : ControllerBase
{
    private readonly ExperienceRepository _repo;
    public ExperienceController(ExperienceRepository repo)
    {
        _repo = repo;
    }

    [HttpGet]
    public ActionResult Get()
    {
        return Ok(_repo.GetAll());
    }
    
    [HttpGet("{idExperience}")]
    public ActionResult Get(int idExperience)
    {
        var experienceToReturn = _repo.Get(idExperience);
        return Ok(experienceToReturn);
    }

    [HttpGet("search")]
    public ActionResult GetByTitleOrResume([FromQuery]string searchCriteria)
    {
        return Ok(_repo.GetAll().Where(a => a.Resume.Contains(searchCriteria) || a.Title.Contains(searchCriteria)).ToList());
    }
    
    [HttpDelete("{id}")]
    public ActionResult DeleteExperience(int id)
    {
        return Ok(_repo.Delete(id));
    }

    [HttpPut("{id}")]
    public ActionResult Put(int id, [FromBody] ExperienceToUpdate body)
    {
        var experienceToReturn = DemoExperiences.Experiences.First(a => a.Id == id);
        experienceToReturn.Resume = body.Resume;
        experienceToReturn.Description = body.Description;
        experienceToReturn.ImagePath = body.ImagePath;
        experienceToReturn.Skill = body.Skill;
        _repo.AddExperience(experienceToReturn);
        return Ok();
    }

    [HttpPost]
    public ActionResult AddExperience([FromBody] ExperienceToAdd body)
    {
        var newExperience = new Experience()
        {
            Title = body.Title,
            Resume = body.Resume,
            Description = body.Description,
            ImagePath = body.ImagePath,
            Skill = body.Skill,
        }; 
        return Ok(_repo.AddExperience(newExperience));
    }
}