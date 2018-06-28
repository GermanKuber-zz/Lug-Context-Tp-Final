using LugTp.Data.SqlExecute.Alumno.Executions;
using LugTp.Data.SqlExecute.Docente.Executions;

namespace LugTp.Data.SqlExecute.Docente
{
    public class DocenteSqlExecutions : SqlExecutions<Entities.Docente>
    {
        public DocenteSqlExecutions() : base(new InsertDocenteSqlExecute(),
            new DeleteDocenteSqlExecute(),
            new UpdateDocenteSqlExecute(),
            new NothingSqlExecute<Entities.Docente>())
        {
        }
    }

    public class UnidadesSqlExecutions : SqlExecutions<Entities.Unidad>
    {
        public UnidadesSqlExecutions() : base(null, null, new UpdateUnidadesSqlExecute(), new NothingSqlExecute<Entities.Unidad>())
        {
        }
    }
}