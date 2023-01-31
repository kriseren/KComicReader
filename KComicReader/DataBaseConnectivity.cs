
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KComicReader
{
    internal class DataBaseConnectivity
    {
        public static MySqlConnection connection;
        private static string server = "localhost";
        private static string db = "kcomicreader";
        private static string user = "root";
        private static string pass = "";

        public static MySqlConnection getConnection()
        {
            if(connection==null)
            {
                connection = new MySqlConnection("Server=" + server + ";Database=" + db + ";Uid=" + user + ";Pwd=" + pass);
            }
            return connection;
        }
    }
}
