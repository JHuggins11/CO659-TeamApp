using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CO659_TeamApp.Models
{
    public class Medicine
    {
        [Key]
        public int ID { get; set; }


        [DisplayName("Medicine Name"), StringLength(30), Required]
        public string MedicineName { get; set; }


        [DisplayName("Medicine Type"), StringLength(30), Required]
        public string MedicineType { get; set; }


        [DisplayName("Dosage"), MaxLength(4), Required]
        public int MedicineDosage { get; set; }


        [DisplayName("Qty"), MaxLength(3), Required]
        public int MedicineQty { get; set; }


        [DisplayName("Medicine Availability"), Required]
        public bool? IsAvailable { get; set; }

    }
}
