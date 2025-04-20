using Microsoft.AspNetCore.Identity;

namespace QuotationSysAuth.Models;

public class User : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateCreated { get; set; }
}