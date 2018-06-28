using LugTp.Data.Trackeable;

namespace LugTp.Data.SqlExecute
{
    public  class NothingSqlExecute<TEntity> : ISqlExecute<TEntity>
    {
        public void Execute(TEntity entity)
        {
        }
    }
}