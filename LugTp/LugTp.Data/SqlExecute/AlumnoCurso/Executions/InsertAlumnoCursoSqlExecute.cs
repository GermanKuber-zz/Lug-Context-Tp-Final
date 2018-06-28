using LugTp.Data.Dal;
using LugTp.Data.Trackeable;

namespace LugTp.Data.SqlExecute.AlumnoCurso.Executions
{
    public class InsertAlumnoCursoSqlExecute : ISqlExecute<Entities.Curso>
    {
        private readonly Entities.Alumno _alumno;

        public InsertAlumnoCursoSqlExecute(Entities.Alumno alumno)
        {
            _alumno = alumno;
        }
        public void Execute(Entities.Curso entity)
        {
            var alumnoDal = new CursosDal();
            alumnoDal.Insert(_alumno.Id, entity);
        }
    }
}