using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR01.Models
{
    public class PatientObservation
    {
        [Key]
        public int ObservationId { get; set; }

        [Required]
        public int PatientId { get; set; }

        [Required]
        public int EncounterId { get; set; }

        [Required, MaxLength(50)]
        public string ObservationType { get; set; }

        [Required, MaxLength(50)]
        public string ObservationValue { get; set; }

        [MaxLength(20)]
        public string Unit { get; set; }

        public DateTime RecordedAt { get; set; } = DateTime.Now;

        // Navigation
        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }

        [ForeignKey("EncounterId")]
        public PatientEncounter PatientEncounter { get; set; }
    }
}
