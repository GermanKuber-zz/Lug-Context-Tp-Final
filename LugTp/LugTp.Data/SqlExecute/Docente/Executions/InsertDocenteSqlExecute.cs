using LugTp.Data.Dal;
using LugTp.Data.Trackeable;

namespace LugTp.Data.SqlExecute.Docente.Executions
{
    public class InsertDocenteSqlExecute : ISqlExecute<Entities.Docente>
    {
        public void Execute(Entities.Docente entity)
        {
            var docenteDal = new DocentesDal();
            docenteDal.Insert(entity);
        }
    }
}