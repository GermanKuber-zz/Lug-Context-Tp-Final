using LugTp.Data.Dal;
using LugTp.Entities.Trackeable;

namespace LugTp.Data.SqlExecute.AlumnoCurso.Executions
{
    public class InsertAlumnoCursoSqlExecute : ISqlExecute<Entities.Curso>
    {
        private readonly int _alumnoId;

        public InsertAlumnoCursoSqlExecute(int alumnoId)
        {
            _alumnoId = alumnoId;
        }
        public void Execute(Entities.Curso entity)
        {
            var alumnoDal = new CursosDal();
            alumnoDal.Insert(_alumnoId, entity);
        }
    }
}