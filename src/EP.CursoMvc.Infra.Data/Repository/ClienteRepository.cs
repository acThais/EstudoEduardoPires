using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EP.CursoMvc.Domain.Entities;
using EP.CursoMvc.Domain.Interfaces.Repository;

namespace EP.CursoMvc.Infra.Data.Repository
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {

        #region IClienteRepository Members

        public Cliente BuscarPorCPF(string cpf)
        {
            return Buscar(c => c.CPF == cpf).FirstOrDefault();
        }

        public Cliente BuscarPorEmail(string email)
        {
            return Buscar(c => c.Email == email).FirstOrDefault();
        }

        #endregion

    }
}
