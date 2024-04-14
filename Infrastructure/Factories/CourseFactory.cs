﻿using Infrastructure.Entities;
using Infrastructure.Models;

namespace Infrastructure.Factories;

public class CourseFactory
{
    public static CourseEntity Create(CourseModel model)
    {
        return new CourseEntity
        {
            Title = model.Title,
            ImageName = model.ImageName,
            Price = model.Price,
            DiscountPrice = model.DiscountPrice,
            Hours = model.Hours,
            IsBestseller = model.IsBestseller,
            LikesInNumbers = model.LikesInNumbers,
            LikesInPercent = model.LikesInPercent,
            Author = model.Author
        };
    }
}