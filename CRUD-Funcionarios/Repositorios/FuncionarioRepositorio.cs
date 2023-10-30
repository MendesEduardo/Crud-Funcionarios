using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD_Funcionarios.Model; // Certifique-se de que FuncionarioModel esteja definido aqui

namespace CRUD_Funcionarios.Repositorios.Interface
{
    internal class FuncionariosRepositorio : IFuncionariosRepositorio
    {
        private readonly DbContext _dbContext; // Use o contexto de banco de dados apropriado

        public FuncionariosRepositorio(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<FuncionarioModel>> BuscarTodosFuncionarios()
        {
            return await _dbContext.Set<FuncionarioModel>().ToListAsync();
        }

        public async Task<FuncionarioModel> BuscarPorId(int id)
        {
            return await _dbContext.Set<FuncionarioModel>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<FuncionarioModel> Adicionar(FuncionarioModel funcionario)
        {
            _dbContext.Set<FuncionarioModel>().Add(funcionario);
            await _dbContext.SaveChangesAsync();

            return funcionario;
        }

        public async Task<FuncionarioModel> Atualizar(FuncionarioModel funcionario, int id)
        {
            FuncionarioModel funcionarioPorId = await BuscarPorId(id);

            if (funcionarioPorId == null)
            {
                throw new Exception($"Funcionario para o ID: {id} não foi encontrado no banco de dados!");
            }

            funcionarioPorId.Nome = funcionario.Nome;

            await _dbContext.SaveChangesAsync();

            return funcionarioPorId;
        }

        public async Task<bool> Apagar(int id)
        {
            FuncionarioModel funcionarioPorId = await BuscarPorId(id);

            if (funcionarioPorId == null)
            {
                throw new Exception($"Funcionario para o ID: {id} não foi encontrado no banco de dados!");
            }

            _dbContext.Set<FuncionarioModel>().Remove(funcionarioPorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
