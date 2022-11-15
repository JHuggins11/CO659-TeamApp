using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CO659_TeamApp.Models
{
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


        [DisplayName("Appointment Length"), MaxLength(2)]
        public int ApptLength { get; set; }


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
