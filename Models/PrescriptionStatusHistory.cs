using System;
using System.ComponentModel.DataAnnotations;

namespace EHR01.Models
{
    public class PrescriptionStatusHistory
    {
        [Key]
        public int StatusHistoryId { get; set; }

        public int PrescriptionId { get; set; }

        [MaxLength(20)]
        public string OldStatus { get; set; } = null!;

        [MaxLength(20)]
        public string NewStatus { get; set; } = null!;

        [MaxLength(100)]
        public string ChangedBy { get; set; } = null!;

        public DateTime ChangedAt { get; set; } = DateTime.UtcNow;

        // Navigation
        public Prescription Prescription { get; set; } = null!;
    }
}
