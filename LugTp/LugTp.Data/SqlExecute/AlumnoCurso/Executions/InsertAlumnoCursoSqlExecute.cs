using LugTp.Data.Dal;
using LugTp.Entities.Trackeable;

namespace LugTp.Data.SqlExecute.AlumnoCurso.Executions
{
    public class InsertAlumnoCursoSqlExecute : ISqlExecute<Entities.Alumno>
    {
        public void Execute(Entities.Alumno entity)
        {
            var alumnoDal = new AlumnosDal();
            alumnoDal.Insert(entity);
        }
    }
}