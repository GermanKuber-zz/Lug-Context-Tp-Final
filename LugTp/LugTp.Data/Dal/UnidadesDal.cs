using System;
using System.Collections.Generic;
using System.Data;
using LugTp.Data.Factories;
using LugTp.Entities;

namespace LugTp.Data.Dal
{
    public class UnidadesDal
    {
        public List<Unidad> GetAll()
        {
            var commandText = "SELECT * FROM Unidades";
            var dao = new DAO();
            var dataaSet = dao.ExecuteDataSet(commandText);
            var unidades = new List<Unidad>();

            foreach (DataRow row in dataaSet?.Tables[0].Rows)
            {

                var docente = new Unidad(int.Parse(row["Id"].ToString()),
                    row["Tema"].ToString(),
                    row["Descripcion"].ToString(),
                    bool.Parse(row["Selected"].ToString()));
                unidades.Add(docente);
            }
            return unidades;
        }

        public int Update(Unidad entity)
        {

            DAO mDao = new DAO();
            var commandText = "UPDATE  Unidades SET Selected = '" + entity.Selected + "' WHERE ID = '" + entity.Id + "'";


            return mDao.ExecuteNonQuery(commandText);
        }
    }
}

