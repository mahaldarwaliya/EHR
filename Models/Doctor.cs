using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR01.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }

        [Required]
        [MaxLength(150)]
        public int FullName { get; set; }

        [Required]
        [MaxLength(20)]
        public int Gender { get; set; }   // Male / Female / Other

        [Required]
        [MaxLength(100)]
        public int Specialization { get; set; }   // Cardiology, ENT, etc.

        [Required]
        [MaxLength(100)]
        public int Qualification { get; set; }    // MBBS, MD, etc.

        [Range(0, 60)]
        public int ExperienceYears { get; set; }

        [Required]
        [MaxLength(20)]
        public int PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(150)]
        public int Email { get; set; }

        // Foreign Key to Department module
        public int DepartmentId { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal ConsultationFee { get; set; }

        // Soft Delete Flag
        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }
    }
}
