using System;
using System.Collections.Generic;

namespace LugTp.Entities
{
    public class Persona
    {
        public int Id { get; set; }
        public string  Nombre { get; set; }
        public string  Apellido { get; set; }
        public string  Direccion { get; set; }
        public string Telefono { get; set; }
        public CollectionBase<Curso> Cursos { get; set; }

        public Persona(string nombre, string apellido, string direccion, string telefono, CollectionBase<Curso> cursos)
        {
            if (nombre == null)
                throw new ArgumentNullException(nameof(nombre));
            if (apellido == null)
                throw new ArgumentNullException(nameof(apellido));
            if (direccion == null)
                throw new ArgumentNullException(nameof(direccion));
            if (telefono == null)
                throw new ArgumentNullException(nameof(telefono));
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
            Cursos = cursos;
        }
    }
}