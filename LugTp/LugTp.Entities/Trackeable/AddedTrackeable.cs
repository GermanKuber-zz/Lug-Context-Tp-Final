namespace LugTp.Entities.Trackeable
{
    public class AddedTrackeable<TEntity> : BaseTrackeable<TEntity>
    {
        public AddedTrackeable(TEntity entity) : base(entity)
        {
        }
    }
}