using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CO659_TeamApp.Models
{
    public class Person
    {
        [Key]
        public int ID { get; set; }


        [DisplayName("First Name"), StringLength(20), Required]
        public string FirstName { get; set; }


        [DisplayName("Last Name"), StringLength(20), Required]
        public string LastName { get; set; }


        [DisplayName("DOB"), DataType(DataType.Date), Required]
        public DateTime DOB { get; set; }


        [DisplayName("House Number"), StringLength(5), Required]
        public string AddressHouseNo { get; set; }


        [DisplayName("Street"), StringLength(20), Required]
        public string AddressStreet { get; set; }


        [DisplayName("Address Line 2 [optional]"), StringLength(20)]
        public string AddressLineTwo { get; set; }


        [DisplayName("Town / City"), StringLength(20), Required]
        public string AddressTownCity { get; set; }


        [DisplayName("Postcode"), MinLength(5), StringLength(8), Required]
        public string AddressPostcode { get; set; }


        [DisplayName("Mobile"), Required, MinLength(11), StringLength(15)]
        public string MobileNumber { get; set; }

        // TODO: Last Name, First Name or First Name, Last Name?
        public string FullName
        {
            get
            {
                return LastName + (" ") + FirstName;
            }
        }

        // Navigation properties
        public virtual Account Account { get; set; }

        public virtual ICollection<Prescription> Prescriptions { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }

    }
}
