using EHR01.Domain.Models.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EHR01.Domain.Models.Admin
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [MaxLength(50)]
        public string Username { get; set; } = string.Empty;

        [MaxLength(100)]
        public string Email { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }

        // Navigation (initialized)
        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}