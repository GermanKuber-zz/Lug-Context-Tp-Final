using LugTp.Data.SqlExecute.AlumnoCurso.Executions;

namespace LugTp.Data.SqlExecute.AlumnoCurso
{
    public class AlumnoCursoSqlExecutions : SqlExecutions<Entities.Curso>
    {
        public AlumnoCursoSqlExecutions(Entities.Alumno alumno) : base(new InsertAlumnoCursoSqlExecute(alumno),
            new DeleteAlumnoCursoSqlExecute(alumno),
            new UpdateAlumnoCursoSqlExecute(alumno),
            new NothingSqlExecute<Entities.Curso>())
        {
        }
    }
}