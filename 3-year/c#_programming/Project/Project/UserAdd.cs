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

namespace Project
{
    public partial class UserAdd : Form
    {

        String connStr;
        SqlConnection conn;
        SqlCommand cmd;

        public UserAdd()
        {
            InitializeComponent();
        }
        private void UserAdd_Load(object sender, EventArgs e)
        {
            connStr = "Server=localhost\\SQLEXPRESS;Database=LibraryDB;Trusted_Connection=True;";
            conn = new SqlConnection(connStr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "" || tb_id.Text == "" || tb_num.Text == "" || tb_regnum.Text == "" || tb_email.Text == "")
            {
                MessageBox.Show("입력되지 않은 항목이 있습니다.");
                return;
            }

            String name, id, number, info_num, email;
            name = tb_name.Text;
            id = tb_id.Text;
            number = tb_num.Text;
            info_num = tb_regnum.Text;
            email = tb_email.Text;
            // 이름, 아이디, 전화번호, 주민번호, 이메일 [순서]



            // 유저 추가 SQL
            cmd.CommandText = "INSERT INTO user_data VALUES('" + id + "','" + name + "','" + info_num + "','" + number + "','" + email + "')";

            cmd.ExecuteReader();



            MessageBox.Show(name + "님이 회원가입되었습니다.");
            this.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
