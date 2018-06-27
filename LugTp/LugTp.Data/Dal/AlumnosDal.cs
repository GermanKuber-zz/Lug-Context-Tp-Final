using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using LugTp.Data.SqlExecute.AlumnoCurso;
using LugTp.Entities;

namespace LugTp.Data.Dal
{
    public class AlumnosDal
    {
        public List<Alumno> GetAll()
        {
            var commandText = "SELECT P.Id,P.Nombre, Apellido, Direccion, Telefono, Legajo, CuotaAlDia, Curso_Id, C.Nombre as Curso_Nombre, Duracion  FROM Personas P LEFT JOIN Curso_Alumno CA ON CA.Alumno_Id = P.Id LEFT JOIN Cursos C ON C.Id = CA.Curso_Id  WHERE Descriminator = 'Alumno'";
            var dao = new DAO();
            var dataaSet = dao.ExecuteDataSet(commandText);
            var listOfAlumnos = new List<Alumno>();

            var rows = dataaSet?.Tables[0].Rows.Cast<DataRow>().ToList();

            rows.GroupBy(x => x["Nombre"])
                .Select(s => Tuple.Create(s.Key, s.ToList()))
                .ToList()
                .ForEach(row =>
                {

                    var listOfCursos = new List<Curso>();
                    row.Item2
                       .ToList()
                       .ForEach(x =>
                        {
                            if (!string.IsNullOrWhiteSpace(x["Curso_Id"].ToString()))
                            {
                                var curso = new Curso(int.Parse(x["Curso_Id"].ToString()),
                                        x["Curso_Nombre"].ToString(),
                                        int.Parse(x["Duracion"].ToString()),
                                        null);
                                listOfCursos.Add(curso);
                            }
                        });

                    var cursosBase = new CollectionBase<Curso>(listOfCursos, new AlumnoCursoSqlExecutions(int.Parse(row.Item2.First()["Id"].ToString())));
                    var alumno = new Alumno(int.Parse(row.Item2.First()["Id"].ToString()),
                        row.Item2.First()["Nombre"].ToString(),
                        row.Item2.First()["Apellido"].ToString(),
                        row.Item2.First()["Direccion"].ToString(),
                        row.Item2.First()["Telefono"].ToString(),
                        row.Item2.First()["Legajo"].ToString(),
                        bool.Parse(row.Item2.First()["CuotaAlDia"].ToString()),
                        cursosBase);

                    listOfAlumnos.Add(alumno);
                });
            return listOfAlumnos;
        }
        public int Insert(Alumno alumno)
        {
            DAO mDao = new DAO();
            var commandText = "INSERT INTO Personas (Nombre, Apellido, Direccion, Telefono,Legajo,CuotaAlDia,Descriminator) VALUES" +
                              "('" + alumno.Nombre + "', " +
                              "'" + alumno.Apellido + "', " +
                              "'" + alumno.Direccion + "'," +
                              "'" + alumno.Telefono + "'," +
                              "'" + alumno.Legajo + "'," +
                              "'" + alumno.CuotaAlDia + "'," +
                              " 'Alumno')";

            return mDao.ExecuteNonQuery(commandText);
        }

        public int Update(Alumno alumno)
        {
            DAO mDao = new DAO();
            var commandText = "UPDATE  Personas SET Nombre = '" + alumno.Nombre + "'," +
                              "Apellido = '" + alumno.Apellido + "'," +
                              "Direccion = '" + alumno.Direccion + "'," +
                              "Telefono = '" + alumno.Telefono + "'," +
                              "Legajo = '" + alumno.Legajo + "'," +
                              "CuotaAlDia = '" + alumno.CuotaAlDia + "'" +
                              "WHERE ID = '" + alumno.Id + "'";


            return mDao.ExecuteNonQuery(commandText);
        }
        public int Delete(Alumno alumno)
        {
            DAO mDao = new DAO();
            var commandText = "DELETE Personas WHERE Id = " + alumno.Id;

            return mDao.ExecuteNonQuery(commandText);
        }


    }
}
