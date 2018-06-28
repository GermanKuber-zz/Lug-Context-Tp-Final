using LugTp.Data.SqlExecute.DocenteCurso.Executions;

namespace LugTp.Data.SqlExecute.DocenteCurso
{
    public class DocenteCursoSqlExecutions : SqlExecutions<Entities.Curso>
    {
        public DocenteCursoSqlExecutions(Entities.Docente docente) : base(new InsertDocenteCursoSqlExecute(docente), 
            new DeleteDocenteCursoSqlExecute(docente), 
            new UpdateDocenteCursoSqlExecute(docente), 
            new NothingSqlExecute<Entities.Curso>())
        {
        }
    }
}