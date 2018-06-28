using System;

namespace LugTp.Entities
{
    public class Curso 
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Duracion { get; set; }
        public Docente Docente { get; set; }
        public ICollectionBase<Unidad> Unidades { get; set; }
        public ICollectionBase<Alumno> Alumnos { get; private set; }
        public Curso(int id, string nombre, int duracion, Docente docente)
        {
            if (nombre == null)
                throw new ArgumentNullException(nameof(nombre));
            //if (docente == null)
            //    throw new ArgumentNullException(nameof(docente));

            Id = id;
            Nombre = nombre;
            Duracion = duracion;
            Docente = docente;

        }
        public Curso( string nombre, int duracion, Docente docente)
        {
            if (nombre == null)
                throw new ArgumentNullException(nameof(nombre));
            if (docente == null)
                throw new ArgumentNullException(nameof(docente));

            Nombre = nombre;
            Duracion = duracion;
            Docente = docente;

        }
        public Curso(int id,string nombre, int duracion, Docente docente, ICollectionBase<Alumno> alumnos)
        {
            if (nombre == null)
                throw new ArgumentNullException(nameof(nombre));
            if (docente == null)
                throw new ArgumentNullException(nameof(docente));

            Id = id;
            Nombre = nombre;
            Duracion = duracion;
            Docente = docente;
            Alumnos = alumnos;
        }

        public void AddAlumno(Alumno alumno)
        {
            Alumnos.Add(alumno);
        }
    }
}