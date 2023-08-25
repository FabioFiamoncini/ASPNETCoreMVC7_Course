using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreMVC7_Course.Data;

public class EnrollmentMetadata
{
    public int Id { get; set; }
    [Display(Name="Student ID")]
    public int? StudentId { get; set; }
    [Display(Name="Class ID")]
    public int? ClassId { get; set; }
    public string? Grade { get; set; }
    public virtual Student? Student { get; set; }
    public virtual Class? Class { get; set; }
}

[ModelMetadataType(typeof(EnrollmentMetadata))]
public partial class Enrollment{}