using LugTp.Data.Dal;
using LugTp.Data.Trackeable;

namespace LugTp.Data.SqlExecute.Alumno.Executions
{
    public class UpdateAlumnoSqlExecute : ISqlExecute<Entities.Alumno>
    {
        public void Execute(Entities.Alumno entity)
        {
            var alumnoDal = new AlumnosDal();
            alumnoDal.Update(entity);
        }
    }
}