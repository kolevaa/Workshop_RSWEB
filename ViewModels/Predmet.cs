using Microsoft.AspNetCore.Mvc.Rendering;
using Workshop_RSWEB.Models;

namespace Workshop_RSWEB.ViewModels
{
    public class Predmet
    {
        public IList<Predmet> Predmets { get; set; }

        public SelectList title { get; set; }

        public SelectList semestar { get; set; }
        public SelectList smer { get; set; }
        public string Title{ get; set; }

        public string Semestar { get; set; }

        public string Smer { get; set; }
    }
        
}

