using System.Collections.Generic;

namespace LugTp.Entities
{
    public interface ICollectionBase<TEntity>  : IEnumerable<TEntity>
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Execute();
        List<TEntity> Get();
        List<TEntity> GetAll();
        IEnumerator<TEntity> GetEnumerator();
        void Update(TEntity entity);
    }
}