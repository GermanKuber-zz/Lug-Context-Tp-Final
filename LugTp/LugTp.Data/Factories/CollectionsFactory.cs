using System.Collections.Generic;
using LugTp.Data.SqlExecute.AlumnoCurso;
using LugTp.Entities;

namespace LugTp.Data.Factories
{
    public class CollectionsAlumnosFactory : ICollectionsAlumnosFactory
    {
        public ICollectionBase<Curso> CreateCursosEmpty(Alumno alumno)
        {
            return new CollectionBase<Curso>(new List<Curso>(), new AlumnoCursoSqlExecutions(alumno));
        }

        public ICollectionBase<Curso> CreateCurso(Alumno alumno, List<Curso> cursos)
        {
            return new CollectionBase<Curso>(cursos, new AlumnoCursoSqlExecutions(alumno));
        }
    }
}
