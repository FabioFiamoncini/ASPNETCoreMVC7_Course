using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreMVC7_Course.Data;

public class LecturerMetadata
{
    public int Id { get; set; }
    [Display(Name="First Name")]
    public string FirstName { get; set; } = null!;
    [Display(Name="Last Name")]
    public string LastName { get; set; } = null!;
}

[ModelMetadataType(typeof(LecturerMetadata))]
public partial class Lecturer{}