using System;
using System.ComponentModel.DataAnnotations;

namespace EHR01.Models
{
    public class DoctorRating
    {
        [Key]
        public int RatingId { get; set; }

        [Required]
        public int DoctorId { get; set; }

        [Required]
        public int PatientId { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }

        [MaxLength(500)]
        public int Comment { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
