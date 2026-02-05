using EHR01.Domain.Models.Admin;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR01.Domain.Models.Admin
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }

        [MaxLength(100)]
        public string ServiceName { get; set; } = string.Empty;

        public int DepartmentId { get; set; }

        public decimal Price { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }

        // Navigation
        [ForeignKey(nameof(DepartmentId))]
        public Department? Department { get; set; }
    }
}