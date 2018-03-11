using demo1.model;
using Demo1.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1.dal
{
    public class UserInfoDAL
    {
        public List<UserInfo> GetList()
        {
            string sql = "select * from UserInfo";
            DataTable dt=SqlHelper.GetDataTable(sql,CommandType.Text);
            List<UserInfo> list = null;
            if (dt.Rows.Count>0)
            {
                list = new List<UserInfo>();
                UserInfo userInfo = null;
                foreach (DataRow row in dt.Rows)
                {
                    userInfo = new UserInfo();
                    LoadEntity(userInfo, row);
                    list.Add(userInfo);
                }
            }
            return list;
        }
        //行中的数据赋给userinfo的属性
        private void LoadEntity(UserInfo userInfo,DataRow row)
        {
            userInfo.UserName = row["UserName"] != DBNull.Value ? row["UserName"].ToString() : string.Empty;
            userInfo.UserPass = row["UserPass"] != DBNull.Value ? row["UserPass"].ToString() : string.Empty;
            userInfo.Id = Convert.ToInt32(row["ID"]);
            userInfo.RegTime = Convert.ToDateTime(row["RegTime"]);
        }

        //增加用户的信息
        public int AddUserInfo(UserInfo userInfo)
        {
            string sql = "insert into UserInfo(UserName,UserPass,RegTime)values(@UserName,@UserPass,@RegTime)";
            SqlParameter[] pares = {
                new SqlParameter("@UserName",SqlDbType.NVarChar,32),
                new SqlParameter("@UserPass",SqlDbType.NVarChar,32),
                 new SqlParameter("@RegTime",SqlDbType.DateTime)
            };
            pares[0].Value = userInfo.UserName;
            pares[1].Value = userInfo.UserPass;
            pares[2].Value = userInfo.RegTime;
            return SqlHelper.ExecuteNonquery(sql, CommandType.Text, pares);
        }
        //根据id删除用户的信息
        public int DeleteUser(int id)
        {
            string sql = "delete from UserInfo where id=@id";
            SqlParameter[] pars =
            {
                new SqlParameter("@id",SqlDbType.Int)
            };
            pars[0].Value = id;
            return SqlHelper.ExecuteNonquery(sql, CommandType.Text, pars);

        }

        //详细信息 根据id获取用户详细信息
        public UserInfo GetUserInfo(int id)
        {
            string sql = "select * from UserInfo where id=@id";
            SqlParameter[] para = {
                new SqlParameter("@id",SqlDbType.Int)
            };
            para[0].Value = id;
            DataTable dt=SqlHelper.GetDataTable(sql, CommandType.Text, para);
            UserInfo userInfo = null;
            if (dt.Rows.Count > 0)
            {
                userInfo = new UserInfo();
                LoadEntity(userInfo,dt.Rows[0]);
            }
            return userInfo;
        }

        //修改用户信息
        public int EditUserInfo(UserInfo userInof)
        {
            string sql = "update UserInfo set UserName=@UserName,UserPass=@UserPass where id=@id";
            SqlParameter[] pars = {
                new SqlParameter("@id",SqlDbType.Int),
                 new SqlParameter("@UserName",SqlDbType.NVarChar,32),
                new SqlParameter("@UserPass",SqlDbType.NVarChar,32)
                 //new SqlParameter("@RegTime",SqlDbType.DateTime)
            };
            pars[0].Value = userInof.Id;
            pars[1].Value = userInof.UserName;
            pars[2].Value = userInof.UserPass;
            return SqlHelper.ExecuteNonquery(sql, CommandType.Text, pars);
        }

        //分页查询
        public List<UserInfo> GetPageList(int start,int end)
        {
            string sql = "select * from(select *,row_number() over(order by id) as number from UserInfo) as t where t.num>=@start and t.name<=@end )";
            SqlParameter[] paras =
            {
                new SqlParameter("@start",SqlDbType.Int),
                new SqlParameter("@end",SqlDbType.Int)
            };
            paras[0].Value = start;
            paras[1].Value = end;
            DataTable dt = SqlHelper.GetDataTable(sql, CommandType.Text, paras);
            List<UserInfo> list = null;
            if (dt.Rows.Count > 0)
            {
                list = new List<UserInfo>();
                UserInfo userInfo = null;
                foreach (DataRow row in dt.Rows)
                {
                    userInfo = new UserInfo();
                    LoadEntity(userInfo, row);
                    list.Add(userInfo);
                }
            }
            return list;
        }

        //获取总的记录数
        public int getRecordCount()
        {
            string sql = "select count(*) from userInfo";
            return Convert.ToInt32(SqlHelper.ExecuteScalar(sql, CommandType.Text));
        }
    }
}



