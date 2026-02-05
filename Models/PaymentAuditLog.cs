using System;
using System.ComponentModel.DataAnnotations;

namespace EHR01.Models
{
    /// <summary>
    /// Stores audit trail for all payment-related actions.
    /// Mandatory for compliance and financial reporting.
    /// </summary>
    public class PaymentAuditLog
    {
        [Key]
        public int AuditLogId { get; set; }

        [Required]
        public int PaymentId { get; set; }   // FK → Payments table

        [Required]
        [MaxLength(50)]
        public string Action { get; set; } = string.Empty;
        // Created / Refunded / Updated

        [MaxLength(30)]
        public string? OldStatus { get; set; }

        [MaxLength(30)]
        public string? NewStatus { get; set; }

        [Required]
        [MaxLength(50)]
        public string ChangedBy { get; set; } = string.Empty;
        // Admin / System

        [Required]
        public DateTime ChangedAt { get; set; } = DateTime.UtcNow;
    }
}

