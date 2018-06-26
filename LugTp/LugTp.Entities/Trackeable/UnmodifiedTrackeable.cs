namespace LugTp.Entities.Trackeable
{
    public class UnmodifiedTrackeable<TEntity> : BaseTrackeable<TEntity>
    {
        public UnmodifiedTrackeable(TEntity entity, ISqlExecute<TEntity> sqlExecute) : base(entity, sqlExecute)
        {
        }
    }
}