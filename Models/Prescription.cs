using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EHR01.Models
{
    public class Prescription
    {
        [Key]
        public int PrescriptionId { get; set; }

        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public int MedicalRecordId { get; set; }

        [MaxLength(255)]
        public string? Diagnosis { get; set; }

        public string? SpecialInstructions { get; set; }

        public DateTime PrescriptionDate { get; set; }

        [MaxLength(20)]
        public string Status { get; set; } = "Active";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        // Navigation
        public ICollection<PrescriptionMedicine> PrescriptionMedicines { get; set; } = new List<PrescriptionMedicine>();
        public ICollection<PrescriptionPrintLog> PrintLogs { get; set; } = new List<PrescriptionPrintLog>();
        public ICollection<PrescriptionStatusHistory> StatusHistories { get; set; } = new List<PrescriptionStatusHistory>();
    }
}
