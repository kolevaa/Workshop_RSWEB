using Microsoft.AspNetCore.Mvc.Rendering;
using Workshop_RSWEB.Models;
namespace Workshop_RSWEB.ViewModels
{
    public class Profesor
    {
        public IList<Profesor> Profesors{ get; set; }

        public SelectList firstname { get; set; }

        public SelectList lastname { get; set; }
        public SelectList stepenobrazovanie { get; set; }

        public SelectList akademskirang { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string StepenObrazovanie { get; set; }

        public string AkademskiRang{ get; set; }

       
    }
}

