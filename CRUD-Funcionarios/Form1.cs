using Microsoft.EntityFrameworkCore;
using CRUD_Funcionarios.Data;
using CRUD_Funcionarios.Repositorios.Interface;
using System.Configuration;
using CRUD_Funcionarios.Model;

namespace CRUD_Funcionarios
{
    public partial class Form1 : Form
    {
        private string connectionString; // String de conexão
        private FuncionarioDbContext dbContext;

        public Form1()
        {
            InitializeComponent();
            // Configure a string de conexão aqui (exemplo para um projeto baseado em XML):
            connectionString = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;
            dbContext = new FuncionarioDbContext(new DbContextOptionsBuilder<FuncionarioDbContext>().UseSqlServer(connectionString).Options);
        }

        private async void btnListar_Click(object sender, EventArgs e)
        {
            var funcionarioRepository = new FuncionariosRepositorio(dbContext);
            var funcionarios = await funcionarioRepository.BuscarTodosFuncionarios();

            listView1.Items.Clear();

            foreach (var funcionario in funcionarios)
            {
                ListViewItem item = new ListViewItem(funcionario.Nome);
                item.SubItems.Add(funcionario.Equipe); // Exibe o campo "Equipe"
                item.SubItems.Add(funcionario.Cargo);
                item.SubItems.Add(funcionario.Salario.ToString()); // Converte o salário para string
                item.SubItems.Add(funcionario.Horario);
                item.SubItems.Add(funcionario.Rg);
                item.SubItems.Add(funcionario.Nascimento.ToString()); // Converte a data de nascimento para string
                item.SubItems.Add(funcionario.Ctps);
                item.SubItems.Add(funcionario.Cpf);
                item.SubItems.Add(funcionario.Email);
                item.SubItems.Add(funcionario.Id.ToString());
                listView1.Items.Add(item);
            }
        }

