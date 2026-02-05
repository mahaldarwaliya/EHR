using System.ComponentModel.DataAnnotations;

namespace EHR01.Domain.Models.Admin
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [MaxLength(100)]
        public string DepartmentName { get; set; } = string.Empty;

        public bool IsActive { get; set; }
    }
}