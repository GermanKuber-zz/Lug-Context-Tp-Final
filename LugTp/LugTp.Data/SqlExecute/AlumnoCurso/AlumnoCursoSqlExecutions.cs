using LugTp.Data.SqlExecute.AlumnoCurso.Executions;
using LugTp.Entities;
using LugTp.Entities.Trackeable;

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

    public class CursoAlumnoSqlExecutions : SqlExecutions<Entities.Curso>
    {
        //public CursoAlumnoSqlExecutions() : base(new InsertAlumnoCursoSqlExecute(),
        //    new DeleteAlumnoCursoSqlExecute(),
        //    new UpdateAlumnoCursoSqlExecute(),
        //    new NothingSqlExecute<Entities.Alumno>())
        //{
        //}
        public CursoAlumnoSqlExecutions() : base(null, null, null, null)
        {
        }
    }
}