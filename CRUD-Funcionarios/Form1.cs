using System;
using System.Windows.Forms;
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
                item.SubItems.Add(funcionario.Sobrenome);
                item.SubItems.Add(funcionario.Cargo);
                listView1.Items.Add(item);
            }
        }

        private void LimparCamposAdicao()
        {
            txtNome.Text = string.Empty;
            txtSobrenome.Text = string.Empty;
            txtCargo.Text = string.Empty;
        }

        private bool ValidarCamposAdicao()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtSobrenome.Text) || string.IsNullOrWhiteSpace(txtCargo.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private async void AdicionarFuncionario()
        {
            string nome = txtNome.Text;
            string sobrenome = txtSobrenome.Text;
            string cargo = txtCargo.Text;

            FuncionarioModel novoFuncionario = new FuncionarioModel
            {
                Nome = nome,
                Sobrenome = sobrenome,
                Cargo = cargo
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
            txtUpdateSobrenome.Text = funcionario.Sobrenome;
            txtUpdateCargo.Text = funcionario.Cargo;
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
                funcionarioExistente.Sobrenome = funcionarioAtualizado.Sobrenome;
                funcionarioExistente.Cargo = funcionarioAtualizado.Cargo;

                await funcionarioRepository.Atualizar(funcionarioExistente, idFuncionario);

                MessageBox.Show("Funcionário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtUpdateNome.Text = string.Empty;
                txtUpdateSobrenome.Text = string.Empty;
                txtUpdateCargo.Text = string.Empty;
                txtbuscarId.Text = string.Empty;
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
            string sobrenomeAtualizado = txtUpdateSobrenome.Text;
            string cargoAtualizado = txtUpdateCargo.Text;

            FuncionarioModel funcionarioAtualizado = new FuncionarioModel
            {
                Nome = nomeAtualizado,
                Sobrenome = sobrenomeAtualizado,
                Cargo = cargoAtualizado
            };

            AtualizarFuncionario(idFuncionario, funcionarioAtualizado);
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
                item.SubItems.Add(funcionarioEncontrado.Sobrenome);
                item.SubItems.Add(funcionarioEncontrado.Cargo);
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
