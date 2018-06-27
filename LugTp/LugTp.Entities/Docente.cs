namespace LugTp.Entities
{
    public class Docente : Persona
    {
        public string Cargo { get; set; }
        public string Profesion { get; set; }

        public Docente(string nombre, string apellido, string direccion, string telefono, string cargo, string profesion) : 
            base(nombre, apellido, direccion, telefono,null )
        {
            Cargo = cargo;
            Profesion = profesion;
        }
        public Docente(int id, string nombre, string apellido, string direccion, string telefono, string cargo, string profesion, CollectionBase<Curso> cursos) : base(
            nombre, apellido, direccion, telefono, cursos)
        {
            Id = id;
            Cargo = cargo;
            Profesion = profesion;
        }
    }
}
