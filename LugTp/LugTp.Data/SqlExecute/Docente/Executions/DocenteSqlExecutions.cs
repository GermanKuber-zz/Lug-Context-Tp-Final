using LugTp.Entities;

namespace LugTp.Data.SqlExecute.Docente.Executions
{
    public class DocenteSqlExecutions : SqlExecutions<Entities.Docente>
    {
        public DocenteSqlExecutions() : base(new InsertDocenteSqlExecute(),
            new DeleteDocenteSqlExecute(), 
            new UpdateDocenteSqlExecute(),
            new NothingSqlExecute())
        {
        }
    }
}