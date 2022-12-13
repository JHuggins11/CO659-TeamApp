using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CO659_TeamApp.Models
{

    // TODO: Remove Account 
    public class Account
    {
        [Key]
        public int ID { get; set; }


        [DisplayName("Email"), MinLength(5), StringLength(30), Required]
        public string AccountEmail { get; set; }


        [DisplayName("Password"), MinLength(5), StringLength(30), Required]
        public string AccountPassword { get; set; }

        // ToDo: Check this works
        [DisplayName("Account Level"), Required]
        public int AccountLevel { get; set; }

        // ToDo: is this needed?
        //public virtual Patient Patient { get; set; }
        //public virtual Practitioner Practitioner { get; set; }  
    }
}
