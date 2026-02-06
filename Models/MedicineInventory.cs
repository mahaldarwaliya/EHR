namespace EHR01.Modules.Pharmacy.Models
{
    public class MedicineInventory
    {
        public int Id { get; set; }
        public string MedicineName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}