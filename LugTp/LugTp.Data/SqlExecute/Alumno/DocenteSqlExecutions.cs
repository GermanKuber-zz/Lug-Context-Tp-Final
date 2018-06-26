using LugTp.Data.SqlExecute.Alumno.Executions;
using LugTp.Entities;

namespace LugTp.Data.SqlExecute.Alumno
{
    public class AlumnoSqlExecutions : SqlExecutions<Entities.Alumno>
    {
        public AlumnoSqlExecutions() : base(new InsertAlumnoSqlExecute(), 
            new DeleteAlumnoSqlExecute(), 
            new UpdateAlumnoSqlExecute(),
            new NothingSqlExecute<Entities.Alumno>())
        {
        }
    }
}