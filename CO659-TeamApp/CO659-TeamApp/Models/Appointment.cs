using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CO659_TeamApp.Models
{

    public enum ApptLengths
    {
        [Display(Name = "10 minutes")]
        ten,
        [Display(Name = "15 minutes")]
        fifeteen,
        [Display(Name = "20 minutes")]
        twenty,
        [Display(Name = "30 minutes")]
        thirty,
        [Display(Name = "45 minutes")]
        fourtyFive,
        [Display(Name = "60 minutes")]
        sixty,
        [Display(Name = "60 + minutes")]
        sixtyPlus,
        [Display(Name = "other")]
        other
    }
    public class Appointment
    {
        [Key]
        public int AppointmentID { get; set; }

        // Foreign keys
        public int PersonID { get; set; }



        [DisplayName("Booking Date"), DataType(DataType.Date), Required]
        public DateTime BookingDate { get; set; }


        [DisplayName("Appointment Date"), DataType(DataType.Date), Required]
        public DateTime ApptDate { get; set; }


        [DisplayName("Appointment Duration"), Required]
        public ApptLengths? ApptLength { get; set; }



        // A person can add one sypmtom when booking an appointment
        public virtual Symptom Symptoms { get; set; }
        public virtual Practitioner Practitioners { get; set; }
        public virtual Person People { get; set; }

        // TODO
        // surely an appointment would only have one person? I.e., removing ICollection
        // of Appointments in Person Model and using... 
        // public virtual Person Person { get; set; } here
        // same for Prescriptions

    }
}
