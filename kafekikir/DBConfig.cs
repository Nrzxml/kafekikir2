using MySql.Data.MySqlClient;

namespace kafekikir
{
    public static class DBConfig
    {
        public static string dbServer = "localhost";
        public static string dbUser = "root";
        public static string dbName = "kafe_kikir";
        public static string dbPass = "";

        public static string ConsStr = $"server={dbServer};user={dbUser};database={dbName};password={dbPass}";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConsStr);
        }
    }
}
