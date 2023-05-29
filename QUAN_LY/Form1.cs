using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUAN_LY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void ShowData(string tenBang)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = "Data Source=NGUYET_DUONG\\SQLEXPRESS03;Initial Catalog=BTL_QLNHAHANG;Persist Security Info=True;User ID=sa;Password=123456";
            cnn.Open();

            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from {tenBang}";
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }

        private void btn_ShowData_Click(object sender, EventArgs e)
        {
            ShowData("HOA_DON");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowData("TT_KHACHHANG");
        }

        private void Show3_Click(object sender, EventArgs e)
        {
            ShowData("TT_NHANVIEN");
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            ShowData("TT_MONAN");
        }
    }
}
