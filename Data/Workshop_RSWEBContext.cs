#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Workshop_RSWEB.Models;

namespace Workshop_RSWEB.Data
{
    public class Workshop_RSWEBContext : DbContext
    {
        public Workshop_RSWEBContext (DbContextOptions<Workshop_RSWEBContext> options)
            : base(options)
        {
        }

        public DbSet<Workshop_RSWEB.Models.Profesor> Profesor { get; set; }

        public DbSet<Workshop_RSWEB.Models.Predmet> Predmet { get; set; }

        public DbSet<Workshop_RSWEB.Models.Student> Student { get; set; }

        public DbSet<ProfesorPredmet> ProfesorPredmet { get; set; }

        public DbSet<StudentPredmet> StudentPredmet { get; set; }


    }
}
