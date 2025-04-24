using System.ComponentModel.DataAnnotations;

namespace QuotationSys.Models;

public class Customer
{
    public int Id { get; set; }

    [Required]
    [Display(Name = "Company Name")]
    public string CompanyName { get; set; }

    [Required]
    [Display(Name = "Contact Person")]
    public string ContactPerson { get; set; }

    [Required]
    [EmailAddress]
    [Display(Name = "Email Address")]
    public string Email { get; set; }

    [Phone]
    [Display(Name = "Phone Number")]
    public string PhoneNumber { get; set; }

    [Display(Name = "Address")]
    public string Address { get; set; }

    [Display(Name = "City")]
    public string City { get; set; }

    [Display(Name = "Country")]
    public string Country { get; set; }

    [Display(Name = "Tax ID/VAT Number")]
    public string TaxId { get; set; }

    [Display(Name = "Notes")]
    public string Notes { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }

    // Navigation property for Quotations
    public ICollection<Quotation> Quotations { get; set; }
}