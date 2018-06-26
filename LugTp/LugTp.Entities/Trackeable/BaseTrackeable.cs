namespace LugTp.Entities.Trackeable
{
    public abstract class BaseTrackeable<TEntity> : ITrackeable<TEntity>
    {
        protected readonly ISqlExecute<TEntity> SqlExecute;
        public TEntity Current { get; protected set; }
        public  void Execute()
        {
            SqlExecute.Execute(Current);
        }

        public BaseTrackeable(TEntity entity, ISqlExecute<TEntity> sqlExecute)
        {
            SqlExecute = sqlExecute;
            Current = entity;
        }
    }
}