using demo1.model;
using Demo1.DAL;
using System;
using System.Collections.Generic;
using System.Data;
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
            List<UserInfo> list = new List<UserInfo>();
            if (dt.Rows.Count>0)
            {
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
    }
}



