using Hospital.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Data.Contexts;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(
            "Server=DESKTOP-H42M0B3\\SQLEXPRESS01;Database=HospitalDb;Trusted_Connection=True;TrustServerCertificate=True");
    }

    public DbSet<Patients> Patients { get; set; } = null!;
    public DbSet<Doctors> Doctors { get; set; } = null!;
}
