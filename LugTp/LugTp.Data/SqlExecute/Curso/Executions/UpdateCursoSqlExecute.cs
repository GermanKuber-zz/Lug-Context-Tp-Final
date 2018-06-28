using LugTp.Data.Dal;
using LugTp.Data.Trackeable;

namespace LugTp.Data.SqlExecute.Curso.Executions
{
    public class UpdateCursoSqlExecute : ISqlExecute<Entities.Curso>
    {
        public void Execute(Entities.Curso entity)
        {
            var cursoDal = new CursosDal();
            cursoDal.Update(entity);
        }
    }
}