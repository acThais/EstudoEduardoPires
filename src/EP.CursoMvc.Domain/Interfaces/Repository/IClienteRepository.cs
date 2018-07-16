using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EP.CursoMvc.Domain.Entities;

namespace EP.CursoMvc.Domain.Interfaces.Repository
{
    public interface IClienteRepository : IRepositoryBase<Cliente>
    {
        Cliente BuscarPorCPF(string cpf);
        Cliente BuscarPorEmail(string email);
    }
}
