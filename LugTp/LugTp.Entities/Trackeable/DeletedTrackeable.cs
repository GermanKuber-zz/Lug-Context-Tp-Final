namespace LugTp.Entities.Trackeable
{
    public class DeletedTrackeable<TEntity> : BaseTrackeable<TEntity>
    {
        public DeletedTrackeable(TEntity entity) : base(entity)
        {
        }
    }
}