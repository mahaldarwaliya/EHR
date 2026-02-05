using EHR01.Modules.Department.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalEHR.Modules.Department.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required]
        [MaxLength(100)]
        public string? DepartmentName { get; set; }

        [MaxLength(255)]
        public string? Description { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }

        // Navigation Properties
        public ICollection<DepartmentDoctors> DepartmentDoctors { get; set; }
        public ICollection<DepartmentService> DepartmentServices { get; set; }
        public ICollection<DepartmentRoom> DepartmentRooms { get; set; }
    }
}