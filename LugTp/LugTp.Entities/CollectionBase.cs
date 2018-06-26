using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp9.Trackeable;

namespace ConsoleApp9
{
    public class CollectionBase<TEntity> : IEnumerable<TEntity>
    {
        readonly List<ITrackeable<TEntity>> _entities;

        public List<TEntity> Get() => _entities.Select(x => x.Current).ToList();

    
        public CollectionBase( List<TEntity> list)
        {
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

        public IEnumerator<TEntity> GetEnumerator() => _entities.Select(x => x.Current).ToList().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}