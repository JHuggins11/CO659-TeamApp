using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CO659_TeamApp.Models
{
    public class Practitioner
    {
        public int ID { get; set; }


        [DisplayName("First Name"), StringLength(20)]
        public string PractitionerFName { get; set; }


        [DisplayName("Last Name"), StringLength(20)]
        public string PractitionerLName { get; set; }


        [DisplayName("Title"), StringLength(20)]
        public string PractitionerTitle { get; set; }


        [DisplayName("Department"), StringLength(20)]
        public string PractitionerDepartment { get; set; }


        public string FullName
        {
            get
            {
                return PractitionerLName + (" ") + PractitionerFName;
            }
        }

        public ICollection<Account> Account { get; set; }
    }
}
