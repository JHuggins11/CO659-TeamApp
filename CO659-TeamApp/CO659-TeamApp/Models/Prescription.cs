using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace CO659_TeamApp.Models
{
    public class Prescription
    {
        public int ID { get; set; }


        [DisplayName("Prescription Order Date"), DataType(DataType.Date)]
        public DateTime PrescriptionDate { get; set; }


        [DisplayName("Prescription Order Time"), DataType(DataType.Date)]
        public DateTime PrescriptionTime { get; set; }


        [DisplayName("Prescription Price"), Required, DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal PrescriptionPrice { get; set; }


        [DisplayName("Qty"), MaxLength(3)]
        public int PrescriptionQty { get; set; }



        public int TotalPrescriptionPrice
        {
            get
            {
                return (int)(PrescriptionQty * PrescriptionPrice);
            }
        }

        //public virtual Patient Patient { get; set; }
        //public virtual Practitioner Practitioner { get; set; }

        public virtual ICollection<Medicine> Medicines { get; set; }

    }
}
