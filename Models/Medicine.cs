using EHR01.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EHR01.Models
{
    public class Medicine
    {
        [Key]
        public int MedicineId { get; set; }

        [Required, MaxLength(150)]
        public string MedicineName { get; set; } = null!;

        [MaxLength(150)]
        public string? GenericName { get; set; }

        [MaxLength(150)]
        public string? BrandName { get; set; }

        [MaxLength(50)]
        public string? MedicineType { get; set; }

        [MaxLength(50)]
        public string? Strength { get; set; }

        [MaxLength(20)]
        public string? Unit { get; set; }

        [MaxLength(150)]
        public string? Manufacturer { get; set; }

        public string? Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        // Navigation
        public ICollection<PrescriptionMedicine> PrescriptionMedicines { get; set; } = new List<PrescriptionMedicine>();
    }
}
