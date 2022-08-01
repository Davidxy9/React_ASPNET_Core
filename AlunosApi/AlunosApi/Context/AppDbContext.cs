using AlunosApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AlunosApi.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Aluno>().HasData(
                new Aluno()
                {
                    Id = 1,
                    Name = "Maria da penha",
                    Email = "maria@hotmail.com",
                    Idade = 23,

                },
                new Aluno()
                {
                    Id = 2,
                    Name = "Joao Penha",
                    Email = "joao@hotmail.com",
                    Idade = 22,

                }
                );
        }
    }
}
