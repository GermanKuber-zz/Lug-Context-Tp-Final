using System.Collections.Generic;
using System.Data;
using LugTp.Data.Factories;
using LugTp.Entities;

namespace LugTp.Data.Dal
{
    public class CursosDal
    {
        public List<Curso> GetAll()
        {
            var commandText = "SELECT C.Id as Curso_Id, c.Nombre as Curso_Nombre, c.Duracion, p.Id as Persona_Id, p.Nombre,p.Apellido, p.Direccion, p.Telefono, p.Cargo, p.Profesion FROM Cursos c INNER JOIN Personas p ON c.Docente_Id = p.Id";
            var dao = new DAO();
            var dataaSet = dao.ExecuteDataSet(commandText);
            var listOfDocentes = new List<Curso>();


            foreach (DataRow row in dataaSet?.Tables[0].Rows)
            {

                var docente = new Curso(int.Parse(row["Curso_Id"].ToString()),
                    row["Curso_Nombre"].ToString(),
                    int.Parse(row["Duracion"].ToString()),
                    new Docente(int.Parse(row["Persona_Id"].ToString()),
                        row["Nombre"].ToString(),
                        row["Apellido"].ToString(),
                        row["Direccion"].ToString(),
                        row["Telefono"].ToString(),
                        row["Cargo"].ToString(),
                        row["Profesion"].ToString(),
                        new List<Curso>(),
                        new CollectionsDocentesFactory()));
                listOfDocentes.Add(docente);
            }
            return listOfDocentes;
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
                $"UPDATE  Cursos SET Nombre = '{curso.Nombre}', Duracion = {curso.Duracion}, Docente_Id = {curso.Docente.Id}";
         



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
