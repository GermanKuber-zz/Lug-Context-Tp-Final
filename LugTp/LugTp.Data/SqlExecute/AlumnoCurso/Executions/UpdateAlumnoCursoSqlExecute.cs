using LugTp.Data.Dal;
using LugTp.Entities.Trackeable;

namespace LugTp.Data.SqlExecute.AlumnoCurso.Executions
{
    public class UpdateAlumnoCursoSqlExecute : ISqlExecute<Entities.Curso>
    {
        private readonly int _alumnoId;

        public UpdateAlumnoCursoSqlExecute(int alumnoId)
        {
            _alumnoId = alumnoId;
        }
        public void Execute(Entities.Curso entity)
        {
        //    var alumnoDal = new AlumnosDal();
        //    alumnoDal.Update(entity);
        }
    }
}