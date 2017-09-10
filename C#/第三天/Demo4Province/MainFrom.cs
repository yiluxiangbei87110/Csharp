using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo4Province
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
        }
        private void MainFrm_Load(Object sender, EventArgs e)
        {
            //加载数据库中的所有的省的数据
            string conStr = ConfigurationManager.ConnectionStrings["sqlCon"].ConnectionString;
            using (SqlConnection con=new SqlConnection(conStr))
            {
                using (SqlCommand cmd=new SqlCommand())
                {
                    con.Open();
                    cmd.CommandText =@"select AreaId ,AreaName,AreaPid from dbo.AreaFull where AreaPid =0";
                    using (SqlDataReader reader=cmd.ExecuteReader())
                    {
                       while (reader.Read())
                        {
                            //int AreaId = int.Parse(reader["AreaId"].ToString());
                            //想把所有的信息扔进去，我们采用下面的方法
                            AreaIfo areaInfo = new AreaIfo();
                            areaInfo.AreaId = int.Parse(reader["AreaId"].ToString());
                            areaInfo.AreaName = reader["AreaName"].ToString();
                            areaInfo.AreaPid = int.Parse(reader["AreaPid"].ToString());
                            this.cbxCity.Items.Add(areaInfo);
                        }
                      
                    }
                }
            }
        }

        private void cbxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
