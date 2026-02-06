using System;
using System.Collections.Generic;

namespace EHR01.Modules.Pharmacy.Models
{
    public class MedicineCategory
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; }

        // Navigation
        public ICollection<Medico> Medicines { get; set; } = new List<Medico>();
    }
}
