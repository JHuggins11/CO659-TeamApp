using CO659_TeamApp.Models;
using Microsoft.AspNetCore.Identity;
using System.Diagnostics;
using System.Drawing.Text;

namespace CO659_TeamApp.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        { 

            AddSymptom(context);
            AddMedicine(context);
            AddPerson(context);
            AddPractitioner(context);
            AddPrescription(context);
            AddAppointment(context);

        }


        private static void AddSymptom(ApplicationDbContext context)
        {

            if (context.Symptoms.Any())
            {
                return;
            }

            var symptom = new Symptom[]
            {
                new Symptom
                {
                    AppointmentID=1,
                    SymptomName="Impetigo",
                    SymptomType="Rash",
                    SymptomDetails="Red, itchy sores",
                    SymptomSeverity = SymptomSeverities.mild
                },

                new Symptom
                {
                    AppointmentID=2,
                    SymptomName="Arthritis",
                    SymptomType="Joints",
                    SymptomDetails="Pain and inflammation in a joint",
                    SymptomSeverity = SymptomSeverities.severe
                },

                new Symptom
                {   
                    AppointmentID = 3,
                    SymptomName="Laryngitis",
                    SymptomType="Throat",
                    SymptomDetails="Inflammation of the larynx",
                    SymptomSeverity = SymptomSeverities.regular
                },
            };

            context.Symptoms.AddRange(symptom);
            context.SaveChanges();
        }




        private static void AddMedicine(ApplicationDbContext context)
        {

            if (context.Medicines.Any())
            {
                return;
            }

            var medicine = new Medicine[]
            {
                new Medicine
                {
                    PrescriptionID=1,
                    MedicineName="Codeine",
                    MedicineType="Pain refielf",
                    MedicineDosage=200,
                    MedicineQty = 1,
                    IsAvailable = true
                },

                new Medicine
                {
                    PrescriptionID=1,
                    MedicineName="Mupirocin",
                    MedicineType="Antibiotics",
                    MedicineDosage=1,
                    MedicineQty = 1,
                    IsAvailable = true
                },

                new Medicine
                {
                    PrescriptionID=2,
                    MedicineName="Inhaler",
                    MedicineType="Oral",
                    MedicineDosage=1,
                    MedicineQty = 2,
                    IsAvailable = true
                },

                new Medicine
                {
                    PrescriptionID=2,
                    MedicineName="Inhaler",
                    MedicineType="Oral",
                    MedicineDosage=1,
                    MedicineQty = 1,
                    IsAvailable = true
                },

                 new Medicine
                {
                    PrescriptionID=3,
                    MedicineName="Amoxiciillian",
                    MedicineType="Anti-depressant",
                    MedicineDosage=2,
                    MedicineQty = 1,
                    IsAvailable = true
                },

                 new Medicine
                {
                    PrescriptionID=4,
                    MedicineName="Paracetomal",
                    MedicineType="Painkiller",
                    MedicineDosage=2,
                    MedicineQty = 2,
                    IsAvailable = true
                },
            };

            context.Medicines.AddRange(medicine);
            context.SaveChanges();
        }



        private static void AddPerson(ApplicationDbContext context)
        {

            if (context.People.Any())
            {
                return;
            }


            var person = new Person[]
{


                new Person
                {
                    FirstName="Izzy",
                    LastName="Thorpe",
                    DOB=DateTime.Parse("1995-11-01"),
                    AddressHouseNo="8",
                    AddressStreet="Fairview Close",
                    AddressLineTwo="Barts Way",
                    AddressTownCity="Harpenden",
                    AddressPostcode="AL1 5GF",
                    MobileNumber="07587323761"
                },

                new Person
                {
                    FirstName="Kayley",
                    LastName="Syrett",
                    DOB=DateTime.Parse("1990-02-10"),
                    AddressHouseNo="21",
                    AddressStreet="Lantern Lane",
                    AddressLineTwo="Sleepside",
                    AddressTownCity="High Wycome",
                    AddressPostcode="HP14 7GF",
                    MobileNumber="07647288342"
                },

                new Person
                {
                    FirstName="Jason",
                    LastName="Huggins",
                    DOB=DateTime.Parse("1999-03-09"),
                    AddressHouseNo="39",
                    AddressStreet="Fox Close",
                    AddressLineTwo="Little shining",
                    AddressTownCity="High Wycombe",
                    AddressPostcode="HP13 5HG",
                    MobileNumber="07656539932"
                },
        };

            context.People.AddRange(person);
            context.SaveChanges();

        }



        private static void AddPractitioner(ApplicationDbContext context)
        {

            if (context.Practitioners.Any())
            {
                return;
            }

            var practitioner = new Practitioner[]
{
                new Practitioner
                {
                    FirstName="Maria",
                    LastName="Cox",
                    DOB=DateTime.Parse("1995-12-01"),
                    AddressHouseNo="2",
                    AddressStreet="Milton Close",
                    AddressLineTwo="Bakers Way",
                    AddressTownCity="Welwyn",
                    AddressPostcode="WG3 7GH",
                    MobileNumber="07647462938",
                    PractitionerTitle=PractitionerTitles.generalPractitioner,
                    PractitionerDept=PractitionerDepts.general
                },

                new Practitioner
                {
                    FirstName="Prathna",
                    LastName="Reed",
                    DOB=DateTime.Parse("1972-06-03"),
                    AddressHouseNo="6",
                    AddressStreet="Hollybush Lane",
                    AddressLineTwo="Sleepside",
                    AddressTownCity="Wheathampstead",
                    AddressPostcode="AL4 5HH",
                    MobileNumber="07658832464",
                    PractitionerTitle=PractitionerTitles.paediatrician,
                    PractitionerDept=PractitionerDepts.paediatrics
                },

                new Practitioner
                {
                    FirstName="Thomas",
                    LastName="Penn",
                    DOB=DateTime.Parse("1999-01-09"),
                    AddressHouseNo="24",
                    AddressStreet="Crabtree Lane",
                    AddressLineTwo="Walkers Close",
                    AddressTownCity="Harpenden",
                    AddressPostcode="AL5 5HP",
                    MobileNumber="07676563343",
                    PractitionerTitle=PractitionerTitles.nutritionist,
                    PractitionerDept=PractitionerDepts.hollisticAndPreventative
                },
            };

            context.Practitioners.AddRange(practitioner);
            context.SaveChanges();
        }



        private static void AddPrescription(ApplicationDbContext context)
        {

            if (context.Prescriptions.Any())
            {
                return;
            }


            var prescription = new Prescription[]
{
                new Prescription
                {
                    PersonID=1,
                    PrescriptionDate=DateTime.Parse("2022-09-09 16:23"),
                    PrescriptionPrice=11.90m,
                    PrescriptionQty=1,
                },

                new Prescription
                {
                    PersonID=1,
                    PrescriptionDate=DateTime.Parse("2022-08-09 12:30"),
                    PrescriptionPrice=20.90m,
                    PrescriptionQty=1
                },

                new Prescription
                {
                    PersonID=2,
                    PrescriptionDate=DateTime.Parse("2022-07-10 14:46"),
                    PrescriptionPrice=14.10m,
                    PrescriptionQty=1
                },

                new Prescription
                {
                    PersonID=3,
                    PrescriptionDate=DateTime.Parse("2022-07-10 14:46"),
                    PrescriptionPrice=19.10m,
                    PrescriptionQty=1
                },

            };


            context.Prescriptions.AddRange(prescription);
            context.SaveChanges();

        }



        private static void AddAppointment(ApplicationDbContext context)
        {

            if (context.Appointments.Any())
            {
                return;
            }


            var appointment = new Appointment[]
{
                new Appointment
                {
                    PersonID=1,
                    //SymptomID=1,
                    BookingDate=DateTime.Parse("2022-09-08 14:43"),
                    ApptDate=DateTime.Parse("2022-12-11 12:15"),
                    ApptLength=ApptLengths.fifeteen
                },

                new Appointment
                {
                    PersonID=2,
                    //SymptomID=2,
                    BookingDate=DateTime.Parse("2022-02-03 18:32"),
                    ApptDate=DateTime.Parse("2022-05-10 9:15"),
                    ApptLength=ApptLengths.sixty
                },

                new Appointment
                {
                    PersonID=3,
                    //SymptomID=3,
                    BookingDate=DateTime.Parse("2022-05-07 13:34"),
                    ApptDate=DateTime.Parse("2022-06-08 10:30"),
                    ApptLength=ApptLengths.twenty
                },
            };

            context.Appointments.AddRange(appointment);
            context.SaveChanges();
        }
    }
}
