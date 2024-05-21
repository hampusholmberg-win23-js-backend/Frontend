using Newtonsoft.Json;

namespace Frontend.Components.Models.GraphQL;

public class Data
{
    [JsonProperty("GetCourses")]
    public List<CourseModel>? GetCourses { get; set; }

    public CourseModel? GetCourseById {  get; set; }
}
