using System;
using System.Data.Odbc;

namespace SybaseODBC
{
    class Program
    {
        static void Main()
        {
            string cString =
                "Driver={DataDirect 7.1 Sybase Wire Protocol};server=dvb-mlud-01;database=master;NetworkAddress=dvb-mlud-01,5000;logonid=sa;pwd=Password1;";
            //
            string cStringNotWorking =
                "Driver=Adaptive Server Enterprise;datasource=10.140.126.51;port=5000;uid=sa;pwd=Password1;database=master;";
            
            using (OdbcConnection connection = new OdbcConnection(cStringNotWorking))
            {
                connection.Open();
                Console.WriteLine(connection.State.ToString());
                Console.ReadLine();
            }
        }
    }
}
