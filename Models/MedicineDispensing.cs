using System;

namespace EHR01.Modules.Pharmacy.Models
{
    public class MedicineDispensing
    {
        public int DispenseId { get; set; }
        public int PrescriptionId { get; set; } // External reference
        public int MedicineId { get; set; }
        public int QuantityDispensed { get; set; }
        public int DispensedBy { get; set; }
        public DateTime DispensedAt { get; set; }

        // Navigation
        public Medico Medicine { get; set; } = null!;
        public PharmacyStaff DispensedByStaff { get; set; } = null!;
    }
}
