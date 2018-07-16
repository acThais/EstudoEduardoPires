using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EP.CursoMvc.Domain.Entities;

namespace EP.CursoMvc.Domain.Interfaces.Repository
{
    public interface IEnderecoRepository : IRepositoryBase<Endereco>
    {
        Endereco BuscarPorBairro(string bairro);
        Endereco BuscaPorCidade(string cidade);
        Endereco BuscarPorEstado(string estado);
    }
}
