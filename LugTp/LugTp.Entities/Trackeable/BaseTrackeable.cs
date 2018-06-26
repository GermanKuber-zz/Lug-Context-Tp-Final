namespace LugTp.Entities.Trackeable
{
    public abstract class BaseTrackeable<TEntity> : ITrackeable<TEntity>
    {
        protected readonly ISqlExecute<TEntity> SqlExecute;
        public TEntity Current { get; protected set; }
        public abstract void Execute();

        public BaseTrackeable(TEntity entity, ISqlExecute<TEntity> sqlExecute)
        {
            SqlExecute = sqlExecute;
            Current = entity;
        }
    }
}