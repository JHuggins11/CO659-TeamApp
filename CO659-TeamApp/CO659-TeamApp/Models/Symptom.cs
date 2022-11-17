using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CO659_TeamApp.Models
{

    public enum SymptomSeverities
    {
        [Display(Name = "mild")]
        mild,
        [Display(Name = "regular")]
        regular,
        [Display(Name = "severe")]
        severe,
        [Display(Name = "other")]
        other
    }

    public class Symptom
    {
        [Key]
        public int ID { get; set; }


        [DisplayName("Symptom Name"), StringLength(20), Required]
        public string SymptomName { get; set; }


        [DisplayName("Symptom Type"), StringLength(20), Required]
        public string SymptomType { get; set; }


        [DisplayName("Symptom Details"), StringLength(200), Required]
        public string SymptomDetails { get; set; }


        public SymptomSeverities? SymptomSeverity { get; set; }
    }
}
