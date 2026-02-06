using System;

namespace EHR01.Modules.Pharmacy.Models
{
    public class MedicineReturn
    {
        public int ReturnId { get; set; }
        public int InventoryId { get; set; }
        public int MedicineId { get; set; }
        public int Quantity { get; set; }
        public string Reason { get; set; } = null!;
        public DateTime ReturnedAt { get; set; }
        public int HandledBy { get; set; }

        // Navigation
        public MedicineInventory Inventory { get; set; } = null!;
        public Medico Medicine { get; set; } = null!;
        public PharmacyStaff HandledByStaff { get; set; } = null!;
    }
}
