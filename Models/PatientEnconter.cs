using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR01.Models
{
    public class PatientEncounter
    {
        [Key]
        public int EncounterId { get; set; }

        [Required]
        public int PatientId { get; set; }

        [Required]
        public int DoctorId { get; set; }

        public DateTime EncounterDate { get; set; }

        [MaxLength(20)]
        public string EncounterType { get; set; }

        [MaxLength(20)]
        public string Status { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Navigation
        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }

        public ICollection<PatientObservation> PatientObservations { get; set; }
    }
}
