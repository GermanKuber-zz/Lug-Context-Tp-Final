using System.Collections.Generic;
using LugTp.Data.SqlExecute.Docente;
using LugTp.Entities;

namespace LugTp.Data.Factories
{
    public class CollectionsUnidadesFactory : ICollectionsUnidadesFactory
    {
        public ICollectionBase<Unidad> CreateUnidadesEmpty()
        {
            return new CollectionBase<Unidad>(new List<Unidad>(), new UnidadesSqlExecutions());
        }

        public ICollectionBase<Unidad> CreateUnidades(List<Unidad> unidades)
        {
            return new CollectionBase<Unidad>(unidades, new UnidadesSqlExecutions());
        }
    }
}