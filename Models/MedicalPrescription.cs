using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR01.Models
{
    public class MedicalPrescription
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PrescriptionId { get; set; }

        [Required]
        public int RecordId { get; set; }   // FK → MedicalRecords

        [Required]
        [MaxLength(255)]
        public string MedicineName { get; set; } = string.Empty;

        [MaxLength(100)]
        public string? Dosage { get; set; }

        [MaxLength(100)]
        public string? Frequency { get; set; }

        [MaxLength(100)]
        public string? Duration { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
