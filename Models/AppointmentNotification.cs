using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR01.Models
{
    public class AppointmentNotification
    {
        [Key]
        public int NotificationId { get; set; }

        [Required]
        public int AppointmentId { get; set; }

        [Required]
        [StringLength(20)]
        public string NotificationType { get; set; } = string.Empty;

        public DateTime SentAt { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; } = string.Empty;

        // Navigation Property
        [ForeignKey(nameof(AppointmentId))]
        public Appointment? Appointment { get; set; }
    }
}
