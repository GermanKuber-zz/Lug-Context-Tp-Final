//using System.Collections.Generic;
//using System.Linq;
//using LugTp.UI.Entities;

//namespace ConsoleApp9
//{
//    public class ContextLug
//    {
//        public CollectionBase<Alumno> Alumnos { get; } 
//        public CollectionBase<Curso> Cursos { get; }



//        public ContextLug()
//        {
//            var tmpList = new List<Alumno>();
//            tmpList.Add(new Alumno("Mariano", "Villarreal", "Riobamba", "02284", "11111", true));
//            tmpList.Add(new Alumno("Juan", "Perez", "Riobamba", "02284", "11111", true));
//            var tmpList2 = new List<Alumno>();
//            tmpList2.Add(new Alumno("Fran", "Otro", "Riobamba", "02284", "11111", false));

//            var tmpList3 = new List<Alumno>();
//            tmpList3.AddRange(tmpList);
//            tmpList3.AddRange(tmpList2);
//            Alumnos = new CollectionBase<Alumno>( tmpList3.ToList());

//            var tmpCursos = new List<Curso>();
//            tmpCursos.Add(new Curso("Curso 1", 123, new Docente("Docente 1", "Apellido", "Direccion", "telefono"),
//                new CollectionBase<Alumno>(tmpList)));
//            tmpCursos.Add(new Curso("Curso 2", 123, new Docente("Docente 2", "Apellido2", "Direccion2", "tel2efono"),
//                new CollectionBase<Alumno>(tmpList2)));

//            Cursos = new CollectionBase<Curso>(tmpCursos);
//        }

//    }
//}
