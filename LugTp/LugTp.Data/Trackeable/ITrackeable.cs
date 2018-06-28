namespace LugTp.Data.Trackeable
{
    public interface ITrackeable<TEntity>
    {
        TEntity Current { get; }
        ITrackeable<TEntity> Execute();
    }
}