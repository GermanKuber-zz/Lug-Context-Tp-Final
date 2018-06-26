using System.Collections.Generic;
using System.Data;
using LugTp.Entities;

namespace LugTp.Data.Dal
{
    public class DocentesDal
    {
        public List<Docente> GetAll()
        {
            var commandText = "SELECT * FROM Personas WHERE Descriminator = 'Docente'";
            var dao = new DAO();
            var dataaSet = dao.ExecuteDataSet(commandText);
            var listOfDocentes = new List<Docente>();

            foreach (DataRow row in dataaSet?.Tables[0].Rows)
            {

                var docente = new Docente(int.Parse(row["Id"].ToString()),
                    row["Nombre"].ToString(),
                    row["Apellido"].ToString(),
                    row["Direccion"].ToString(),
                    row["Telefono"].ToString(),
                    row["Cargo"].ToString(),
                    row["Profesion"].ToString());
                listOfDocentes.Add(docente);
            }
            return listOfDocentes;
        }
        public int Insert(Docente docente)
        {
            DAO mDao = new DAO();
            var commandText = "INSERT INTO Personas (Nombre, Apellido, Direccion, Telefono,Cargo,Profesion,Descriminator) VALUES" +
                              "('" + docente.Nombre + "', " +
                              "'" + docente.Apellido + "', " +
                              "'" + docente.Direccion + "'," +
                              "'" + docente.Telefono + "'," +
                              "'" + docente.Cargo + "'," +
                              "'" + docente.Profesion + "'," +
                              " 'Docente')";

            return mDao.ExecuteNonQuery(commandText);
        }

        public int Update(Docente docente)
        {
            DAO mDao = new DAO();
            var commandText = "UPDATE  Personas SET Nombre = '" + docente.Nombre + "'," +
                              "Apellido = '" + docente.Apellido + "'," +
                              "Direccion = '" + docente.Direccion + "'," +
                              "Telefono = '" + docente.Telefono + "'," +
                              "Cargo = '" + docente.Cargo + "'," +
                              "Profesion = '" + docente.Profesion + "'" +
                              "WHERE ID = '" + docente.Id + "'";



            return mDao.ExecuteNonQuery(commandText);
        }
        public int Delete(Docente docente)
        {
            DAO mDao = new DAO();
            var commandText = "DELETE Personas WHERE Id = " + docente.Id;

            return mDao.ExecuteNonQuery(commandText);
        }
    }
}
