using System.Configuration;

namespace PMCLibrary.Helper
{
    internal class DbHelper
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        }
    }
}