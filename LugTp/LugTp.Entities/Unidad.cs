namespace LugTp.UI.Entities
{
    public class Unidad
    {
        public int Id { get; set; }
        public string Tema { get; set; }
        public int Descripcion { get; set; }
        public Curso Curso { get; set; }
    }
}