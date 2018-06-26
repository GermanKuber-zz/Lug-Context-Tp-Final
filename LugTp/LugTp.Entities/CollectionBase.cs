using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using LugTp.Entities.Trackeable;

namespace LugTp.Entities
{
    public class CollectionBase<TEntity> : IEnumerable<TEntity>
    {
        private readonly Action<List<ITrackeable<TEntity>>> _getAll;
        readonly List<ITrackeable<TEntity>> _entities = new List<ITrackeable<TEntity>>();

        public List<TEntity> Get() => _entities.Select(x => x.Current).ToList();


        public CollectionBase(List<TEntity> list, Action<List<ITrackeable<TEntity>>> getAll)
        {
            _getAll = getAll;

            _entities = new List<ITrackeable<TEntity>>();
            list.ForEach(x => _entities.Add(new UnmodifiedTrackeable<TEntity>(x)));
        }
        public void Add(TEntity entity)
        {
            if (!_entities.Any(x => x.Current.Equals(entity)))
            {
                var newEntity = new AddedTrackeable<TEntity>(entity);
                _entities.Add(newEntity);
            }
        }
        public void Delete(TEntity entity)
        {
            var result = _entities.FirstOrDefault(x => x.Current.Equals(entity));
            if (result != null)
            {
                var deleted = new DeletedTrackeable<TEntity>(entity);
                _entities.Remove(result);
                _entities.Add(deleted);
            }
        }
        public void Update(TEntity entity)
        {
            var result = _entities.FirstOrDefault(x => x.Current.Equals(entity));
            if (result != null)
            {
                var modified = new ModifiedTrackeable<TEntity>(entity);
                _entities.Remove(result);
                _entities.Add(modified);
            }
        }

        public List<TEntity> GetAll()
        {
            _getAll(_entities);
            return _entities.Select(x => x.Current).ToList();
        }

        public IEnumerator<TEntity> GetEnumerator() => _entities.Select(x => x.Current).ToList().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public void Execute()
        {
            _entities.ForEach(x=> x.Execute());
        }
    }
}