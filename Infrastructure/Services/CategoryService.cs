﻿using Infrastructure.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace Infrastructure.Services;

public class CategoryService(HttpClient http, IConfiguration configuration)
{
    private readonly HttpClient _http = http;
    private readonly IConfiguration _configuration = configuration;

    public async Task<IEnumerable<CategoryModel>> GetCategoriesAsync()
    {
        try
        {
            HttpResponseMessage response = await _http.GetAsync($"https://localhost:7283/api/categories?key={_configuration["ApiKey"]}");
            if(response.IsSuccessStatusCode)
            {
                IEnumerable<CategoryModel> categories = JsonConvert.DeserializeObject<IEnumerable<CategoryModel>>(await response.Content.ReadAsStringAsync())!;
                return categories;
            }
            return null!;
        }
        catch { }
        return null!;
    }
}
