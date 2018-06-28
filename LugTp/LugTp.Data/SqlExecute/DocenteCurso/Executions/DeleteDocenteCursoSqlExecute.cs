using LugTp.Data.Trackeable;

namespace LugTp.Data.SqlExecute.DocenteCurso.Executions
{
    public class DeleteDocenteCursoSqlExecute : ISqlExecute<Entities.Curso>
    {
        private readonly Entities.Docente _docente;


        public DeleteDocenteCursoSqlExecute(Entities.Docente docente)
        {
            _docente = docente;
        }

        public void Execute(Entities.Curso entity)
        {
            //var alumnoDal = new CursosDal();
            //alumnoDal.Delete(_alumno.Id, entity);
        }
    }
}