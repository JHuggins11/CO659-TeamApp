using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CO659_TeamApp.Models
{
    public class Symptom
    {
        public int ID { get; set; }


        [DisplayName("Symptom Name"), StringLength(20)]
        public string SymptomName { get; set; }


        [DisplayName("Symptom Type"), StringLength(20)]
        public string SymptomType { get; set; }


        [DisplayName("Symptom Details"), StringLength(200)]
        public string SymptomDetails { get; set; }


        [DisplayName("Symptom Severuty"), MaxLength(1)]
        public int SymptomSeverity { get; set; }
    }
}
