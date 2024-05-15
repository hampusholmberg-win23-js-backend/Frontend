//using Infrastructure.Models;

//using Infrastructure.Models;
using Frontend.Components.Pages.Courses;

namespace Frontend.Components.Pages.Courses;

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
