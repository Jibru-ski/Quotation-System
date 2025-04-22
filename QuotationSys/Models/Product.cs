using System.ComponentModel.DataAnnotations;

namespace QuotationSysAuth.Models;

public class Product
{
    [Key]
    public int ProductId { get; set; }
    
    [Required]
    [Display(Name = "Product Code")]
    public string Code { get; set; }
    
    [Required]
    [Display(Name = "Product Name")]
    public string ProductName { get; set; }
    
    [Required]
    [Display(Name = "Product Description")]
    public string Description { get; set; }
    
    [Required]
    [Display(Name = "Quantity")]
    [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than 0")]
    public int Quantity { get; set; }
    
    [Required]
    [DataType(DataType.Currency)]
    [Range(0.01, double.MaxValue, ErrorMessage = "Unit Price must be greater than 0")]
    public decimal UnitPrice { get; set; }

    public string UnitOfMeasure { get; set; } = "pcs";
    
    public ICollection<QuotationItem> QuotationItems { get; set; }
}