using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR01.Models
{
    public class MedicalRecordArchive
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ArchiveId { get; set; }

        [Required]
        public int RecordId { get; set; }   // FK → MedicalRecords

        [Required]
        public DateTime ArchivedAt { get; set; } = DateTime.UtcNow;

        public int? ArchivedBy { get; set; }   // Admin / Doctor ID

        [MaxLength(255)]
        public string? Reason { get; set; }
    }
}
