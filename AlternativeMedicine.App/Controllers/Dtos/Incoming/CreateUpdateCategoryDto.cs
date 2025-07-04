﻿using AlternativeMedicine.App.Domain.Attributes;

namespace AlternativeMedicine.App.Controllers.Dtos.Incoming;

public class CreateUpdateCategoryDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string NameArabic { get; set; }
    [ValidColor]
    public string Color { get; set; }
    public int? ParentId { get; set; }
    [AllowedExtensions(".png,.jpg,.jpeg")]
    public IFormFile Image { get; set; }
}
