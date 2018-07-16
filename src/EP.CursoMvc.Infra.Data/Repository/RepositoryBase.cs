using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EP.CursoMvc.Domain.Interfaces.Repository;
using EP.CursoMvc.Infra.Data.Contexto;

namespace EP.CursoMvc.Infra.Data.Repository
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected CursoMvcContext Db = new CursoMvcContext();
        protected DbSet<TEntity> DbSet;

        public RepositoryBase()
        {
            Db = new CursoMvcContext();
            DbSet = Db.Set<TEntity>();
	    }

        #region IRepositoryBase<TEntity> Members

        public virtual TEntity Adicionar(TEntity obj)
        {
            return DbSet.Add(obj);
            //Db.SaveChanges();
        }

        public virtual TEntity ObterPorId(Guid Id)
        {
            return Db.Set<TEntity>().Find(Id);
        }

        public virtual IEnumerable<TEntity> ObterTodos(int s, int t)
        {
            return DbSet.Take(t).Skip(s).ToList();

        }

        public TEntity Atualizar(TEntity obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;
            SaveChanges();
            return obj;
        }

       // public void Remover(TEntity obj)
         public void Remover(Guid id)
        {
            DbSet.Remove(ObterPorId(id));
        //    DbSet.Remove(obj);
            Db.SaveChanges();
        //    return obj;
        }

        public IEnumerable<TEntity> Buscar(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
