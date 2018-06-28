using System;

namespace LugTp.Entities
{
    public class Unidad
    {
        public int Id { get; set; }
        public string Tema { get; set; }
        public string Descripcion { get; set; }
        public bool Selected { get; set; }

        public Unidad(int id, string tema, string descripcion, bool selected)
        {
            if (tema == null)
                throw new ArgumentNullException(nameof(tema));
            Id = id;
            Tema = tema;
            Descripcion = descripcion;
            Selected = selected;
        }
    }
}