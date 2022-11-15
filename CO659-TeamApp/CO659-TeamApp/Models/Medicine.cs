using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CO659_TeamApp.Models
{
    public class Medicine
    {
        public int ID { get; set; }


        [DisplayName("Medicine Name"), StringLength(30)]
        public string MedicineName { get; set; }


        [DisplayName("Medicine Type"), StringLength(30)]
        public string MedicineType { get; set; }


        [DisplayName("Dosage"), MaxLength(4)]
        public int MedicineDosage { get; set; }


        [DisplayName("Qty"), MaxLength(3)]
        public int MedicineQty { get; set; }


        [DisplayName("Medicine Availability")]
        public bool? IsAvailable { get; set; }
    }
}
