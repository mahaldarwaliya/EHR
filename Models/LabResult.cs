using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR01.Models
{
    public class LabResult
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LabResultId { get; set; }

        [Required]
        public int RecordId { get; set; }   // FK → MedicalRecords

        [Required]
        [MaxLength(255)]
        public string TestName { get; set; } = string.Empty;

        public string? Result { get; set; }

        public string? Remarks { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
