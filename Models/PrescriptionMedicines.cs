using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR01.Models
{
    public class PrescriptionMedicine
    {
        [Key]
        public int PrescriptionMedicineId { get; set; }

        public int PrescriptionId { get; set; }
        public int MedicineId { get; set; }

        [MaxLength(100)]
        public string Dosage { get; set; } = null!;

        [MaxLength(50)]
        public string Frequency { get; set; } = null!;

        public int Duration { get; set; }

        public string? Notes { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation
        public Prescription Prescription { get; set; } = null!;
        public Medicine Medicine { get; set; } = null!;
    }
}
