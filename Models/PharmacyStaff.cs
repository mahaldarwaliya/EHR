using System;
using System.Collections.Generic;

namespace EHR01.Modules.Pharmacy.Models
{
    public class PharmacyStaff
    {
        public int StaffId { get; set; }
        public string FullName { get; set; } = null!;
        public string Role { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string? Email { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; }

        // Navigation
        public ICollection<MedicineDispensing> Dispensings { get; set; } = new List<MedicineDispensing>();
        public ICollection<MedicineReturn> Returns { get; set; } = new List<MedicineReturn>();
    }
}
