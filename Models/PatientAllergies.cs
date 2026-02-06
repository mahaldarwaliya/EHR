using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR01.Models
{
    public class PatientAllergy
    {
        [Key]
        public int AllergyId { get; set; }

        [Required]
        public int PatientId { get; set; }

        [Required, MaxLength(100)]
        public string AllergyName { get; set; }

        [MaxLength(20)]
        public string Severity { get; set; }

        [MaxLength(255)]
        public string Notes { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Navigation
        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }
    }
}

