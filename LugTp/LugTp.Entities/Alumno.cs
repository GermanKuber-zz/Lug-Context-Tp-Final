using System.Collections.Generic;

namespace LugTp.Entities
{
    public class Alumno : Persona
    {
        public string Legajo { get; set; }
        public bool CuotaAlDia { get; set; }

        public Alumno(string nombre, string apellido, string direccion, string telefono, string legajo, bool cuotaAlDia) : base(nombre, apellido, direccion, telefono, null)
        {
            Legajo = legajo;
            CuotaAlDia = cuotaAlDia;
        }
        public Alumno(string nombre, 
            string apellido, 
            string direccion,
            string telefono,
            string legajo,
            bool cuotaAlDia,
            CollectionBase<Curso> cursos) : base(nombre, apellido, direccion, telefono, cursos)
        {
            Legajo = legajo;
            CuotaAlDia = cuotaAlDia;
        }
        public Alumno(int id, string nombre,
            string apellido,
            string direccion,
            string telefono,
            string legajo,
            bool cuotaAlDia,
            CollectionBase<Curso> cursos) : base(nombre, apellido, direccion, telefono, cursos)
        {
            Id = id;
            Legajo = legajo;
            CuotaAlDia = cuotaAlDia;
        }
    }
}