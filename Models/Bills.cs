using EHR01.Domain.Models.Billing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EHR01.Domain.Models.Billing
{
    public class Bill
    {
        [Key]
        public int BillId { get; set; }

        public int PatientId { get; set; }
        public int EncounterId { get; set; }
        public int PrescriptionId { get; set; }

        public DateTime BillDate { get; set; }
        public decimal TotalAmount { get; set; }

        [MaxLength(20)]
        public string Status { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Navigation (initialized → no warnings)
        public ICollection<BillItem> BillItems { get; set; } = new List<BillItem>();
        public Invoice? Invoice { get; set; }
    }
}