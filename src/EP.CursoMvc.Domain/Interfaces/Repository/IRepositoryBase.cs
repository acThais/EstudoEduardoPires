using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EP.CursoMvc.Domain.Interfaces.Repository
{
    public interface IRepositoryBase<TEntity> : IDisposable where TEntity :class
    {
        TEntity Adicionar(TEntity obj);
        TEntity ObterPorId(Guid Id);
        IEnumerable<TEntity> ObterTodos(int s, int t);
        TEntity Atualizar(TEntity obj);
        //void Remover(TEntity obj);
        void Remover(Guid id);
        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);
        int SaveChanges();
        void Dispose();

    }
}
