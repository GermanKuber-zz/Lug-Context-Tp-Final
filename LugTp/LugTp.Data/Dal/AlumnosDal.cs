using System.Collections.Generic;
using System.Data;
using LugTp.Entities;

namespace LugTp.Data.Dal
{
    public class AlumnosDal
    {
        public List<Alumno> GetAll()
        {
            var commandText = "SELECT * FROM Personas WHERE Descriminator = 'Alumno'";
            var dao = new DAO();
            var dataaSet = dao.ExecuteDataSet(commandText);
            var listOfAlumnos = new List<Alumno>();

            foreach (DataRow row in dataaSet?.Tables[0].Rows)
            {

                var alumno = new Alumno(int.Parse(row["Id"].ToString()),
                    row["Nombre"].ToString(),
                    row["Apellido"].ToString(),
                    row["Direccion"].ToString(),
                    row["Telefono"].ToString(),
                    row["Legajo"].ToString(),
                    bool.Parse(row["CuotaAlDia"].ToString()));
                listOfAlumnos.Add(alumno);
            }
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
