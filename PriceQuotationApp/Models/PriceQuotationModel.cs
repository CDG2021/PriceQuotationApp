using System;
using System.ComponentModel.DataAnnotations;

namespace PriceQuotationApp.Models
{
    public class PriceQuotationModel
    {
        [Required(ErrorMessage ="Please enter a sale price.")]
        [Range(0.01, 500, ErrorMessage = "Sale price must be greater than zero and less or equal to 500")]
        public decimal? Subtotal { get; set; }

        [Required(ErrorMessage = "Please enter a discount percent.")]
        [Range(0.0, 100.0, ErrorMessage = "Discount percent must be between 0 and 100")]
        public decimal? DiscountPercent { get; set; }

        public decimal? DiscountAmount() {
            decimal? discountAmountCal = Subtotal * (DiscountPercent / 100);
            
            return discountAmountCal;
        }

        public decimal? TotalAmount() {
            decimal? totalAmountCal = Subtotal - (Subtotal * (DiscountPercent /100));

            return totalAmountCal;
        }
    }
}
