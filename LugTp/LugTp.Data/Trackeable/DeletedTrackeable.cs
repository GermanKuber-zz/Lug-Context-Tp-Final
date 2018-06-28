namespace LugTp.Data.Trackeable
{
    public class DeletedTrackeable<TEntity> : BaseTrackeable<TEntity>
    {
        public DeletedTrackeable(TEntity entity, ISqlExecute<TEntity> sqlExecute) : base(entity, sqlExecute)
        {
        }

     
    }
}