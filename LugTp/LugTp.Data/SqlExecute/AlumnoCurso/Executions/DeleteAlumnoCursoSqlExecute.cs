using LugTp.Data.Dal;
using LugTp.Data.Trackeable;

namespace LugTp.Data.SqlExecute.AlumnoCurso.Executions
{
    public class DeleteAlumnoCursoSqlExecute : ISqlExecute<Entities.Curso>
    {
        private readonly Entities.Alumno _alumno;

        public DeleteAlumnoCursoSqlExecute(Entities.Alumno alumno)
        {
            _alumno = alumno;
        }
        public void Execute(Entities.Curso entity)
        {
            var alumnoDal = new CursosDal();
            alumnoDal.Delete(_alumno.Id, entity);
        }
    }
}