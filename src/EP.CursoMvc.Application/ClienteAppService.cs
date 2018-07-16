using System;
using System.Collections.Generic;
using EP.CursoMvc.Application.Interfaces;
using EP.CursoMvc.Domain.Entities;
using EP.CursoMvc.Infra.Data.Repository;
using System.Linq;
using System.Text;
using EP.CursoMvc.Application.ViewModels;
using AutoMapper;

namespace EP.CursoMvc.Application
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly ClienteRepository _clienteRepository = new ClienteRepository();


        #region IClienteAppService Members

        public ClienteEnderecoViewModel Adicionar(ClienteEnderecoViewModel clienteEnderecoViewModel)
        {
            var cliente = Mapper.Map<ClienteEnderecoViewModel, Cliente>(clienteEnderecoViewModel);
            var endereco = Mapper.Map<ClienteEnderecoViewModel, Endereco>(clienteEnderecoViewModel);
            cliente.Enderecos.Add(endereco);
            _clienteRepository.Adicionar(cliente);
            return clienteEnderecoViewModel;
        }

        public ClienteViewModel ObterPorId(Guid Id)
        {
            return Mapper.Map<Cliente, ClienteViewModel>(_clienteRepository.ObterPorId(Id));
        }

        public IEnumerable<ClienteViewModel> ObterTodos(int s, int t)
        {
            return Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteRepository.ObterTodos(s,t));
        }

        public ClienteViewModel BuscarPorCPF(string cpf)
        {
            throw new NotImplementedException();
        }

        public ClienteViewModel BuscarPorEmail(string email)
        {
            throw new NotImplementedException();
        }

        public ClienteViewModel Atualizar(ClienteViewModel clienteViewModel)
        {
            _clienteRepository.Atualizar(Mapper.Map<ClienteViewModel, Cliente>(clienteViewModel));
            return clienteViewModel;
        }

        public void Remover(Guid Id)
        {
            _clienteRepository.Remover(Id);
            //throw new NotImplementedException();
        }

        public void Dispose()
        {
            _clienteRepository.Dispose();
            GC.ReRegisterForFinalize(this);
        }

		public void Atualizar(Cliente clienteDomain)
		{
			_clienteRepository.Atualizar(clienteDomain);
		}

		#endregion
	}
}
