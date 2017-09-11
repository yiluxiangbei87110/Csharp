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

namespace _01SelectProCity
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender,EventArgs e)
        {
            //加载数据库中的省份 connectionstring 为什么大写
            string conStr = ConfigurationManager.ConnectionStrings["sqlCon"].ConnectionString;
            using(SqlConnection conn=new SqlConnection(conStr))
            {
                using(SqlCommand cmd=new SqlCommand())
                {
                    conn.Open();
                    cmd.CommandText = "select AreaId,AreaName,AreaPid from dbo.AreaFull where AreaPid=0";
                    using (SqlDataReader reader=cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // int AreaId = int.Parse(reader["AreaId"].ToString());
                            AreaInfo areaInfo = new AreaInfo();
                            areaInfo.AreaId = int.Parse(reader["AreaId"].ToString());
                            areaInfo.AreaPid = int.Parse(reader["AreaPid"].ToString());
                            areaInfo.AreaName = reader["AreaName"].ToString();
                            this.cbxProvince.Items.Add(areaInfo);
                        }
                    }
                }
            }
        }
    }
}
