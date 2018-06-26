using System.Collections.Generic;
using System.Linq;
using LugTp.Data.SqlExecute.Docente;
using LugTp.Data.SqlExecute.Docente.Executions;
using LugTp.Entities;
using LugTp.Entities.Trackeable;

namespace LugTp.Data
{
    public class ContextLug
    {
        public CollectionBase<Alumno> Alumnos { get; }
        public CollectionBase<Curso> Cursos { get; }
        private CollectionBase<Docente> _docentes;
        public CollectionBase<Docente> Docentes
        {
            get
            {
                var docenteDal = new DocenteDal();
                if (_docentes == null)
                {
                    _docentes = new CollectionBase<Docente>(docenteDal.GetAll(), new DocenteSqlExecutions(),
                        () =>
                   {
                       return new List<ITrackeable<Docente>>(docenteDal.GetAll()?
                           .Select(x => new UnmodifiedTrackeable<Docente>(x, new NothingSqlExecute()))
                           .ToList());
                   });
                }
                return _docentes;
            }
        }



        public void SaveChange() => Docentes.Execute();
    }
}
