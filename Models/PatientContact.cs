using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR01.Models
{
    public class PatientContact
    {
        [Key]
        public int ContactId { get; set; }

        [Required]
        public int PatientId { get; set; }

        [Required, MaxLength(100)]
        public string ContactName { get; set; }

        [MaxLength(50)]
        public string Relationship { get; set; }

        [Required, MaxLength(20)]
        public string Phone { get; set; }

        public bool IsPrimary { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Navigation
        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }
    }
}
