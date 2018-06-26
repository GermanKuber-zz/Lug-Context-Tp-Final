namespace LugTp.Entities.Trackeable
{
    public class AddedTrackeable<TEntity> : BaseTrackeable<TEntity>
    {
        

        public override void Execute()
        {
            SqlExecute.Execute(Current);
        }

        public AddedTrackeable(TEntity entity, ISqlExecute<TEntity> sqlExecute) : base(entity, sqlExecute)
        {
        }
    }

    public interface ISqlExecute<TEntity>
    {
        void Execute(TEntity entity);
    }

    public class AddDocente : ISqlExecute<Docente>
    {
        public void Execute(Docente entity)
        {
            throw new System.NotImplementedException();
        }
    }
}