using EHR01.Domain.Models.Billing;
using System;
using System.ComponentModel.DataAnnotations;

namespace EHR01.Domain.Models.Billing
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        public int InvoiceId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }

        // Navigation
        public Invoice? Invoice { get; set; }
    }
}