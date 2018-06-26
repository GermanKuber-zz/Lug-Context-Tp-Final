namespace ConsoleApp9.Trackeable
{
    public class ModifiedTrackeable<TEntity> : BaseTrackeable<TEntity>
    {
        public ModifiedTrackeable(TEntity entity) : base(entity)
        {
        }
    }

    public class UnmodifiedTrackeable<TEntity> : BaseTrackeable<TEntity>
    {
        public UnmodifiedTrackeable(TEntity entity) : base(entity)
        {
        }
    }
}