﻿namespace Frontend.Components.Models;

public class CourseModel
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Ingress { get; set; } = null!;
    public decimal Price { get; set; }
    public int HoursToComplete { get; set; }
    public int LikesPercentage { get; set; }
    public int LikesAmount { get; set; }
    public string? Image { get; set; }


    public string? AuthorName { get; set; }
    public string? AuthorDescription { get; set; }
    public string? AuthorImage { get; set; } = "/images/icons/no-profile-picture.svg";


    public int AuthorYoutubeFollowersQty { get; set; }
    public int AuthorFacebookFollowersQty { get; set; }
}
