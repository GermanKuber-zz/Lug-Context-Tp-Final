using System.Collections.Generic;

namespace LugTp.Entities
{
    public class Docente : Persona
    {
        public string Cargo { get; set; }
        public string Profesion { get; set; }

        public Docente(string nombre, string apellido, string direccion, string telefono, string cargo, string profesion,
            ICollectionsDocentesFactory collectionsDocentesFactory) : 
            base(nombre, apellido, direccion, telefono )
        {
            Cargo = cargo;
            Profesion = profesion;
            Cursos = collectionsDocentesFactory.CreateCursosEmpty(this);
        }
        public Docente(int id, 
            string nombre,
            string apellido,
            string direccion,
            string telefono,
            string cargo, 
            string profesion,
            List<Curso> cursos,
            ICollectionsDocentesFactory collectionsDocentesFactory) : base(
            nombre, apellido, direccion, telefono)
        {
            Id = id;
            Cargo = cargo;
            Profesion = profesion;
            Cursos = collectionsDocentesFactory.CreateCurso(this, cursos);
        }
    }
}
