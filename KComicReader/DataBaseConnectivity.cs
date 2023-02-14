
using MySql.Data.MySqlClient;

namespace KComicReader
{
    /// <summary>
    /// Clase que implementa la funcionalidad de la conexión a la base de datos.
    /// </summary>
    internal class DataBaseConnectivity
    {
        /// <summary>
        /// El objeto que representa la conexión a la base de datos.
        /// </summary>
        private static MySqlConnection connection;

        /// <summary>
        /// La dirección IP del servidor de la base de datos al que se realiza la conexión.
        /// </summary>
        private static string server = "localhost";

        /// <summary>
        /// El nombre de la base de datos a la que se realiza la conexión.
        /// </summary>
        private static string db = "kcomicreader";
        private static string user = "root";
        private static string pass = "";

        /// <summary>
        /// Método que controla que se cree una única instancia de Connection haciendo uso del patrón de diseño del software Singleton
        /// </summary>
        /// <returns>El objeto que representa la conexión con la base de datos.</returns>
        public static MySqlConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new MySqlConnection("Server=" + server + ";Database=" + db + ";Uid=" + user + ";Pwd=" + pass);
            }
            return connection;
        }
    }
}
