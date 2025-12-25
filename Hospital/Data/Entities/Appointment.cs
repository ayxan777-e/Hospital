namespace Hospital.Data.Entities;

public class Appointment
{
    public int Id { get; set; }
    public int PatientId { get; set; }
    public Patient MyProperty { get; set; }= null!; 
    public int DoctorId { get; set; }
    public Doctor Doctor { get; set; } = null!;
    public DateTime AppointmentDate { get; set; }
    public ICollection<AppoinmentLog> AppoinmentLogs { get; set; } = new List<AppoinmentLog>();
}
