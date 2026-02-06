using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR01.Models
{
    public class PatientIdentifier
    {
        [Key]
        public int IdentifierId { get; set; }

        [Required]
        public int PatientId { get; set; }

        [Required, MaxLength(50)]
        public string IdentifierType { get; set; }

        [Required, MaxLength(100)]
        public string IdentifierValue { get; set; }

        [MaxLength(100)]
        public string IssuedBy { get; set; }

        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Navigation
        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }
    }
}

