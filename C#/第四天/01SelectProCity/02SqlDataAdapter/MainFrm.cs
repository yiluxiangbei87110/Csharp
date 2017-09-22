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

namespace _02SqlDataAdapter
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
            //把表中的数据加载到窗体
            string conStr = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                string sql = "select * from dbo.StudentInfo";
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    //把数据填充到dt表中
                    //填充之前不需要打开数据库连接，因为adpter会自动打开并执行sql。
                    adapter.Fill(dt);
                    this.dgvDB1.DataSource = dt;
                }
            }
        }
       
        private void MainFrm_Load(object sender,EventArgs e)
        {
           
        }

        private void dgvDB1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
