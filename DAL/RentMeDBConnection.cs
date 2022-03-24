using System.Data.SqlClient;

namespace RentMe.DAL
{
    /// <summary>
    /// This class models a connection to 
    /// the RentMe application cs6232-g3 DB.
    /// </summary>
    public static class RentMeDBConnection
    {
        /// <summary>
        /// Get a connection object.
        /// </summary>
        /// <returns>SQLConnection to cs6232-g3 DB</returns>
        public static SqlConnection GetConnection()
        {
            string connectionString =
                    "Data Source=localhost;Initial Catalog=cs6232-g3;" +
                    "Integrated Security=True";


            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
