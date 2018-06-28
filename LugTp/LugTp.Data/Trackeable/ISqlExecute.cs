namespace LugTp.Data.Trackeable
{
    public interface ISqlExecute<TEntity>
    {
        void Execute(TEntity entity);
    }
}