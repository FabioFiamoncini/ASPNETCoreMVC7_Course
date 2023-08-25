using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreMVC7_Course.Data;

public class CourseMetadata
{
    public int Id { get; set; }
    [Display(Name="Name")]
    public string Name { get; set; } = null!;
    [Display(Name="Code")]
    public string? Code { get; set; }
    [Display(Name="Credits")]
    public int? Credits { get; set; }
}

[ModelMetadataType(typeof(CourseMetadata))]
public partial class Course{}