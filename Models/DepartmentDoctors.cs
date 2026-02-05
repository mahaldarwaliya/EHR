using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalEHR.Modules.Department.Models
{
    public class DepartmentDoctors
    {
        [Key]
        public int DeptDoctorId { get; set; }

        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }

        // External Module Reference (Doctor)
        public int DoctorId { get; set; }

        public DateTime AssignedAt { get; set; } = DateTime.UtcNow;

        public bool IsActive { get; set; } = true;

        // Navigation
        public Department Department { get; set; }
    }
}
