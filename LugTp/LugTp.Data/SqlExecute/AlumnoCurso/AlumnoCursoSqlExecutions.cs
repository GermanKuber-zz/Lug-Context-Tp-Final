using LugTp.Data.SqlExecute.AlumnoCurso.Executions;
using LugTp.Entities;

namespace LugTp.Data.SqlExecute.AlumnoCurso
{
    public class AlumnoCursoSqlExecutions : SqlExecutions<Entities.Alumno>
    {
        public AlumnoCursoSqlExecutions() : base(new InsertAlumnoCursoSqlExecute(), 
            new DeleteAlumnoCursoSqlExecute(), 
            new UpdateAlumnoCursoSqlExecute(),
            new NothingSqlExecute<Entities.Alumno>())
        {
        }
    }
}