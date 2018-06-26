using LugTp.Data.Dal;
using LugTp.Entities.Trackeable;

namespace LugTp.Data.SqlExecute.Docente.Executions
{
    public class DeleteDocenteSqlExecute : ISqlExecute<Entities.Docente>
    {
        public void Execute(Entities.Docente entity)
        {
            var docenteDal = new DocentesDal();
            docenteDal.Delete(entity);
        }
    }
}