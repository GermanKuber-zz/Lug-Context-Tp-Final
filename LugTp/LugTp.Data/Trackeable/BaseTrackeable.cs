using LugTp.Data.SqlExecute;

namespace LugTp.Data.Trackeable
{
    public abstract class BaseTrackeable<TEntity> : ITrackeable<TEntity>
    {
        protected readonly ISqlExecute<TEntity> SqlExecute;
        public TEntity Current { get; protected set; }
        public ITrackeable<TEntity> Execute()
        {
            SqlExecute.Execute(Current);
            return new UnmodifiedTrackeable<TEntity>(Current, new NothingSqlExecute<TEntity>());
        }

        public BaseTrackeable(TEntity entity, ISqlExecute<TEntity> sqlExecute)
        {
            SqlExecute = sqlExecute;
            Current = entity;
        }
    }
}