using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlConnection;

namespace SqlConnectionC
{
    class Program
    {
        static void Main(string[] args)
        {
            //01 连接数据库
            //#region
            //链接数据库 uid用户名 pwd 密码
            //string connStr = "server=127.0.0.1;uid=sa;pwd=123456;database=DB1";
            //SqlConnection con = new SqlConnection(connStr);

            //con.Open();
            //Console.WriteLine("数据库打开");
            //con.Close();
            //con.Dispose();
            //#endregion

            //02写入数据库内容
            #region
            //一般为了处理异常，我们将使用try catch finally。现在我们使用using
            //1.创建对象，连接数据库
            //我们最好是从配置文件拿，方便移植
            //string conStr = "Server=(local);uid=sa;pwd=123456;database=DB1";
            string conStr = ConnectStringHelper.GetCurrentString();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                //创建一个sql命令对象
                using (SqlCommand cmd = new SqlCommand())
                {
                    //执行命令前打开open命令
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into dbo.category(catName,parentCatId,delFlag)values('chicken',1,0)";
                    //执行非查询语句，返回受影响的行数
                    cmd.ExecuteNonQuery();
                    con.Close();
                    #endregion
                    Console.ReadKey();
                }
            }
        }
    }
}
