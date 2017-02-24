using System;
using System.Data.SqlClient;

namespace Databaza
{
    class Program
    {
        static void Main()
        {
            string query = "select * from APM_Application";
            using (SqlConnection connection = new SqlConnection("user id=sa;password=Password1;server=localhost;trusted_connection=yes;database=SolarWindsOrion;"))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query,connection);
                var myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    for (int i = 0; i < myreader.FieldCount; i++)
                    {
                        Console.WriteLine(myreader[i]);
                    }
                }

                Console.WriteLine("Connection Open.");

                connection.Close();
                Console.ReadLine();
            }
            
       
        }
    }
}
