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

#region The first variant of View

//_context.Appointments
//    .Include(a => a.Doctor)
//    .Include(a => a.Patient)
//    .ToList()
//    .ForEach(a =>
//    {
//        Console.WriteLine($"DoctorName: {a.Doctor.FullName}, PatientName: {a.Patient.FullName}, AppoinmentDate: {a.AppointmentDate}");
//    });
#endregion

#region The second variant of View
//_context.Appointments
//    .Select(a => new
//    {
//        DoctorName = a.Doctor.FullName,
//        PatientName = a.Patient.FullName,
//        AppoinmentDate = a.AppointmentDate,
//    })
//    .ToList()
//    .ForEach(a =>
//    {
//        Console.WriteLine($"DoctorName: {a.DoctorName}, PatientName: {a.PatientName}, AppoinmentDate: {a.AppoinmentDate}");

//    });

#endregion

#region The third variant of View
//var result=_context.Appointments
//    .GroupBy(a => a.Doctor.FullName)
//    .Select(g => new
//    {
//        DoctorName = g.Key,
//        AppointmentCount = g.Count()
//    })
//    .ToList();
//foreach (var item in result)
//{
//    Console.WriteLine($"{item.DoctorName} have {item.AppointmentCount} appointments");
//}

#endregion

#region GetInfo by DoctorId

//var doctor = _context.Doctors
//    .Include(d => d.Appointments)
//    .ThenInclude(a => a.AppointmentLogs)
//    .FirstOrDefault(d => d.Id == 1);
//if (doctor is not null)
//{
//    var result=doctor.Appointments
//        .SelectMany(a => a.AppointmentLogs, (a ,logs) => new
//        {
//            DoctorName= doctor.FullName,
//            AppointmentDate=a.AppointmentDate,
//            logs.ActionType,
//            logs.ActionDate
//        })
//        .ToList();
//    foreach (var item in result)
//    {
//        Console.WriteLine($"DoctorName:{item.DoctorName} have appointment at {item.AppointmentDate} and {item.ActionType} __ {item.ActionDate}");
//    }
//}

#endregion

#region GetInfo by PatientId    

//var patient=_context.Patients
//    .Include(p => p.Appointments)
//    .ThenInclude(a => a.Doctor)
//    .Include(p => p.Appointments)
//    .ThenInclude(a => a.AppointmentLogs)
//    .FirstOrDefault(p => p.Id == 2);

//if (patient is not null)
//{
//    var result=patient.Appointments
//        .SelectMany(a=>a.AppointmentLogs, (a, logs) => new
//        {
//            PatientName = patient.FullName,
//            DoctorName = a.Doctor.FullName,
//            AppointmentDate = a.AppointmentDate,
//            logs.ActionType,
//            logs.ActionDate
//        })
//        .ToList();
//    foreach (var item in result)
//    {
//        Console.WriteLine($"{item.PatientName} has appointment with doctor {item.DoctorName} at {item.AppointmentDate}");
//    }
//}
#endregion