namespace LugTp.Data.Trackeable
{
    public class AddedTrackeable<TEntity> : BaseTrackeable<TEntity>
    {
        public AddedTrackeable(TEntity entity, ISqlExecute<TEntity> sqlExecute) : base(entity, sqlExecute)
        {
        }
    }
}