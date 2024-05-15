//using Infrastructure.Models;

//using Infrastructure.Models;
namespace Frontend.Components.Models;

public class CoursesIndexViewModel
{
    public string Title { get; set; } = "";
    public List<CourseViewModel> Courses { get; set; } = null!;
    //public IEnumerable<CategoryViewModel> Categories { get; set; } = null!;
    //public AccountViewModel Account { get; set; } = null!;
    //public Pagination? Pagination { get; set; }
    //public string? CourseCategory { get; set; }
    //public string? SearchQuery { get; set; }
}
