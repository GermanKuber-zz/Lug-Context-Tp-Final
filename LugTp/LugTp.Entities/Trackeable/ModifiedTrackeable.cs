namespace LugTp.Entities.Trackeable
{
    public class ModifiedTrackeable<TEntity> : BaseTrackeable<TEntity>
    {
        public ModifiedTrackeable(TEntity entity, ISqlExecute<TEntity> sqlExecute) : base(entity, sqlExecute)
        {
        }

       
    }
}