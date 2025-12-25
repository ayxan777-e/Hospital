namespace Hospital.Data.Entities;

public class Patients
{
    public int Id { get; set; }
    public string FullName { get; set; } = null!;
    public DateTime DateOfBirth { get; set; }
}
