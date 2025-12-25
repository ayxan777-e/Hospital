namespace Hospital.Data.Entities;

public class Doctors
{
    public int Id { get; set; }
    public string FullName { get; set; } = null!;
    public string Specialty { get; set; } = null!;
}
