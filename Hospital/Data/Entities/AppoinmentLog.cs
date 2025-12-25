namespace Hospital.Data.Entities;

public class AppointmentLog
{
    public int Id { get; set; }
    public int AppointmentId { get; set; }
    public Appointment Appointment { get; set; } = null!;
    public string ActionType { get; set; } = null!;
    public DateTime ActionDate { get; set; }
}
