using LugTp.Data.SqlExecute.Curso.Executions;

namespace LugTp.Data.SqlExecute.Curso
{
    public class CursoSqlExecutions : SqlExecutions<Entities.Curso>
    {
        public CursoSqlExecutions() : base(new InsertCursoSqlExecute(), 
            new DeleteCursoSqlExecute(),  
            new UpdateCursoSqlExecute(), 
            new NothingSqlExecute<Entities.Curso>())
        {
        }
    }
}