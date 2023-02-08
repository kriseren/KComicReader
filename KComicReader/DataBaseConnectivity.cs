﻿
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
        public static MySqlConnection connectionHilo;
        private static string server = "localhost";
        private static string db = "kcomicreader";
        private static string user = "root";
        private static string pass = "";

        //Método que controla que se cree una única instancia de Connection haciendo uso del patrón de diseño del software Singleton..
        public static MySqlConnection getConnection()
        {
            if(connection==null)
            {
                connection = new MySqlConnection("Server=" + server + ";Database=" + db + ";Uid=" + user + ";Pwd=" + pass);
            }
            return connection;
        }

        //Método que controla que se cree una única instancia de Connection para el hilo haciendo uso del patrón de diseño del software Singleton..
        public static MySqlConnection getConnectionHilo()
        {
            if (connectionHilo == null)
            {
                connectionHilo = new MySqlConnection("Server=" + server + ";Database=" + db + ";Uid=" + user + ";Pwd=" + pass);
            }
            return connectionHilo;
        }
    }
}
