using System.Collections.Generic;

namespace LugTp.Entities
{
    public interface ICollectionsAlumnosFactory
    {
        ICollectionBase<Curso> CreateCursosEmpty(Alumno alumno);
        ICollectionBase<Curso> CreateCurso(Alumno alumno, List<Curso> cursos);
    }
}