using LugTp.Data.Dal;
using LugTp.Data.Trackeable;

namespace LugTp.Data.SqlExecute.Alumno.Executions
{
    public class InsertAlumnoSqlExecute : ISqlExecute<Entities.Alumno>
    {
        public void Execute(Entities.Alumno entity)
        {
            var alumnoDal = new AlumnosDal();
            alumnoDal.Insert(entity);
        }
    }
}