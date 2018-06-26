using System;
using ConsoleApp9;

namespace LugTp.UI.Entities
{
    public class Curso : ICloneable
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Duracion { get; set; }
        public Docente Docente { get; set; }
        public string Telefono { get; set; }
        public CollectionBase<Unidad> Unidades { get; set; }
        public CollectionBase<Alumno> Alumnos { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public Curso(string nombre, int duracion, Docente docente, CollectionBase<Alumno> alumnos)
        {
            if (nombre == null)
                throw new ArgumentNullException(nameof(nombre));
            if (docente == null)
                throw new ArgumentNullException(nameof(docente));
            if (alumnos == null)
                throw new ArgumentNullException(nameof(alumnos));
            Nombre = nombre;
            Duracion = duracion;
            Docente = docente;
            Alumnos = alumnos;
        }
    }
}