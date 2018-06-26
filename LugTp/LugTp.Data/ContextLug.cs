using System.Collections.Generic;
using System.Linq;
using LugTp.Data.Dal;
using LugTp.Data.SqlExecute;
using LugTp.Data.SqlExecute.Alumno;
using LugTp.Data.SqlExecute.Docente;
using LugTp.Entities;
using LugTp.Entities.Trackeable;

namespace LugTp.Data
{
    public class ContextLug
    {
        private CollectionBase<Alumno> _alumnos;

        public CollectionBase<Alumno> Alumnos
        {
            get
            {
                var alumnosDal = new AlumnosDal();
                if (_alumnos == null)
                {
                    _alumnos = new CollectionBase<Alumno>(alumnosDal.GetAll(), new AlumnoSqlExecutions(), 
                        () =>
                        {
                            return new List<ITrackeable<Alumno>>(alumnosDal.GetAll()?
                                .Select(x => new UnmodifiedTrackeable<Alumno>(x, new NothingSqlExecute<Alumno>()))
                                .ToList());
                        });
                }

                return _alumnos;
            }
        }

        public CollectionBase<Curso> Cursos { get; }
        private CollectionBase<Docente> _docentes;
        public CollectionBase<Docente> Docentes
        {
            get
            {
                var docenteDal = new DocentesDal();
                if (_docentes == null)
                {
                    _docentes = new CollectionBase<Docente>(docenteDal.GetAll(), new DocenteSqlExecutions(),
                        () =>
                   {
                       return new List<ITrackeable<Docente>>(docenteDal.GetAll()?
                           .Select(x => new UnmodifiedTrackeable<Docente>(x, new NothingSqlExecute<Docente>()))
                           .ToList());
                   });
                }
                return _docentes;
            }
        }



        public void SaveChange()
        {
            Alumnos.Execute();
            Docentes.Execute();
        }
    }
}
