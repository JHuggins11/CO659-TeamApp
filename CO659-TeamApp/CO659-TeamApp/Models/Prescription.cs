using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace CO659_TeamApp.Models
{
    public class Prescription
    {
        [Key]
        public int PrescriptionID { get; set; }

        public int PersonID { get; set; }   
        


        [DisplayName("Prescription Order Date"), DataType(DataType.Date), Required]
        public DateTime PrescriptionDate { get; set; }


        [DisplayName("Prescription Price"), Required, DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal PrescriptionPrice { get; set; }


        [DisplayName("Qty"), MaxLength(3), Required]
        public int PrescriptionQty { get; set; }


        public int TotalPrescriptionPrice
        {
            get
            {
                return (int)(PrescriptionQty * PrescriptionPrice);
            }
        }

        // A perscription can have multiple medicines 
        public virtual ICollection<Medicine> Medicines { get; set; }
        public virtual Person People { get; set; }

    }
}
