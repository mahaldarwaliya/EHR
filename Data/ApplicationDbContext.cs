using Microsoft.EntityFrameworkCore;
using EHR01.PaymentService.Models;

namespace EHR01.PaymentService.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Payment>()
                .HasIndex(p => p.PatientId);

            modelBuilder.Entity<Payment>()
                .HasIndex(p => p.InvoiceId);

            modelBuilder.Entity<Payment>()
                .HasIndex(p => p.PaymentDate);

            modelBuilder.Entity<Payment>()
                .HasIndex(p => p.PaymentStatus);
        }
    }
}

