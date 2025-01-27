﻿namespace Infrastructure_Api.Entities;

public class CourseEntity
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string? ImageName{ get; set; }
    public string? Price { get; set; }
    public string? DiscountPrice { get; set; }
    public string? Hours { get; set; }
    public bool IsBestseller { get; set; }
    public string? LikesInNumbers { get; set; }
    public string? LikesInPercent { get; set; }
    public string? Author { get; set; }

    public int? CategoryId { get; set; }
    public CategoryEntity? Category { get; set; }
}
