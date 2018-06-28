using System.Collections.Generic;
using LugTp.Data.SqlExecute.DocenteCurso;
using LugTp.Entities;

namespace LugTp.Data.Factories
{
    public class CollectionsDocentesFactory : ICollectionsDocentesFactory
    {
        public ICollectionBase<Curso> CreateCursosEmpty(Docente docente)
        {
            return new CollectionBase<Curso>(new List<Curso>(), new DocenteCursoSqlExecutions(docente));
        }

        public ICollectionBase<Curso> CreateCurso(Docente docente, List<Curso> cursos)
        {
            return new CollectionBase<Curso>(cursos, new DocenteCursoSqlExecutions(docente));
        }
    }
}