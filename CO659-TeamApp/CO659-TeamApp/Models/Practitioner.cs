using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Identity;

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

    public class Practitioner : Person
    {
<<<<<<< HEAD
        [Key]
        public int ID { get; set; }


        //[DisplayName("First Name"), StringLength(20), Required]
        //public string PractitionerFName { get; set; }


        //[DisplayName("Last Name"), StringLength(20), Required]
        //public string PractitionerLName { get; set; }



        public PractitionerTitles? PractitionerTitle { get; set; }
        public PractitionerDepts? PractitionerDept { get; set; }


        //public string FullName
        //{
        //    get
        //    {
        //        return PractitionerLName + (" ") + PractitionerFName;
        //    }
        //}

=======
        public PractitionerTitles? PractitionerTitle { get; set; }
        public PractitionerDepts? PractitionerDept { get; set; }

>>>>>>> 536bf4d56ed39db46961e309df607069e00ff33b
        // Navigation properties
        public virtual ICollection<Person> Patients { get; set; }

        /// TODO: Don't think we need these properties here anymore?
        /* public virtual ICollection<Prescription> Prescriptions { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; } */
    }
}
