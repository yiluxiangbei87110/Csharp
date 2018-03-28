using System;

namespace demo1.model
{
    public class UserInfo
    {
        public int Id { set; get; }
        public string UserName { get; set; }
        public string UserPass { get; set; }
        public DateTime RegTime { get; set; }
    }
}