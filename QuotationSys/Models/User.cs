using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace QuotationSys.Models;

public class User : IdentityUser
{
    [Required]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    [Display(Name = "Profile Picture")]
    public string? ProfilePicture { get; set; }

    public string? Address { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }

    [Display(Name = "Date of Birth")]
    [DataType(DataType.Date)]
    public DateTime? DateOfBirth { get; set; }

    public string? Bio { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public bool IsActive { get; set; } = true;
    public DateTime? LastLoginDate { get; set; }
}