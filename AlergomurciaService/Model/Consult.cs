using AlergomurciaService.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlergomurciaService.Model
{
    public static class Consult
    {
        public static DbDataReader returnData(string query)
        {
            Database database;

            database = new SqlServerDatabase();
            DbCommand command = database.Command;
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection.Open();
            DbDataReader dr = command.ExecuteReader(CommandBehavior.CloseConnection);

            return dr;
        }

    }
}
