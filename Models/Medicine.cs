using System;
using System.Collections.Generic;

namespace EHR01.Modules.Pharmacy.Models
{
    public class Medicine
    {
        public int MedicineId { get; set; }
        public string MedicineName { get; set; } = null!;
        public int CategoryId { get; set; }
        public string Strength { get; set; } = null!;
        public string Form { get; set; } = null!;
        public string Manufacturer { get; set; } = null!;
        public decimal UnitPrice { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; }

        // Navigation
        public MedicineCategory Category { get; set; } = null!;
        public ICollection<MedicineInventory> Inventories { get; set; } = new List<MedicineInventory>();
        public ICollection<MedicineDispensing> Dispensings { get; set; } = new List<MedicineDispensing>();
        public ICollection<MedicineReturn> Returns { get; set; } = new List<MedicineReturn>();
    }
}
