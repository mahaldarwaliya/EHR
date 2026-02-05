using System;
using System.ComponentModel.DataAnnotations;

namespace EHR01.Models
{
    public class DoctorUser
    {
        [Key]
        public int DoctorUserId { get; set; }

        [Required]
        public int DoctorId { get; set; }

        [Required]
        public int UserId { get; set; }   // Identity/User module

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
