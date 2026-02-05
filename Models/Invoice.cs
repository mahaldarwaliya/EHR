using EHR01.Domain.Models.Billing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EHR01.Domain.Models.Billing
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }

        public int BillId { get; set; }
        public int PatientId { get; set; }

        public DateTime InvoiceDate { get; set; }
        public decimal InvoiceAmount { get; set; }

        [MaxLength(20)]
        public string InvoiceStatus { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }

        // Navigation
        public Bill? Bill { get; set; }
        public ICollection<InsuranceClaim> InsuranceClaims { get; set; } = new List<InsuranceClaim>();
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}