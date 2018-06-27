using LugTp.Data.Dal;
using LugTp.Entities.Trackeable;

namespace LugTp.Data.SqlExecute.Curso.Executions
{
    public class InsertCursoSqlExecute : ISqlExecute<Entities.Curso>
    {
        public void Execute(Entities.Curso entity)
        {
            var cursoDal = new CursosDal();
            cursoDal.Insert(entity);
        }
    }
}