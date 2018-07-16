using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EP.CursoMvc.Domain.Entities;
using EP.CursoMvc.Domain.Interfaces.Repository;

namespace EP.CursoMvc.Infra.Data.Repository
{
    public class EnderecoRepository : RepositoryBase<Endereco> , IEnderecoRepository
    {
        #region IEnderecoRepository Members

        public Endereco BuscarPorBairro(string bairro)
        {
            return Buscar(e => e.Bairro == bairro).FirstOrDefault();
        }

        public Endereco BuscaPorCidade(string cidade)
        {
            return Buscar(e => e.Cidade == cidade).FirstOrDefault();
        }

        public Endereco BuscarPorEstado(string estado)
        {
            return Buscar(e => e.Estado == estado).FirstOrDefault();
        }

        #endregion
    }
}
