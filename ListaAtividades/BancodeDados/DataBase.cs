using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividades.BancodeDados
{
    internal class DataBase
    {
        private static readonly string ConnectionString = "datasource=localhost;username=root;password=;database=curso;";

        public static MySqlConnection GetConnection()
        {

            return new MySqlConnection(ConnectionString);

        }
    }
}
