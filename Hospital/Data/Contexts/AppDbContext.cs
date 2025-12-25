using Microsoft.EntityFrameworkCore;

namespace Hospital.Data.Contexts;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(
            "Server=DESKTOP-H42M0B3\\SQLEXPRESS01;Database=HospitalDb;Trusted_Connection=True;TrustServerCertificate=True");
    }
}
