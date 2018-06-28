using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using LugTp.Data.Trackeable;
using LugTp.Entities;

namespace LugTp.Data
{
    public class SqlExecutions<TEntity>
    {
        public ISqlExecute<TEntity> Add { get; set; }
        public ISqlExecute<TEntity> Delete { get; set; }
        public ISqlExecute<TEntity> Update { get; set; }
        public ISqlExecute<TEntity> Unmodified { get; set; }

        public SqlExecutions(ISqlExecute<TEntity> add, ISqlExecute<TEntity> delete, ISqlExecute<TEntity> update, ISqlExecute<TEntity> unmodified)
        {
            if (add == null)
                throw new ArgumentNullException(nameof(add));
            if (delete == null)
                throw new ArgumentNullException(nameof(delete));
            if (update == null)
                throw new ArgumentNullException(nameof(update));
            if (unmodified == null)
                throw new ArgumentNullException(nameof(unmodified));
            Add = add;
            Delete = delete;
            Update = update;
            Unmodified = unmodified;
        }
    }

    public class CollectionBase<TEntity> : ICollectionBase<TEntity>
    {
        private readonly SqlExecutions<TEntity> _sqlExecution;
        private readonly Func<List<ITrackeable<TEntity>>> _getAll;
        private List<ITrackeable<TEntity>> _entities = new List<ITrackeable<TEntity>>();

        public List<TEntity> Get() => _entities.Select(x => x.Current).ToList();
        public CollectionBase(List<TEntity> list, SqlExecutions<TEntity> sqlExecution)
        {
            _sqlExecution = sqlExecution;

            _entities = new List<ITrackeable<TEntity>>();
            list.ForEach(x => _entities.Add(new UnmodifiedTrackeable<TEntity>(x, _sqlExecution.Unmodified)));
        }

        public CollectionBase(List<TEntity> list, SqlExecutions<TEntity> sqlExecution, Func<List<ITrackeable<TEntity>>> getAll)
        {
            //TODO: quietar el getall del consutrctor, dejar un solo consturctor
            _sqlExecution = sqlExecution;
            _getAll = getAll;

            _entities = new List<ITrackeable<TEntity>>();
            list.ForEach(x => _entities.Add(new UnmodifiedTrackeable<TEntity>(x, _sqlExecution.Unmodified)));
        }
        public void Add(TEntity entity)
        {
            if (!_entities.Any(x => x.Current.Equals(entity)))
            {
                var newEntity = new AddedTrackeable<TEntity>(entity, _sqlExecution.Add);
                _entities.Add(newEntity);
            }
            else
            {
                var current = _entities.FirstOrDefault(x => x.Current.Equals(entity));
                _entities.Remove(current);
                var newEntity = new AddedTrackeable<TEntity>(entity, _sqlExecution.Add);
                _entities.Add(newEntity);


            }
        }
        public void Delete(TEntity entity)
        {
            var result = _entities.FirstOrDefault(x => x.Current.Equals(entity));
            if (result != null)
            {
                var deleted = new DeletedTrackeable<TEntity>(entity, _sqlExecution.Delete);
                _entities.Remove(result);
                _entities.Add(deleted);
            }
        }
        public void Update(TEntity entity)
        {
            var result = _entities.FirstOrDefault(x => x.Current.Equals(entity));
            if (result != null)
            {
                var modified = new ModifiedTrackeable<TEntity>(entity, _sqlExecution.Update);
                _entities.Remove(result);
                _entities.Add(modified);
            }
        }

        public List<TEntity> GetAll()
        {
            _entities = _getAll();
            return _entities.Select(x => x.Current).ToList();
        }

        public IEnumerator<TEntity> GetEnumerator() => _entities.Select(x => x.Current).ToList().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public void Execute()
        {
            _entities.ForEach(x => x = x.Execute());
        }
    }
}