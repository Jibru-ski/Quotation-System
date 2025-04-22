using System.ComponentModel.DataAnnotations;

namespace QuotationSysAuth.Models;

public class Quotation
{
    [Key]
    public int QuotationId { get; set; }
    
    [Required]
    public int CustomerId { get; set; }
    
    [Required]
    public int UserId { get; set; }
    
    [Required]
    [Display(Name = "Quotation Number")]
    public string QuotationNumber { get; set; }
    
    [Required]
    [Display(Name = "Issue Date")]
    [DataType(DataType.Date)]
    public DateTime IssueDate { get; set; } = DateTime.UtcNow;
    
    [Required]
    [Display(Name = "Valid Until")]
    [DataType(DataType.Date)]
    public DateTime ValidUntil{ get; set; }
    
    [Required]
    [Display(Name = "Created Date")]
    [DataType(DataType.Date)]
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    
    public User User { get; set; }
    public Customer Customer { get; set; }
    public ICollection<QuotationItem> Items { get; set; }
    
    // public decimal SubTotal { get; set; } => Items?.sum() ?? 0;
    public decimal Discount { get; set; }
    public decimal Tax { get; set; }
    public string Notes { get; set; }
}