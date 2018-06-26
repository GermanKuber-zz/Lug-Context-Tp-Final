namespace ConsoleApp9.Trackeable
{
    public interface ITrackeable<TEntity>
    {
        TEntity Current { get; }
    }
}