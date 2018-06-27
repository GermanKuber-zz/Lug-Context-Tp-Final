using System.Collections.Generic;
using System.Data;
using LugTp.Entities;

namespace LugTp.Data.Dal
{
    public class CursosDal
    {
        public List<Curso> GetAll()
        {
            var commandText = "SELECT * FROM Personas WHERE Descriminator = 'Docente'";
            var dao = new DAO();
            var dataaSet = dao.ExecuteDataSet(commandText);
            var listOfDocentes = new List<Curso>();

            foreach (DataRow row in dataaSet?.Tables[0].Rows)
            {

                //var docente = new Curso(int.Parse(row["Id"].ToString()),
                //    row["Nombre"].ToString(),
                //    row["Apellido"].ToString(),
                //    row["Direccion"].ToString(),
                //    row["Telefono"].ToString(),
                //    row["Cargo"].ToString(),
                //    row["Profesion"].ToString());
                //listOfDocentes.Add(docente);
            }
            return listOfDocentes;
        }
        public int Insert(Curso curso)
        {
            DAO mDao = new DAO();
            var commandText = "";
            //var commandText = "INSERT INTO Personas (Nombre, Apellido, Direccion, Telefono,Cargo,Profesion,Descriminator) VALUES" +
            //                  "('" + docente.Nombre + "', " +
            //                  "'" + docente.Apellido + "', " +
            //                  "'" + docente.Direccion + "'," +
            //                  "'" + docente.Telefono + "'," +
            //                  "'" + docente.Cargo + "'," +
            //                  "'" + docente.Profesion + "'," +
            //                  " 'Docente')";

            return mDao.ExecuteNonQuery(commandText);
        }

        public int Update(Curso curso)
        {
            DAO mDao = new DAO();
            //var commandText = "UPDATE  Personas SET Nombre = '" + docente.Nombre + "'," +
            //                  "Apellido = '" + docente.Apellido + "'," +
            //                  "Direccion = '" + docente.Direccion + "'," +
            //                  "Telefono = '" + docente.Telefono + "'," +
            //                  "Cargo = '" + docente.Cargo + "'," +
            //                  "Profesion = '" + docente.Profesion + "'" +
            //                  "WHERE ID = '" + docente.Id + "'";
            var commandText = "";



            return mDao.ExecuteNonQuery(commandText);
        }
        public int Delete(Curso curso)
        {
            DAO mDao = new DAO();
            var commandText = "DELETE Cursos WHERE Id = " + curso.Id;

            return mDao.ExecuteNonQuery(commandText);
        }
    }
}
