using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EHR01.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }

        [Required, MaxLength(50)]
        public string MRN { get; set; }

        [Required, MaxLength(100)]
        public string FirstName { get; set; }

        [Required, MaxLength(100)]
        public string LastName { get; set; }

        [MaxLength(20)]
        public string Gender { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(255)]
        public string Address { get; set; }

        [MaxLength(20)]
        public string MaritalStatus { get; set; }

        [MaxLength(10)]
        public string BloodGroup { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }

        // Navigation
        public ICollection<PatientIdentifier> PatientIdentifiers { get; set; }
        public ICollection<PatientContact> PatientContacts { get; set; }
        public ICollection<PatientAllergy> PatientAllergies { get; set; }
        public ICollection<PatientCondition> PatientConditions { get; set; }
        public ICollection<PatientEncounter> PatientEncounters { get; set; }
        public ICollection<PatientMedication> PatientMedications { get; set; }
    }
}

