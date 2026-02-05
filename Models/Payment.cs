using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR01.PaymentService.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        [Required]
        public int PatientId { get; set; }   // FK → Patient Module

        [Required]
        public int InvoiceId { get; set; }   // FK → Billing Module

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Amount { get; set; }

        [Required]
        [MaxLength(50)]
        public string PaymentMethod { get; set; } = string.Empty;
        // Cash / Card / UPI / NetBanking

        [Required]
        [MaxLength(20)]
        public string PaymentStatus { get; set; } = string.Empty;
        // Success / Failed / Pending

        [MaxLength(100)]
        public string? TransactionRef { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}

