using System.Configuration;

namespace Dal
{
    class DbConnection
    {
        public static string LivesqlConnection()
        {
            return ConfigurationManager.AppSettings["ConnectionString"];
        }
    }
}
