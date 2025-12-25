namespace Hospital.Data.Entities;

public class Patient
{
    public int Id { get; set; }
    public string FullName { get; set; } = null!;
    public DateTime DateOfBirth { get; set; }
    public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
}
