using System.ComponentModel.DataAnnotations;

namespace QuotationSysAuth.Models;

public class QuotationItem
{
    [Key]
    public int QuotationItemId { get; set; }
    
    public int QuotationId { get; set; }
    public int ProductId { get; set; }
    
    [Display(Name = "Item Name")]
    public string Name { get; set; }
    
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
    
    [Display(Name = "Discount (%)")]
    [Range(0, 100, ErrorMessage = "Discount must be between 0 and 100")]
    public decimal DiscountPercentage { get; set; }

    [Display(Name = "Tax Rate (%)")]
    [Range(0, 100, ErrorMessage = "Tax rate must be between 0 and 100")]
    public decimal TaxRate { get; set; }
    
    public Quotation Quotation { get; set; }
    public Product Product { get; set; }
    public string DisplayName => Product != null ? Product.ProductName : Name;
    public string DisplayUnitOfMeasure => Product != null ? Product.UnitOfMeasure : "pcs";
    
    public decimal Subtotal => Quantity * UnitPrice;
    public decimal DiscountAmount => Subtotal * (DiscountPercentage / 100);
    public decimal TaxAmount => (Subtotal - DiscountAmount) * (TaxRate / 100);
    public decimal Total => Subtotal - DiscountAmount + TaxAmount;
    
}