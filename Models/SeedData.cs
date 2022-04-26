using Microsoft.EntityFrameworkCore;
using Workshop_RSWEB.Data;
namespace Workshop_RSWEB.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Workshop_RSWEBContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Workshop_RSWEBContext>>()))
            {
                
                if (context.Predmet.Any() || context.Profesor.Any() || context.Student.Any())
                {
                    return;   // DB has been seeded
                }

                context.Profesor.AddRange(
                    new Profesor { /*Id = 1, */FirstName = "Suzana", LastName = "Miceva", StepenObrazovanie="Doktorski", AkademskiRang="redovenprofesor" },
                    new Profesor { /*Id = 2, */FirstName = "Ivan", LastName = "Joleski", StepenObrazovanie="Doktorski", AkademskiRang="vonredenprofesor"},
                    new Profesor{ /*Id = 3, */FirstName = "Ile", LastName = "Mircevski", StepenObrazovanie="Magisterski", AkademskiRang="docent"}
                );
                context.SaveChanges();

                context.Student.AddRange(
                    new Student { /*Id = 1, */FirstName = "Hristijan", LastName = "Dimov", Index="198/2016" },
                    new Student { /*Id = 2, */FirstName = "Marija", LastName = "Nakova", Index = "188/2017" },
                    new Student { /*Id = 3, */FirstName = "Darija", LastName = "Lazareva", Index = "44/2017" },
                    new Student { /*Id = 4, */FirstName = "Marko", LastName = "Murov", Index = "205/2015" },
                    new Student{ /*Id = 5, */FirstName = "Petar", LastName = "Petrovski", Index = "166/2015" }
                    
                );
                context.SaveChanges();

                context.Predmet.AddRange(
                    new Predmet
                    {
                        //Id = 1,
                        Title = "   Bezbednost i zastita na kompjuterski sistemi i mrezi",
                        Semestar=6,
                        Smer="KTI",
                        ProfesorId = context.Profesor.Single(d => d.FirstName == "Ivan" && d.LastName == "Joleski").Id
                    },
                    new Predmet
                    {
                        //Id = 2,
                        Title = "Diskretna matematika",
                        Semestar = 4,
                        Smer = "site",
                        ProfesorId = context.Profesor.Single(d => d.FirstName == "Suzana" && d.LastName == "Miceva").Id
                    },
                    new Predmet
                    {
                        //Id = 3,
                        Title = "Matlab",
                        Semestar = 2,
                        Smer = "site",
                     ProfesorId = context.Profesor.Single(d => d.FirstName == "Ile" && d.LastName == "Mircevski").Id
                    },
                    new Predmet
                    {
                        //Id = 4,
                        Title = "Ruski jazik",
                        Semestar = 1,
                        Smer = "site",
                        ProfesorId = context.Profesor.Single(d => d.FirstName == "Suzana" && d.LastName == "Miceva").Id
                    }
                );
                context.SaveChanges();

                context.StudentPredmet.AddRange(
                    new StudentPredmet { StudentId = 1, PredmetId = 1 },
                    new StudentPredmet { StudentId = 2, PredmetId = 1 },
                    new StudentPredmet { StudentId = 3, PredmetId = 1 },
                    new StudentPredmet { StudentId = 4, PredmetId = 2 },
                    new StudentPredmet { StudentId = 5, PredmetId = 2 },
                    new StudentPredmet { StudentId = 2, PredmetId = 2 },
                    new StudentPredmet { StudentId = 4, PredmetId = 3 },
                    new StudentPredmet { StudentId = 5, PredmetId = 3 },
                    new StudentPredmet { StudentId = 4, PredmetId = 4 },
                    new StudentPredmet { StudentId = 5, PredmetId = 4 }

                );
                context.SaveChanges();
            }
        }
    }
}

    

