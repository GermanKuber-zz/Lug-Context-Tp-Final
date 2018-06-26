namespace LugTp.Entities.Trackeable
{
    public interface ITrackeable<TEntity>
    {
        TEntity Current { get; }
    }
}