        private void LimparCamposAdicao()
        {
            txtNome.Text = string.Empty;
            txtEquipe.Text = string.Empty;
            txtCargo.Text = string.Empty;
            txtEquipe.Text = string.Empty;
            txtSalario.Text = string.Empty;
            txtHorario.Text = string.Empty;
            txtRg.Text = string.Empty;
            txtCtps.Text = string.Empty;
            txtNascimento.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        private bool ValidarCamposAdicao()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtEquipe.Text) || string.IsNullOrWhiteSpace(txtCargo.Text) ||
                string.IsNullOrWhiteSpace(txtSalario.Text) || string.IsNullOrWhiteSpace(txtHorario.Text) || string.IsNullOrWhiteSpace(txtRg.Text) ||
                string.IsNullOrWhiteSpace(txtCtps.Text) || string.IsNullOrWhiteSpace(txtNascimento.Text) || string.IsNullOrWhiteSpace(txtCpf.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private async void AdicionarFuncionario()
        {
            string nome = txtNome.Text;
            string equipe = txtEquipe.Text;
            string cargo = txtCargo.Text;
            decimal salario;
            DateTime nascimento;
            string horario = txtHorario.Text;
            string rg = txtRg.Text;
            string ctps = txtCtps.Text;
            string cpf = txtCpf.Text;
            string email = txtEmail.Text;

            // Conversão segura para o campo "salario"
            if (decimal.TryParse(txtSalario.Text, out salario) == false)
            {
                MessageBox.Show("Salário inválido. Por favor, insira um valor numérico válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Conversão segura para o campo "nascimento"
            if (DateTime.TryParse(txtNascimento.Text, out nascimento) == false)
            {
                MessageBox.Show("Data de nascimento inválida. Por favor, insira uma data válida.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FuncionarioModel novoFuncionario = new FuncionarioModel
            {
                Nome = nome,
                Equipe = equipe,
                Cargo = cargo,
                Salario = salario,
                Horario = horario,
                Rg = rg,
                Ctps = ctps,
                Nascimento = nascimento,
                Cpf = cpf,
                Email = email
            };

            var funcionarioRepository = new FuncionariosRepositorio(dbContext);
            var funcionarioAdicionado = await funcionarioRepository.Adicionar(novoFuncionario);

            LimparCamposAdicao();
            btnListar_Click(null, null);

            MessageBox.Show("Funcionário adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposAdicao())
            {
                AdicionarFuncionario();
            }
        }

        private void PreencherCamposDeAtualizacao(FuncionarioModel funcionario)
        {
            txtUpdateNome.Text = funcionario.Nome;
            txtUpdateEquipe.Text = funcionario.Equipe; // Nome do campo atualizado
            txtUpdateCargo.Text = funcionario.Cargo;
            txtUpdateSalario.Text = funcionario.Salario.ToString(); // Preencha com o salário formatado
            txtUpdateHorario.Text = funcionario.Horario;
            txtUpdateRg.Text = funcionario.Rg;
            txtUpdateCtps.Text = funcionario.Ctps;
            txtUpdateNascimento.Text = funcionario.Nascimento.ToString("yyyy-MM-dd"); // Preencha com a data de nascimento formatada
            txtUpdateCpf.Text = funcionario.Cpf;
            txtUpdateEmail.Text = funcionario.Email;
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtbuscarId.Text, out int idFuncionario))
            {
                MessageBox.Show("ID inválido. Por favor, insira um ID numérico válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var funcionarioRepository = new FuncionariosRepositorio(dbContext);
            var funcionarioEncontrado = await funcionarioRepository.BuscarPorId(idFuncionario);

            if (funcionarioEncontrado != null)
            {
                PreencherCamposDeAtualizacao(funcionarioEncontrado);
            }
            else
            {
                MessageBox.Show("Funcionário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void AtualizarFuncionario(int idFuncionario, FuncionarioModel funcionarioAtualizado)
        {
            var funcionarioRepository = new FuncionariosRepositorio(dbContext);
            var funcionarioExistente = await funcionarioRepository.BuscarPorId(idFuncionario);

            if (funcionarioExistente != null)
            {
                funcionarioExistente.Nome = funcionarioAtualizado.Nome;
                funcionarioExistente.Equipe = funcionarioAtualizado.Equipe;
                funcionarioExistente.Cargo = funcionarioAtualizado.Cargo;
                funcionarioExistente.Salario = funcionarioAtualizado.Salario;
                funcionarioExistente.Horario = funcionarioAtualizado.Horario;
                funcionarioExistente.Rg = funcionarioAtualizado.Rg;
                funcionarioExistente.Ctps = funcionarioAtualizado.Ctps;
                funcionarioExistente.Nascimento = funcionarioAtualizado.Nascimento;
                funcionarioExistente.Cpf = funcionarioAtualizado.Cpf;
                funcionarioExistente.Email = funcionarioAtualizado.Email;

                await funcionarioRepository.Atualizar(funcionarioExistente, idFuncionario);

                MessageBox.Show("Funcionário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtUpdateNome.Text = string.Empty;
                txtUpdateEquipe.Text = string.Empty;
                txtUpdateCargo.Text = string.Empty;
                txtUpdateSalario.Text = string.Empty;
                txtUpdateHorario.Text = string.Empty;
                txtUpdateRg.Text = string.Empty;
                txtUpdateCtps.Text = string.Empty;
                txtUpdateNascimento.Text = string.Empty;
                txtUpdateCpf.Text = string.Empty;
                txtUpdateEmail.Text = string.Empty;
                txtbuscarId.Text = string.Empty;

                btnListar_Click(null, null); // Atualizar a lista após a atualização.
            }
            else
            {
                MessageBox.Show("Funcionário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtbuscarId.Text, out int idFuncionario))
            {
                MessageBox.Show("ID inválido. Por favor, insira um ID numérico válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nomeAtualizado = txtUpdateNome.Text;
            string equipeAtualizada = txtUpdateEquipe.Text;
            string cargoAtualizado = txtUpdateCargo.Text;
            decimal salarioAtualizado;
            DateTime nascimentoAtualizado;
            string horarioAtualizado = txtUpdateHorario.Text;
            string rgAtualizado = txtUpdateRg.Text;
            string ctpsAtualizado = txtUpdateCtps.Text;
            string cpfAtualizado = txtUpdateCpf.Text;
            string emailAtualizado = txtUpdateEmail.Text;

            // Conversão segura para o campo "salarioAtualizado"
            if (decimal.TryParse(txtUpdateSalario.Text, out salarioAtualizado) == false)
            {
                MessageBox.Show("Salário inválido. Por favor, insira um valor numérico válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Conversão segura para o campo "nascimentoAtualizado"
            if (DateTime.TryParse(txtUpdateNascimento.Text, out nascimentoAtualizado) == false)
            {
                MessageBox.Show("Data de nascimento inválida. Por favor, insira uma data válida.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FuncionarioModel funcionarioAtualizado = new FuncionarioModel
            {
                Nome = nomeAtualizado,
                Equipe = equipeAtualizada,
                Cargo = cargoAtualizado,
                Salario = salarioAtualizado,
                Horario = horarioAtualizado,
                Rg = rgAtualizado,
                Ctps = ctpsAtualizado,
                Nascimento = nascimentoAtualizado,
                Cpf = cpfAtualizado,
                Email = emailAtualizado
            };

            AtualizarFuncionario(idFuncionario, funcionarioAtualizado);

            // Limpar os campos após a atualização bem-sucedida.
            txtUpdateNome.Text = string.Empty;
            txtUpdateEquipe.Text = string.Empty;
            txtUpdateCargo.Text = string.Empty;
            txtUpdateSalario.Text = string.Empty;
            txtUpdateHorario.Text = string.Empty;
            txtUpdateRg.Text = string.Empty;
            txtUpdateCtps.Text = string.Empty;
            txtUpdateNascimento.Text = string.Empty;
            txtUpdateCpf.Text = string.Empty;
            txtUpdateEmail.Text = string.Empty;
            txtbuscarId.Text = string.Empty;
        }

        private async void btnBusca_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();

            if (!int.TryParse(BuscarPeloId.Text, out int idFuncionario))
            {
                MessageBox.Show("ID inválido. Por favor, insira um ID numérico válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var funcionarioRepository = new FuncionariosRepositorio(dbContext);
            var funcionarioEncontrado = await funcionarioRepository.BuscarPorId(idFuncionario);

            if (funcionarioEncontrado != null)
            {
                ListViewItem item = new ListViewItem(funcionarioEncontrado.Nome);
                item.SubItems.Add(funcionarioEncontrado.Equipe);
                item.SubItems.Add(funcionarioEncontrado.Cargo);
                item.SubItems.Add(funcionarioEncontrado.Salario.ToString()); // Adicione o campo "Salario"
                item.SubItems.Add(funcionarioEncontrado.Horario);
                item.SubItems.Add(funcionarioEncontrado.Rg);
                item.SubItems.Add(funcionarioEncontrado.Ctps);
                item.SubItems.Add(funcionarioEncontrado.Nascimento.ToString()); // Adicione o campo "Nascimento"
                item.SubItems.Add(funcionarioEncontrado.Cpf);
                item.SubItems.Add(funcionarioEncontrado.Email);
                listView2.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Funcionário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDeletar_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                if (int.TryParse(BuscarPeloId.Text, out int idFuncionario))
                {
                    var funcionarioRepository = new FuncionariosRepositorio(dbContext);
                    bool exclusaoBemSucedida = await funcionarioRepository.Apagar(idFuncionario);

                    if (exclusaoBemSucedida)
                    {
                        listView2.Items.Remove(listView2.SelectedItems[0]);
                        MessageBox.Show("Funcionário excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Falha ao excluir o funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ID inválido. Por favor, insira um ID numérico válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione um funcionário na Lista para excluir.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
