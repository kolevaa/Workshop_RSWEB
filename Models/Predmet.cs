using System.ComponentModel.DataAnnotations;


namespace Workshop_RSWEB.Models
{
    public class Predmet
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }
        

        [Range(1, 8)]
        [DataType(DataType.Text)]
        public decimal Semestar{ get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Smer{ get; set; }


        

        public ICollection<ProfesorPredmet>? Profesors { get; set; }
        public int ProfesorId { get; internal set; }
    }

}

