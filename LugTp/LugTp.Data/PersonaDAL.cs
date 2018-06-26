using System.Collections.Generic;
using System.Data;
using LugTp.Entities;

namespace LugTp.Data
{
    public class DocenteDal
    {

        public List<Docente> GetAll()
        {
            var commandText = "SELECT * FROM Personas WHERE Descriminator = 'Docente'";

            var dao = new DAO();

            var dataaSet = dao.ExecuteDataSet(commandText);
            var listOfDocentes = new List<Docente>();

            foreach (DataRow row in dataaSet?.Tables[0].Rows)
            {

                var docente = new Docente(row["Nombre"].ToString(),
                    row["Apellido"].ToString(),
                    row["Direccion"].ToString(),
                    row["Telefono"].ToString(),
                    row["Cargo"].ToString(),
                    row["Profesion"].ToString());
                listOfDocentes.Add(docente);
            }
            return listOfDocentes;
        }

        //public static int Guardar(PersonaDTO pPersona)
        //{
        //    if (pPersona.Id == 0)
        //    {
        //        pPersona.Id = ProximoId();
        //        string mCommandText = "INSERT INTO Persona (Persona_Id, Persona_Nombre, Persona_Apellido, Persona_Documento) VALUES (" + pPersona.Id + ", '" + pPersona.Nombre + "', '" + pPersona.Apellido + "', '" + pPersona.Documento + "')";
        //        DAO mDao = new DAO();
        //        return mDao.ExecuteNonQuery(mCommandText);
        //    }
        //    else
        //    {
        //        string mCommandText = "UPDATE Persona SET Persona_Nombre = '" + pPersona.Nombre + "', Persona_Apellido = '" + pPersona.Apellido + "', Persona_Documento = '" + pPersona.Documento + "' WHERE Persona_Id = " + pPersona.Id;
        //        DAO mDao = new DAO();
        //        return mDao.ExecuteNonQuery(mCommandText);
        //    }

        //}

        //public static int Eliminar(PersonaDTO pPersona)
        //{
        //    string mCommandText = "DELETE Persona WHERE Persona_Id = " + pPersona.Id;
        //    DAO mDao = new DAO();
        //    return mDao.ExecuteNonQuery(mCommandText);
        //}

        //public static PersonaDTO Obtener(int pId)
        //{
        //    string mCommandText = "SELECT Persona_Id, Persona_Nombre, Persona_Apellido, Persona_Documento FROM Persona WHERE Persona_Id = " + pId;

        //    DAO mDAO = new DAO();

        //    DataSet mDs = mDAO.ExecuteDataSet(mCommandText);

        //    if (mDs.Tables.Count > 0 && mDs.Tables[0].Rows.Count > 0)
        //    {
        //        PersonaDTO mPersona = new PersonaDTO(pId);
        //        ValorizarEntidad(mPersona, mDs.Tables[0].Rows[0]);
        //        return mPersona;
        //    }
        //    else
        //    {
        //        return null;
        //    }

        //}

        //public static List<PersonaDTO> Listar()
        //{
        //    string mCommandText = "SELECT Persona_Id, Persona_Nombre, Persona_Apellido, Persona_Documento FROM Persona";

        //    DAO mDAO = new DAO();

        //    DataSet mDs = mDAO.ExecuteDataSet(mCommandText);
        //    List<PersonaDTO> mPersonas = new List<PersonaDTO>();

        //    if (mDs.Tables.Count > 0 && mDs.Tables[0].Rows.Count > 0)
        //    {
        //        foreach (DataRow mDr in mDs.Tables[0].Rows)
        //        {
        //            PersonaDTO mPersona = new PersonaDTO(int.Parse(mDr["Persona_Id"].ToString()));
        //            ValorizarEntidad(mPersona, mDr);
        //            mPersonas.Add(mPersona);
        //        }

        //    }
        //    return mPersonas;
        //}

        //private static void ValorizarEntidad(PersonaDTO pPersona, DataRow pDataRow)
        //{
        //    pPersona.Nombre = pDataRow["Persona_Nombre"].ToString();
        //    pPersona.Apellido = pDataRow["Persona_Apellido"].ToString();
        //    pPersona.Documento = pDataRow["Persona_Documento"].ToString();
        //}

    }
}
