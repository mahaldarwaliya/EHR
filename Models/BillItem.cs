using EHR01.Domain.Models.Billing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EHR01.Domain.Models.Billing
{
    public class BillItem
    {
        [Key]
        public int BillItemId { get; set; }

        public int BillId { get; set; }

        [MaxLength(30)]
        public string ServiceType { get; set; } = string.Empty;

        public int ReferenceId { get; set; }

        [MaxLength(200)]
        public string Description { get; set; } = string.Empty;

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }

        // Navigation
        [ForeignKey(nameof(BillId))]
        public Bill? Bill { get; set; }
    }
}