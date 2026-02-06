using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR01.Models
{
    public class PatientCondition
    {
        [Key]
        public int ConditionId { get; set; }

        [Required]
        public int PatientId { get; set; }

        [Required, MaxLength(100)]
        public string ConditionName { get; set; }

        public DateTime? DiagnosisDate { get; set; }

        [MaxLength(20)]
        public string Status { get; set; }

        [MaxLength(255)]
        public string Notes { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Navigation
        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }
    }
}
