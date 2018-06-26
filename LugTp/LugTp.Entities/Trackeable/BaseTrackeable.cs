namespace ConsoleApp9.Trackeable
{
    public class BaseTrackeable<TEntity> : ITrackeable<TEntity>
    {
        public TEntity Current { get; protected set; }
        public BaseTrackeable(TEntity entity)
        {
            Current = entity;
        }
    }
}