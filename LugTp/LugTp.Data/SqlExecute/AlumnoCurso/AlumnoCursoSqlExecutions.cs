using LugTp.Data.SqlExecute.AlumnoCurso.Executions;
using LugTp.Entities;

namespace LugTp.Data.SqlExecute.AlumnoCurso
{
    public class AlumnoCursoSqlExecutions : SqlExecutions<Entities.Curso>
    {
        public AlumnoCursoSqlExecutions(int alumnoId) : base(new InsertAlumnoCursoSqlExecute(alumnoId),
            new DeleteAlumnoCursoSqlExecute(alumnoId),
            new UpdateAlumnoCursoSqlExecute(alumnoId),
            new NothingSqlExecute<Entities.Curso>())
        {
        }
    }
}