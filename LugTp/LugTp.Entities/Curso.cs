using System;
using System.Collections.Generic;
using LugTp.Data.Factories;

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
        public Curso(int id, string nombre, int duracion,
            Docente docente,
            List<Unidad> unidades,
            ICollectionsUnidadesFactory collectionsUnidadesFactory)
        {
            if (nombre == null)
                throw new ArgumentNullException(nameof(nombre));
            //if (docente == null)
            //    throw new ArgumentNullException(nameof(docente));

            Id = id;
            Nombre = nombre;
            Duracion = duracion;
            Docente = docente;
            Unidades = collectionsUnidadesFactory.CreateUnidades(unidades);

        }
        public Curso(string nombre,
            int duracion,
            Docente docente, List<Unidad> unidades,
            ICollectionsUnidadesFactory collectionsUnidadesFactory)
        {
            if (nombre == null)
                throw new ArgumentNullException(nameof(nombre));
            if (docente == null)
                throw new ArgumentNullException(nameof(docente));

            Nombre = nombre;
            Duracion = duracion;
            Docente = docente;
            Unidades = collectionsUnidadesFactory.CreateUnidades(unidades);
        }
        public Curso(int id,
            string nombre,
            int duracion,
            Docente docente,
            ICollectionBase<Alumno> alumnos,
            ICollectionBase<Unidad> unidades)
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
            Unidades = unidades;
        }

        public void AddAlumno(Alumno alumno)
        {
            Alumnos.Add(alumno);
        }
    }
}