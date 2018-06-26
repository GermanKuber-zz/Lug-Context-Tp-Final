using LugTp.Data.Dal;
using LugTp.Entities.Trackeable;

namespace LugTp.Data.SqlExecute.Alumno.Executions
{
    public class DeleteAlumnoSqlExecute : ISqlExecute<Entities.Alumno>
    {
        public void Execute(Entities.Alumno entity)
        {
            var alumnoDal = new AlumnosDal();
            alumnoDal.Delete(entity);
        }
    }
}