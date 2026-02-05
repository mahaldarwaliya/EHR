using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR01.PaymentService.Models
{
    /// <summary>
    /// Read-only reference model.
    /// Owned by Billing Module.
    /// Used in Payment Module only for reporting & summaries.
    /// </summary>
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }

        [Required]
        public int PatientId { get; set; }   // FK → Patient Module

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal TotalAmount { get; set; }

        [Required]
        [MaxLength(30)]
        public string InvoiceStatus { get; set; } = string.Empty;
        // Paid / Partially Paid / Unpaid

        [Required]
        public DateTime CreatedAt { get; set; }
    }
}

