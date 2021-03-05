using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Tarefa3_MVC.Models;

namespace Tarefa3_MVC.DAL
{
    public class TFContext : DbContext
    {
        public TFContext() : base("TFConnectionString") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Universidade> Universidades { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
    }
}