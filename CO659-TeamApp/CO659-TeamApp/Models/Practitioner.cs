using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CO659_TeamApp.Models
{


    public enum PractitionerTitles
    {
        [Display(Name = "Consultant")]
        consultant,
        [Display(Name = "General Practitioner")]
        generalPractitioner,
        [Display(Name = "Emergency Medicine Doctor")]
        emergencyMedicineDoctor,
        [Display(Name = "Gynaecologist")]
        gynaecologist,
        [Display(Name = "Obstetrician")]
        obstetrician,
        [Display(Name = "Paediatrician")]
        paediatrician,
        [Display(Name = "Physician")]
        Physician,
        [Display(Name = "Sports and Exercise Medicine")]
        sportsMedicine,
        [Display(Name = "Nutritionist")]
        nutritionist,
        [Display(Name = "Other")]
        other
    }

    public enum PractitionerDepts
    {
        [Display(Name = "Consultancy")]
        consultancy,
        [Display(Name = "General")]
        general,
        [Display(Name = "Emergency")]
        emergency,
        [Display(Name = "Sexual Health")]
        sexualHealth,
        [Display(Name = "Paediatrics")]
        paediatrics,
        [Display(Name = "Hollistic and Preventative")]
        hollisticAndPreventative,
        [Display(Name = "Other")]
        other
    }
    public class Practitioner
    {
        public int ID { get; set; }


        [DisplayName("First Name"), StringLength(20)]
        public string PractitionerFName { get; set; }


        [DisplayName("Last Name"), StringLength(20)]
        public string PractitionerLName { get; set; }



        public PractitionerTitles? PractitionerTitle { get; set; }
        public PractitionerDepts? PractitionerDept { get; set; }


        public string FullName
        {
            get
            {
                return PractitionerLName + (" ") + PractitionerFName;
            }
        }

        public virtual Account Account { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }

        public virtual ICollection<Prescription> Prescriptions { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
