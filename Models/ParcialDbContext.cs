using Microsoft.EntityFrameworkCore;

namespace MiParcialitoB.Models
{
    public class ParcialDbContext : DbContext 
    {
        public ParcialDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Configuring the Connection String
            optionsBuilder.UseSqlServer(@"Server=qa.negociostecnologicos.net;Database=tuBaseDeDatos;User=desarrolloWebUfg;Password=<BTjSjrLV2~4Yp1vT~;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //use this to configure the model
        }

        public DbSet<Estudiante> Estudianates { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Inscripcion> Inscripciones { get; set; }

    }
}
