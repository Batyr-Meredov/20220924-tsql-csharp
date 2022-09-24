using System;
using System.IO;
using System.Data.SqlClient;

namespace tsql_csharp
{ 
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo file = new FileInfo("sql/query/get_top1_users.sql");
            string script = file.OpenText().ReadToEnd();

            // string sqlConnectionString = "Data Source=db-1;Initial Catalog=spt_monitor;Integrated Security=True";
            SqlConnection SQLConnection = new SqlConnection();
            SQLConnection.ConnectionString = "Data Source=596dd79854b5;Initial Catalog=master;User id=sa;Password=P@ssw0rd;";

            SqlCommand CmdName = SQLConnection.CreateCommand();
            CmdName.CommandText = script;

            SQLConnection.Open();
            // string[] UserName = (string[])CmdName.ExecuteScalar();
            using (SqlDataReader reader = CmdName.ExecuteReader())
            {
            while (reader.Read())
                {
                string firstName = (string) reader["FirstName"];
                string lastName = (string) reader["LastName"];
                Console.WriteLine($"We have {firstName} {lastName} aboard!");
                }
            }

            SQLConnection.Close();

            // Console.WriteLine("Username: {0}", UserName[1]);
        }
    }
}
