
namespace CRUD_Funcionarios.Model
{
    public class FuncionarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Equipe { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public string Horario { get; set; }
        public string Rg { get; set; }
        public string Ctps { get; set; }
        public DateTime Nascimento { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
    }

}
