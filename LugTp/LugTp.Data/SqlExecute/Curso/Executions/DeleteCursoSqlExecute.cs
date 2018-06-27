using LugTp.Data.Dal;
using LugTp.Entities.Trackeable;

namespace LugTp.Data.SqlExecute.Curso.Executions
{
    public class DeleteCursoSqlExecute : ISqlExecute<Entities.Curso>
    {
        public void Execute(Entities.Curso entity)
        {
            var cursoDal = new CursosDal();
            cursoDal.Delete(entity);
        }
    }
}