using System.Data.Common;

namespace Abstract
{
    class MySqlDatabase : Database
    {
        public override DbConnection Connection { get; set; }

        public MySqlDatabase()
        {
            Connection = new SqlConnection();
        }
    }
}





