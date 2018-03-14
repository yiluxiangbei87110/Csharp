using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1.common
{
    public class PageBar
    {
        public static string GetpageBar(int pageIndex,int pageCount)
        {
            if (pageCount == 1)
            {
                return string.Empty;
            }
            int start = pageIndex - 5;
            start=start < 1 ? 1 : start;

            int end = pageIndex + 9;
            if (end > pageCount)
            {
                end = pageCount;
                //end 固定后，长度不变
                start = end - 9 <1 ?   1: end - 9;
            }
            end = end > pageCount ? pageCount : end;
            StringBuilder sb = new StringBuilder();
            if (pageIndex > 1)
            {
                sb.AppendFormat("<a href='UserInfoAsp.aspx?pageIndex={0}'>上一页</a>", pageIndex - 1);
            }
            for(int i = start; i <=end; i++)
            {
                if (pageIndex == i)
                {
                    sb.Append(i);
                }else
                {
                    sb.AppendFormat("<a href='UserInfoAsp.aspx?pageIndex={0}'>{0}</a>", i);
                }
            }
            if (pageIndex < pageCount)
            {
                sb.AppendFormat("<a href='UserInfoAsp.aspx?pageIndex={0}'>下一页</a>", pageIndex + 1);

            }
            return sb.ToString();
        }
    }
}
