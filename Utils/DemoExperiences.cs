using Microsoft.AspNetCore.Components.Web;

namespace Portfolio;
public static class DemoExperiences
{
    public static List<Experience> Experiences { get; set; } = new() 
    {
        new Experience(){Id=1, Title="Title1", Resume="this is a Resume of the Title1", Description="First Experience"},
        new Experience(){Id=2, Title="Title2", Resume="this is a Resume of the Title2", Description="Second Experience"},
        new Experience(){Id=3, Title="Title3", Resume="this is a Resume of the Title3", Description="Third Experience"},
        new Experience(){Id=4, Title="Title4", Resume="this is a Resume of the Title4", Description="Fourth Experience"}

    };
}