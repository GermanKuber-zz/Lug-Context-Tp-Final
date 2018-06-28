using System.Collections.Generic;

namespace LugTp.Entities
{
    public class Alumno : Persona
    {
        public string Legajo { get; set; }
        public bool CuotaAlDia { get; set; }

        public Alumno(string nombre, string apellido, string direccion, string telefono, string legajo, bool cuotaAlDia,
            ICollectionsAlumnosFactory collectionsAlumnosFactory) 
            : base(nombre, apellido, direccion, telefono)
        {
            Legajo = legajo;
            CuotaAlDia = cuotaAlDia;
            Cursos = collectionsAlumnosFactory.CreateCursosEmpty(this);
        }
        public Alumno(string nombre, 
            string apellido, 
            string direccion,
            string telefono,
            string legajo,
            bool cuotaAlDia,
            List<Curso> cursos,
            ICollectionsAlumnosFactory collectionsAlumnosFactory) : base(nombre, apellido, direccion, telefono)
        {
            Legajo = legajo;
            CuotaAlDia = cuotaAlDia;
            Cursos = collectionsAlumnosFactory.CreateCurso(this, cursos);
        }
        public Alumno(int id, string nombre,
            string apellido,
            string direccion,
            string telefono,
            string legajo,
            bool cuotaAlDia,
            List<Curso> cursos,
            ICollectionsAlumnosFactory collectionsAlumnosFactory) : base(nombre, apellido, direccion, telefono)
        {
            Id = id;
            Legajo = legajo;
            CuotaAlDia = cuotaAlDia;
            Cursos = collectionsAlumnosFactory.CreateCurso(this, cursos);
        }
    }
}