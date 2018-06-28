using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using LugTp.Data.Factories;
using LugTp.Entities;
using static System.Tuple;

namespace LugTp.Data.Dal
{
    public class CursosDal
    {
        public List<Curso> GetAll()
        {
            var commandText = "SELECT C.Id as Curso_Id, c.Nombre as Curso_Nombre, u.Selected ,c.Duracion, p.Id as Persona_Id, p.Nombre,p.Apellido, p.Direccion, p.Telefono, p.Cargo, p.Profesion, u.Tema, u.id as Unida_Id, u.Descripcion FROM Cursos c  LEFT JOIN  Personas p ON c.Docente_Id = p.Id LEFT JOIN  Unidades u ON u.Curso_Id= c.Id";
            var dao = new DAO();
            var dataaSet = dao.ExecuteDataSet(commandText);
            var listOfCursos = new List<Curso>();


            var rows = dataaSet?.Tables[0].Rows.Cast<DataRow>().ToList();

            rows.GroupBy(x => x["Curso_Id"])
                .Select(s => Create(s.Key, s.ToList()))
                .ToList()
                .ForEach(row =>
                {

                    var listOfUnidades = new List<Unidad>();
                    row.Item2
                        .ToList()
                        .ForEach(x =>
                        {
                            if (!string.IsNullOrWhiteSpace(x["Tema"].ToString()))
                            {
                                try
                                {
                                    var unidad = new Unidad(int.Parse(x["Unida_Id"].ToString()),
                                        x["Tema"].ToString(),
                                        x["Descripcion"].ToString(),
                                        bool.Parse(x["Selected"].ToString()));
                                    listOfUnidades.Add(unidad);
                                }
                                catch (Exception e)
                                {
                                    throw;
                                    Console.WriteLine(e);
                                }

                            }
                        });

                    var curso = new Curso(int.Parse(row.Item2.First()["Curso_Id"].ToString()),
                        row.Item2.First()["Curso_Nombre"].ToString(),
                        int.Parse(row.Item2.First()["Duracion"].ToString()),
                        new Docente(int.Parse(row.Item2.First()["Persona_Id"].ToString()),
                            row.Item2.First()["Nombre"].ToString(),
                            row.Item2.First()["Apellido"].ToString(),
                            row.Item2.First()["Direccion"].ToString(),
                            row.Item2.First()["Telefono"].ToString(),
                            row.Item2.First()["Cargo"].ToString(),
                            row.Item2.First()["Profesion"].ToString(),
                            new List<Curso>(),
                            new CollectionsDocentesFactory()),
                        listOfUnidades,
                        new CollectionsUnidadesFactory());
                    listOfCursos.Add(curso);
                });
            return listOfCursos;
        }
        public int Insert(Curso curso)
        {
            DAO mDao = new DAO();
            var commandText =
                $"INSERT INTO Cursos (Nombre, Duracion, Docente_Id) VALUES ('{curso.Nombre}','{curso.Duracion}','{curso.Docente.Id}')";

            return mDao.ExecuteNonQuery(commandText);
        }

        public int Update(Curso curso)
        {
            DAO mDao = new DAO();
            var commandText =
                $"UPDATE  Cursos SET Nombre = '{curso.Nombre}', Duracion = {curso.Duracion}, Docente_Id = {curso.Docente.Id} WHERE Id = {curso.Id}";




            return mDao.ExecuteNonQuery(commandText);
        }
        public int Delete(Curso curso)
        {
            DAO mDao = new DAO();
            var commandText = "DELETE Cursos WHERE Id = " + curso.Id;

            return mDao.ExecuteNonQuery(commandText);
        }
        public int Delete(int alumnoId, Curso curso)
        {
            DAO mDao = new DAO();
            var commandText = $"DELETE Curso_Alumno WHERE Alumno_Id = {alumnoId} AND Curso_Id = {curso.Id}";

            return mDao.ExecuteNonQuery(commandText);
        }
        public int Insert(int alumnoId, Curso curso)
        {
            DAO mDao = new DAO();
            var commandText = $"INSERT INTO Curso_Alumno (Alumno_Id, Curso_Id) VALUES ('{alumnoId}', '{curso.Id}')";

            return mDao.ExecuteNonQuery(commandText);
        }
    }
}
