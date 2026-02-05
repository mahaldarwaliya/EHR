using System;
using System.ComponentModel.DataAnnotations;

namespace EHR01.Models
{
    public class DoctorStatusHistory
    {
        [Key]
        public int StatusId { get; set; }

        [Required]
        public int DoctorId { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public DateTime ChangedAt { get; set; } = DateTime.UtcNow;

        [Required]
        public int ChangedBy { get; set; }   // Admin/User ID
    }
}
