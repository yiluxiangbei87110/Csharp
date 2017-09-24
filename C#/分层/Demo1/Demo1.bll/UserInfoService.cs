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
        public List<UserInfo> GetList2()
        {
            return userInfoDal.GetList();
        }
    }
}
