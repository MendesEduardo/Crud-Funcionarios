using CRUD_Funcionarios.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Funcionarios.Repositorios.Interface
{
    internal interface IFuncionariosRepositorio
    {
        Task<List<FuncionarioModel>> BuscarTodosFuncionarios();
        Task<FuncionarioModel> BuscarPorId(int id);
        Task<FuncionarioModel> Adicionar(FuncionarioModel usuario);
        Task<FuncionarioModel> Atualizar(FuncionarioModel usuario, int id);
        Task<bool> Apagar(int id);
    }
}
