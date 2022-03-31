using MySqlConnector;
using MySql.Data.MySqlClient;

namespace FirstDataBaseConsoleApp
{
    public class DataBaseInfo
    {
        public MySql.Data.MySqlClient.MySqlConnection con { get; set; }
        public DataBaseInfo()
        {
            con = new MySql.Data.MySqlClient.MySqlConnection
            {
                ConnectionString = "SERVER= sql11.freemysqlhosting.net;PORT=3306;DATABASE=sql11482763;UID=sql11482763;PASSWORD=4eMXmQDWdU"
            };
        }
    }
}
