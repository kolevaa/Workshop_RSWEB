using System.ComponentModel.DataAnnotations;

namespace Workshop_RSWEB.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        
        [Required]
        [StringLength(50)]
        [Display(Name = "Indeks")]
        public string Index { get; set; }



        public string FullName
        {
            get { return String.Format("{0} {1}", FirstName, LastName); }
        }

        public ICollection<StudentPredmet>? Predmets{ get; set; }
    }

}

