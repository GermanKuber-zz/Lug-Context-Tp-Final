using System.Collections.Generic;
using System.Linq;
using LugTp.Entities;

namespace LugTp.Data
{
    public class ContextLug
    {
        public CollectionBase<Alumno> Alumnos { get; }
        public CollectionBase<Curso> Cursos { get; }
        public CollectionBase<Docente> Docentes { get; }



        public ContextLug()
        {
            var tmpList = new List<Alumno>();
            tmpList.Add(new Alumno("Mariano", "Villarreal", "Riobamba", "02284", "11111", true));
            tmpList.Add(new Alumno("Juan", "Perez", "Riobamba", "02284", "11111", true));
            var tmpList2 = new List<Alumno>();
            tmpList2.Add(new Alumno("Fran", "Otro", "Riobamba", "02284", "11111", false));

            var tmpList3 = new List<Alumno>();
            tmpList3.AddRange(tmpList);
            tmpList3.AddRange(tmpList2);
            Alumnos = new CollectionBase<Alumno>(tmpList3.ToList());

        }

        public void SaveChangeAsync()
        {

        }
    }
}
