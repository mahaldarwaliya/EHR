using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR01.Models
{
    public class AppointmentStatusHistory
    {
        [Key]
        public int StatusHistoryId { get; set; }

        [Required]
        public int AppointmentId { get; set; }

        [Required]
        [StringLength(20)]
        public string OldStatus { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        public string NewStatus { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        public string ChangedBy { get; set; } = string.Empty;

        public DateTime ChangedAt { get; set; }

        // Navigation Property
        [ForeignKey(nameof(AppointmentId))]
        public Appointment? Appointment { get; set; }
    }
}
