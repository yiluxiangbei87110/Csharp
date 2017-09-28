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

        //修改用户信息
        public int EditUserInfo(UserInfo userInfo)
        {
            return userInfoDal.EditUserInfo(userInfo);
        }
    }
}
