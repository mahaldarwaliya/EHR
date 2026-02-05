using EHR01.Domain.Models.Billing;
using System;
using System.ComponentModel.DataAnnotations;

namespace EHR01.Domain.Models.Billing
{
    public class InsuranceClaim
    {
        [Key]
        public int ClaimId { get; set; }

        public int PatientId { get; set; }
        public int InvoiceId { get; set; }

        [MaxLength(100)]
        public string InsuranceProvider { get; set; } = string.Empty;

        public decimal ClaimAmount { get; set; }

        [MaxLength(20)]
        public string ClaimStatus { get; set; } = string.Empty;

        public DateTime SubmittedAt { get; set; }

        // Navigation
        public Invoice? Invoice { get; set; }
    }
}