using Hospital.Data.Contexts;
using Hospital.Data.Entities;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

AppDbContext _context = new();

#region Data Insert

Doctor dc = new()
{
    FullName = "Kamran Jabiyev",
    Specialty = "Psychiocolgy"
};
Doctor dc2 = new()
{
    FullName = "Mustafa Sandal",
    Specialty = "Ginekoloq"
};
Patient pt = new()
{
    FullName = "Zeynal Memmedli",
    DateOfBirth = new DateTime(1995, 5, 23)
};
Patient pt2 = new()
{
    FullName = "Elibala Gulbala",
    DateOfBirth = new DateTime(1998, 3, 15)
};
Patient pt3 = new()
{
    FullName = "Ilkin Mamedov",
    DateOfBirth = new DateTime(2000, 7, 30)
};
//_context.Doctors.AddRange(dc, dc2);
//_context.Patients.AddRange(pt, pt2, pt3);
//_context.SaveChanges();
Appointment ap = new()
{
    DoctorId = 1,
    PatientId = 2,
    AppointmentDate = DateTime.Now.AddDays(2)
};
Appointment ap2 = new()
{
    DoctorId = 1,
    PatientId = 1,
    AppointmentDate = DateTime.Now.AddDays(5)
};
Appointment ap3 = new()
{
    DoctorId = 2,
    PatientId = 3,
    AppointmentDate = DateTime.Now.AddDays(1)
};
//_context.Appointments.AddRange(ap,ap2,ap3);
//_context.SaveChanges();

var logs = new List<AppointmentLog>
    {
        new AppointmentLog
        {
            AppointmentId = 2,
            ActionType = "INSERT",
            ActionDate = DateTime.Now
        },
        new AppointmentLog
        {
            AppointmentId = 3,
            ActionType = "INSERT",
            ActionDate = DateTime.Now
        },
        new AppointmentLog
        {
            AppointmentId = 4,
            ActionType = "INSERT",
            ActionDate = DateTime.Now
        }
};
//_context.AppoinmentLogs.AddRange(logs);
//_context.SaveChanges();
#endregion