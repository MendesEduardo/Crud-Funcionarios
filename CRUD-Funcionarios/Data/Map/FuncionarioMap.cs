using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CRUD_Funcionarios.Model;

namespace CRUD_Funcionarios.Data.Map
{
    public class FuncionarioMap : IEntityTypeConfiguration<FuncionarioModel>
    {
        public void Configure(EntityTypeBuilder<FuncionarioModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Equipe).HasMaxLength(255); // Configuração para a propriedade "Equipe"
            builder.Property(x => x.Cargo).HasMaxLength(255);
            builder.Property(x => x.Salario).HasColumnType("decimal(18, 2)"); // Configuração para a propriedade "Salario"
            builder.Property(x => x.Horario).HasMaxLength(255);
            builder.Property(x => x.Rg).HasMaxLength(255);
            builder.Property(x => x.Ctps).HasMaxLength(255);
            builder.Property(x => x.Nascimento).HasColumnType("date"); // Configuração para a propriedade "Nascimento"
            builder.Property(x => x.Cpf).HasMaxLength(255);
            builder.Property(x => x.Email).HasMaxLength(255);
        }
    }
}
