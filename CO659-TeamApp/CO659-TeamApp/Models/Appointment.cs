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
        public int ID { get; set; }


        [DisplayName("Booking Date"), DataType(DataType.Date), Required]
        public DateTime BookingDate { get; set; }


        [DisplayName("Appointment Date"), DataType(DataType.Date), Required]
        public DateTime ApptDate { get; set; }


        [DisplayName("Appointment Duration"), Required]
        public ApptLengths? ApptLength { get; set; }

    }
}
