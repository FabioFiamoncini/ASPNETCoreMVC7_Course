using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreMVC7_Course.Data;

public class ClassMetadata
{
    public int Id { get; set; }
    [Display(Name="Lecturer ID")]
    public int? LecturerId { get; set; }
    [Display(Name="Course ID")]
    public int? CourseId { get; set; }
    public TimeSpan? Time { get; set; }
    public virtual Course? Course { get; set; }
    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    public virtual Lecturer? Lecturer { get; set; }
}

[ModelMetadataType(typeof(ClassMetadata))]
public partial class Class{}