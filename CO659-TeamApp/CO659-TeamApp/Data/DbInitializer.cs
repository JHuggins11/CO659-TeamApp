using CO659_TeamApp.Models;
using System.Diagnostics;

namespace CO659_TeamApp.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // Look for any symptoms.
            if (context.Symptoms.Any())
            {
                return;   // DB has been seeded
            }

            var symptom = new Symptom[]
            {
                new Symptom
                {
                    ID=1,
                    SymptomName="Impetigo",
                    SymptomType="Rash",
                    SymptomDetails="Red, itchy sores",
                    SymptomSeverity = SymptomSeverities.mild
                },
                
                new Symptom
                {
                    ID=2,
                    SymptomName="Arthritis",
                    SymptomType="Joints",
                    SymptomDetails="Pain and inflammation in a joint",
                    SymptomSeverity = SymptomSeverities.severe
                },

                new Symptom
                {
                    ID = 3,
                    SymptomName="Laryngitis",
                    SymptomType="Throat",
                    SymptomDetails="Inflammation of the larynx",
                    SymptomSeverity = SymptomSeverities.regular
                }
            };

            context.Symptoms.AddRange(symptom);
            context.SaveChanges();




            var medicine = new Medicine[]
            {
                new Medicine
                {
                    ID=1,
                    MedicineName="Codeine",
                    MedicineType="Pain refielf",
                    MedicineDosage=200,
                    MedicineQty = 1,
                    IsAvailable = true
                },

                new Medicine
                {
                    ID=2,
                    MedicineName="Mupirocin",
                    MedicineType="Antibiotics",
                    MedicineDosage=1,
                    MedicineQty = 1,
                    IsAvailable = true
                },

                new Medicine
                {
                    ID=3,
                    MedicineName="Inhaler",
                    MedicineType="Oral",
                    MedicineDosage=1,
                    MedicineQty = 1,
                    IsAvailable = true
                },
            };

            context.Medicines.AddRange(medicine);
            context.SaveChanges();




            var patient = new Patient[]
{
                new Patient
                {
                    ID=1,
                    PatientFName="Maria",
                    PatientLName="Cox",
                    PatientDOB=DateTime.Parse("1995-12-01"),
                    AddressHouseNo="2",
                    AddressStreet="Milton Close",
                    AddressLineTwo="Bakers Way",
                    AddressTownCity="Welwyn",
                    AddressPostcode="WG3 7GH",
                },

                new Patient
                {
                    ID=2,
                    PatientFName="Prathna",
                    PatientLName="Reed",
                    PatientDOB=DateTime.Parse("1972-06-03"),
                    AddressHouseNo="6",
                    AddressStreet="Hollybush Lane",
                    AddressLineTwo="Sleepside",
                    AddressTownCity="Wheathampstead",
                    AddressPostcode="AL4 5HH",
                    MobileNumber="07658832464"
                },

                new Patient
                {
                    ID=3,
                    PatientFName="Thomas",
                    PatientLName="Penn",
                    PatientDOB=DateTime.Parse("1999-01-09"),
                    AddressHouseNo="24",
                    AddressStreet="Crabtree Lane",
                    AddressLineTwo="Walkers Close",
                    AddressTownCity="Harpenden",
                    AddressPostcode="AL5 5HP",
                    MobileNumber="07676563343"
                },
            };

            context.Patients.AddRange(patient);
            context.SaveChanges();





            var practitioner = new Practitioner[]
{
                new Practitioner
                {
                    ID=1,
                    PractitionerFName="Naya",
                    PractitionerLName="Choudhurt",
                    PractitionerTitle=PractitionerTitles.generalPractitioner,
                    PractitionerDept=PractitionerDepts.general
                },

                new Practitioner
                {
                    ID=2,
                    PractitionerFName="Nigel",
                    PractitionerLName="Flemming",
                    PractitionerTitle=PractitionerTitles.paediatrician,
                    PractitionerDept=PractitionerDepts.paediatrics
                },

                new Practitioner
                {
                    ID=3,
                    PractitionerFName="Lisa",
                    PractitionerLName="Stone",
                    PractitionerTitle=PractitionerTitles.nutritionist,
                    PractitionerDept=PractitionerDepts.hollisticAndPreventative
                },
            };

            context.Practitioners.AddRange(practitioner);
            context.SaveChanges();






            var prescription = new Prescription[]
{
                new Prescription
                {
                    ID=1,
                    PrescriptionDate=DateTime.Parse("2022-09-09 16:23"),
                    PrescriptionPrice=11.90m,
                    PrescriptionQty=1,
                },

                new Prescription
                {
                    ID=2,
                    PrescriptionDate=DateTime.Parse("2022-08-09 12:30"),
                    PrescriptionPrice=20.90m,
                    PrescriptionQty=1
            
                },

                new Prescription
                {
                    ID=3,
                    PrescriptionDate=DateTime.Parse("2022-07-10 14:46"),
                    PrescriptionPrice=14.10m,
                    PrescriptionQty=2
                },

            };

            context.Prescriptions.AddRange(prescription);
            context.SaveChanges();



            var appointment = new Appointment[]
{
                new Appointment
                {
                    ID=1,
                    BookingDate=DateTime.Parse("2022-09-08 14:43"),
                    ApptDate=DateTime.Parse("2022-12-11 12:15"),
                    ApptLength=ApptLengths.fifeteen
                },

                new Appointment
                {
                    ID=2,
                    BookingDate=DateTime.Parse("2022-02-03 18:32"),
                    ApptDate=DateTime.Parse("2022-05-10 9:15"),
                    ApptLength=ApptLengths.sixty
                },

                new Appointment
                {
                    ID=3,
                    BookingDate=DateTime.Parse("2022-05-07 13:34"),
                    ApptDate=DateTime.Parse("2022-06-08 10:30"),
                    ApptLength=ApptLengths.twenty
                    
                },
            };

            context.Appointments.AddRange(appointment);
            context.SaveChanges();




            var account = new Account[]
{
                new Account
                {
                    ID=1,
                    AccountEmail="",
                    AccountPassword="",
                    AccountLevel=0,
                },

            };

            context.Accounts.AddRange(account);
            context.SaveChanges();
        }
    }
}
