namespace LugTp.UI.Entities
{
    public class Docente : Persona
    {
        public string Cargo { get; set; }
        public string Profesion { get; set; }

        public Docente(string nombre, string apellido, string direccion, string telefono, string cargo, string profesion) : base(nombre, apellido, direccion, telefono)
        {
            Cargo = cargo;
            Profesion = profesion;
        }
    }
}