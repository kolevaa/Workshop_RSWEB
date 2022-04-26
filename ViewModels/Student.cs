using Microsoft.AspNetCore.Mvc.Rendering;
using Workshop_RSWEB.Models;
namespace Workshop_RSWEB.ViewModels
{
    public class Student
    {
        public IList<Student> Students { get; set; }

        public SelectList firstname1 { get; set; }

        public SelectList lastname1 { get; set; }
      

        public SelectList index { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Indeks { get; set; }

        
    }
}
