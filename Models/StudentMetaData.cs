using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreMVC7_Course.Data;

public class StudentMetadata
{
    public int Id { get; set; }
    [Display(Name="First Name")]
    public string FirstName { get; set; } = null!;
    [Display(Name="Last Name")]
    public string LastName { get; set; } = null!;
    [Display(Name="Date Of Birth")]
    public DateTime? DateOfBirth { get; set; }
}

[ModelMetadataType(typeof(StudentMetadata))]
public partial class Student{}