using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR01.Models
{
    public class PatientMedication
    {
        [Key]
        public int MedicationId { get; set; }

        [Required]
        public int PatientId { get; set; }

        [Required, MaxLength(100)]
        public string MedicineName { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        [MaxLength(20)]
        public string Status { get; set; }

        public int? PrescribedBy { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Navigation
        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }
    }
}
