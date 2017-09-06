using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace sqlConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStr = "server=127.0.0.1;uid=sa;pwd=123456,database=DB1";
            SqlConnection con = new SqlConnection(connStr);

            con.Open();
            Console.WriteLine("数据库打开");
            con.Close();
            con.Dispose();
            Console.ReadKey();
        }
    }
}
