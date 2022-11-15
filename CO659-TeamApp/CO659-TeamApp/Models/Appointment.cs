using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CO659_TeamApp.Models
{

    public enum ApptLength
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
        public int ID { get; set; }


        [DisplayName("Booking Date"), DataType(DataType.Date)]
        public DateTime BookingDate { get; set; }



        [DisplayName("Booking Time"), DataType(DataType.Date)]
        public DateTime BookingTime { get; set; }



        [DisplayName("Appointment Date"), DataType(DataType.Date)]
        public DateTime ApptDate { get; set; }


        [DisplayName("Appointment Time"), DataType(DataType.Date)]
        public DateTime ApptTime { get; set; }


        public ApptLength? ApptLength { get; set; }


        public string FullBooking
        {
            get
            {
                return BookingTime + (" ") + BookingDate;
            }
        }

        public string FullAppt
        {
            get
            {
                return ApptTime + (" ") + ApptDate;
            }
        }


        public ICollection<Patient> Patient { get; set; }

        public ICollection<Practitioner> Practitioner { get; set; }
    }
}
