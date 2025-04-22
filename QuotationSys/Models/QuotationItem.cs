using System.ComponentModel.DataAnnotations;

namespace QuotationSysAuth.Models;

public class QuotationItem
{
    [Key]
    public int QuotationItemId { get; set; }
    
    public int QuotationId { get; set; }
    public int ProductId { get; set; }
    
    [Required]
    [Display(Name = "Quantity")]
    [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than 0")]
    public int Quantity { get; set; }

    [Required]
    [Display(Name = "Unit Price")]
    [DataType(DataType.Currency)]
    [Range(0.01, double.MaxValue, ErrorMessage = "Unit price must be greater than 0")]
    public decimal UnitPrice { get; set; }

    public string UnitOfMeasure { get; set; } = "pcs";
    
}