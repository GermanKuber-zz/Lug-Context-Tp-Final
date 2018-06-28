using System.Collections.Generic;
using LugTp.Entities;

namespace LugTp.Data.Factories
{
    public interface ICollectionsUnidadesFactory
    {
        ICollectionBase<Unidad> CreateUnidades(List<Unidad> unidades);
        ICollectionBase<Unidad> CreateUnidadesEmpty();
    }
}