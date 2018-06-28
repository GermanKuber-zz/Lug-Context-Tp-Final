using LugTp.Data.Dal;
using LugTp.Data.Trackeable;

namespace LugTp.Data.SqlExecute.Alumno.Executions
{
    public class UpdateUnidadesSqlExecute : ISqlExecute<Entities.Unidad>
    {
        public void Execute(Entities.Unidad entity)
        {
            var alumnoDal = new UnidadesDal();
            alumnoDal.Update(entity);
        }
    }
}