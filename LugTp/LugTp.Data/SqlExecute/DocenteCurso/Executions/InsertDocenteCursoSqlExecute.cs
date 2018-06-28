using LugTp.Data.Dal;
using LugTp.Data.Trackeable;

namespace LugTp.Data.SqlExecute.DocenteCurso.Executions
{
    public class InsertDocenteCursoSqlExecute : ISqlExecute<Entities.Curso>
    {
        private readonly Entities.Docente _docente;

        public InsertDocenteCursoSqlExecute(Entities.Docente docente)
        {
            _docente = docente;
        }
        public void Execute(Entities.Curso entity)
        {
            var alumnoDal = new CursosDal();
            alumnoDal.Insert(_docente.Id, entity);
        }
    }
}