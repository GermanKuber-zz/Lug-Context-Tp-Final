﻿using LugTp.Data.SqlExecute.Docente.Executions;

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
}