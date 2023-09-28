using Microsoft.EntityFrameworkCore;
using MixSample.DbContextLayer;

namespace MixSample.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {

        private readonly MixedDbContext _mixedDbContext;
        public DbSet<TEntity> Context;

        public GenericRepository(MixedDbContext mixedDbContext)
        {
            this._mixedDbContext = mixedDbContext;
            this.Context = _mixedDbContext.Set<TEntity>();
         
        }
        public void Add(TEntity entity)
        {
            Context.Add(entity);
           
        }

        public void Delete(TEntity entity)
        {
            Context.Remove(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
         return Context.ToList<TEntity>();
        }

        public virtual TEntity GetById(int id)
        {
          return  Context.Find(id);
        }

        public void SaveChanges()
        {
            _mixedDbContext.SaveChanges();
        }

        public void update(TEntity entity)
        {
           Context.Attach(entity);
           
        }

        IEnumerable<TEntity> IGenericRepository<TEntity>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
