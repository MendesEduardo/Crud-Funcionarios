using Microsoft.EntityFrameworkCore;
using CRUD_Funcionarios.Data.Map;
using CRUD_Funcionarios.Model;

namespace CRUD_Funcionarios.Data
{
    public class FuncionarioDbContext : DbContext
    {
        public FuncionarioDbContext(DbContextOptions<FuncionarioDbContext> options) : base(options)
        {

        }
        public DbSet<FuncionarioModel> Funcionarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FuncionarioMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}