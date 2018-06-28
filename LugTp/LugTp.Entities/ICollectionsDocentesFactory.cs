using System.Collections.Generic;

namespace LugTp.Entities
{
    public interface ICollectionsDocentesFactory
    {
        ICollectionBase<Curso> CreateCursosEmpty(Docente docente);
        ICollectionBase<Curso> CreateCurso(Docente docente, List<Curso> cursos);
    }
}