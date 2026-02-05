using System;
using System.ComponentModel.DataAnnotations;

namespace EHR01.Models
{
    public class PrescriptionPrintLog
    {
        [Key]
        public int PrintLogId { get; set; }

        public int PrescriptionId { get; set; }

        public DateTime PrintedAt { get; set; }

        [MaxLength(100)]
        public string PrintedBy { get; set; } = null!;

        [MaxLength(20)]
        public string Format { get; set; } = null!;

        // Navigation
        public Prescription Prescription { get; set; } = null!;
    }
}
