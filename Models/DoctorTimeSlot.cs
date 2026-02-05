using System;
using System.ComponentModel.DataAnnotations;

namespace EHR01.Models
{
    public class DoctorTimeSlot
    {
        [Key]
        public int SlotId { get; set; }

        [Required]
        public int DoctorId { get; set; }

        [Required]
        public DateTime SlotDate { get; set; }

        [Required]
        public TimeSpan StartTime { get; set; }

        [Required]
        public TimeSpan EndTime { get; set; }

        public bool IsBooked { get; set; }
    }
}
