using System;
using System.Collections.Generic;

namespace LugTp.Entities
{
    public class Curso 
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Duracion { get; set; }
        public Docente Docente { get; set; }
        public CollectionBase<Unidad> Unidades { get; set; }
        public List<Alumno> Alumnos { get; private set; }  
 

        public Curso(string nombre, int duracion, Docente docente, List<Alumno> alumnos)
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
        }

        public void AddAlumno(Alumno alumno)
        {
            Alumnos.Add(alumno);

        }
    }
}