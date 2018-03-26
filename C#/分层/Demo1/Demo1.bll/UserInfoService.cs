using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo1.model;
using Demo1.dal;

namespace Demo1.bll
{
  
   public  class UserInfoService
    {
        UserInfoDAL userInfoDal = new UserInfoDAL();
        
        //返回用户列表
        public List<UserInfo> GetList2()
        {
            return userInfoDal.GetList();
        }

        //添加用户信息
        public bool AddUserInfo(UserInfo userInfo)
        {
            return userInfoDal.AddUserInfo(userInfo)>0;
        }

        //删除用户信息

        public bool DeleteUser(int id)
        {
            return userInfoDal.DeleteUser(id)>0;
        }

        //查看信息 通过id
        public UserInfo GetUserInfo(int id)
        {
            return userInfoDal.GetUserInfo(id);
        }

        //查看信息 通过用户名
        public UserInfo GetUserInfo(string username)
        {
            return userInfoDal.GetUserInfo(username);
        }

        //修改用户信息
        public int EditUserInfo(UserInfo userInfo)
        {
            return userInfoDal.EditUserInfo(userInfo);
        }

        //分页查询
        /// <param name="pageIndex">当前页码</param>
        /// <param name="pageSize">每页显示的数据</param>
        /// <returns></returns>
       public List<UserInfo> GetPageList(int pageIndex, int pageSize)
        {
            int start = (pageIndex - 1) * pageSize + 1;
            int end = pageSize * pageIndex;
            return userInfoDal.GetPageList(start, end);
        }

        //获取总的页数
        public int GetPageCount(int pageSize)
        {
            int recordCount = userInfoDal.getRecordCount();
            int pageCount = Convert.ToInt32(Math.Ceiling((double)recordCount / pageSize));
            return pageCount;
        }

        //校验用户名和密码
        public bool ValidateUseInfo(string name, string password, out string msg,out UserInfo userInfo)
        {
           userInfo=userInfoDal.GetUserInfo(name);
            if (userInfo != null)
            {
                if (userInfo.UserPass == password)
                {
                    msg = "登录成功";
                    return true;
                }else
                {
                    msg = "密码错误";
                    return false;
                }
            }else
            {
                msg = "没有此用户！！";
                return false;
            }


        }

    }
}
