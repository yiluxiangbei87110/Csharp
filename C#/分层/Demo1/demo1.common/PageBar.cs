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
            end = end > pageCount ? pageCount : end;
            StringBuilder sb = new StringBuilder();
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
            return sb.ToString();
        }
    }
}
