using LugTp.Data.Trackeable;

namespace LugTp.Data.SqlExecute.AlumnoCurso.Executions
{
    public class UpdateAlumnoCursoSqlExecute : ISqlExecute<Entities.Curso>
    {
        private readonly Entities.Alumno _alumno;

        public UpdateAlumnoCursoSqlExecute(Entities.Alumno alumno)
        {
            _alumno = alumno;
        }
        public void Execute(Entities.Curso entity)
        {
        //    var alumnoDal = new AlumnosDal();
        //    alumnoDal.Update(entity);
        }
    }
}