using LugTp.Entities.Trackeable;

namespace LugTp.Data.SqlExecute.Docente.Executions
{
    public class InsertDocenteSqlExecute : ISqlExecute<Entities.Docente>
    {
        public void Execute(Entities.Docente entity)
        {
            var docenteDal = new DocenteDal();
            docenteDal.Insert(entity);
        }
    }
}