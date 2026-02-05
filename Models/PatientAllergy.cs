using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR01.Models
{
    public class PatientAllergy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AllergyId { get; set; }

        [Required]
        public int PatientId { get; set; }   // FK → Patient module

        [Required]
        [MaxLength(255)]
        public string AllergyName { get; set; } = string.Empty;

        [MaxLength(50)]
        public string? Severity { get; set; }   // Mild / Moderate / Severe

        public string? Notes { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
