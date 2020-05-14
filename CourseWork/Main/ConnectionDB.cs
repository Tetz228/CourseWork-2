using System.Data.SqlClient;

namespace CourseWork
{
    class ConnectionDB
    {
        SqlConnection connection_string = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Projects; Integrated Security = True;");

        public void OpenConnect()
        {
            if (connection_string.State == System.Data.ConnectionState.Closed)
                connection_string.Open();
        }

        public void CloseConnect()
        {
            if (connection_string.State == System.Data.ConnectionState.Open)
                connection_string.Close();
        }

        public SqlConnection GetSqlConnect()
        {
            return connection_string;
        }
    }
}
