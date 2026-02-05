using System;
using System.ComponentModel.DataAnnotations;

namespace EHR01.Models
{
    public class DoctorLeave
    {
        [Key]
        public int LeaveId { get; set; }

        [Required]
        public int DoctorId { get; set; }

        [Required]
        public DateTime FromDate { get; set; }

        [Required]
        public DateTime ToDate { get; set; }

        [MaxLength(250)]
        public int Reason { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
