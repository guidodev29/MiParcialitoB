using Microsoft.EntityFrameworkCore;

namespace MiParcialitoB.Models
{
    public class ParcialDbContext : DbContext 
    {
        public ParcialDbContext(DbContextOptions<ParcialDbContext> options) : base(options)
        {
        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //Configuring the Connection String
        //    optionsBuilder.UseSqlServer(@"Server=qa.negociostecnologicos.net;Database=HG100721B;User=desarrolloWebUfg;Password=<BTj$jrrLV2~-4Yp1vT-");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //use this to configure the model
        }

        public DbSet<Estudiante> Estudianates { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Inscripcion> Inscripciones { get; set; }

    }
}
