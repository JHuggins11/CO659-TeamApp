using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CO659_TeamApp.Models
{
    public class Patient
    {
        public int ID { get; set; }


        [DisplayName("First Name"), StringLength(20)]
        public string PatientFName { get; set; }


        [DisplayName("Last Name"), StringLength(20)]
        public string PatientLName { get; set; }


        [DisplayName("DOB"), DataType(DataType.Date)]
        public DateTime PatientDOB { get; set; }


        [DisplayName("House Number"), StringLength(5)]
        public string AddressHouseNo { get; set; }


        [DisplayName("Street"), StringLength(20)]
        public string AddressStreet { get; set; }


        [DisplayName("Address Line 2"), StringLength(20)]
        public string AddressLineTwo { get; set; }


        [DisplayName("Town / City"), StringLength(20)]
        public string AddressTownCity { get; set; }


        [DisplayName("Postcode"), MinLength(5), StringLength(8)]
        public string AddressPostcode { get; set; }


        [DisplayName("Mobile"), Required, MinLength(11), StringLength(15)]
        public string MobileNumber { get; set; }

        public string FullName
        {
            get
            {
                return PatientLName + (" ") + PatientFName;
            }
        }

        public virtual Account Account { get; set; }

        public virtual ICollection<Prescription> Prescriptions { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }

    }
}
