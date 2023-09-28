namespace MixSample.GenericRepository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void update(TEntity entity);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetById(int id);
        void Delete(TEntity entity);
        //void SaveChanges();
    }
}
