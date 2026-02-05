using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalEHR.Modules.Department.Models
{
    public class DepartmentRoom
    {
        [Key]
        public int RoomId { get; set; }

        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }

        [Required]
        [MaxLength(50)]
        public string? RoomNumber { get; set; }

        [Required]
        [MaxLength(50)]
        public string? RoomType { get; set; } // OPD / ICU / Ward

        public int Capacity { get; set; }

        public bool IsAvailable { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation
        public Department Department { get; set; }
    }
}