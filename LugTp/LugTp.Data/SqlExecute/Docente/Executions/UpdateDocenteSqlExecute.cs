using LugTp.Data.Dal;
using LugTp.Entities.Trackeable;

namespace LugTp.Data.SqlExecute.Docente.Executions
{
    public class UpdateDocenteSqlExecute : ISqlExecute<Entities.Docente>
    {
        public void Execute(Entities.Docente entity)
        {
            var docenteDal = new DocentesDal();
            docenteDal.Update(entity);
        }
    }
}