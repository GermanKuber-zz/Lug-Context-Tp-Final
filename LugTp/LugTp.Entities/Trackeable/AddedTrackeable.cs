namespace ConsoleApp9.Trackeable
{
    public class AddedTrackeable<TEntity> : BaseTrackeable<TEntity>
    {
        public AddedTrackeable(TEntity entity) : base(entity)
        {
        }
    }
}