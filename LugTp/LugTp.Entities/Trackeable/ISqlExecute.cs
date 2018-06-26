namespace LugTp.Entities.Trackeable
{
    public interface ISqlExecute<TEntity>
    {
        void Execute(TEntity entity);
    }
}