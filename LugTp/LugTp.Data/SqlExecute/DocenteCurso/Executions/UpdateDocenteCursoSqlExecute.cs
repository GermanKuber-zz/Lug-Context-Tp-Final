using LugTp.Data.Trackeable;

namespace LugTp.Data.SqlExecute.DocenteCurso.Executions
{
    public class UpdateDocenteCursoSqlExecute : ISqlExecute<Entities.Curso>
    {
        private readonly Entities.Docente _docente;

        public UpdateDocenteCursoSqlExecute(Entities.Docente docente)
        {
            _docente = docente;
        }
        public void Execute(Entities.Curso entity)
        {
        //    var alumnoDal = new AlumnosDal();
        //    alumnoDal.Update(entity);
        }
    }
}