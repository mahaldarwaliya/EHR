using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EHR01.Domain.Models.Admin
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }

        [MaxLength(50)]
        public string RoleName { get; set; } = string.Empty;

        [MaxLength(200)]
        public string Description { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }

        // Navigation
        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}