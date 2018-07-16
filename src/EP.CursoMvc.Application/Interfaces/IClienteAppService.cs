using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EP.CursoMvc.Application.ViewModels;
using EP.CursoMvc.Domain.Entities;

namespace EP.CursoMvc.Application.Interfaces
{
    public interface IClienteAppService : IDisposable
    {

        ClienteEnderecoViewModel Adicionar(ClienteEnderecoViewModel clienteEnderecoViewModel);

        ClienteViewModel ObterPorId(Guid Id);

        IEnumerable<ClienteViewModel> ObterTodos(int s, int t);

        ClienteViewModel BuscarPorCPF(string cpf);

        ClienteViewModel BuscarPorEmail(string email);

        ClienteViewModel Atualizar(ClienteViewModel clienteViewModel);

        void Remover(Guid Id);

        void Dispose();

		void Atualizar(Cliente clienteDomain);
	}
}
