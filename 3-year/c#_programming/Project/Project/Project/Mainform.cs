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
    public partial class Mainform : Form
    {

        String connStr;
        SqlConnection conn;
        SqlCommand cmd;

        public Mainform()
        {
            InitializeComponent();
        }


        private void Mainform_Load(object sender, EventArgs e)
        {
            connStr = "Server=localhost\\SQLEXPRESS;Database=LibraryDB;Trusted_Connection=True;";
            conn = new SqlConnection(connStr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (user.Checked)
            {
                if (user_id.Text == "") {
                    MessageBox.Show("아이디를 입력하세요.");
                    return;
                }

                // ID 검증 SQL
                cmd.CommandText = "SELECT CASE WHEN user_id = '" + user_id.Text + "' THEN 1 ELSE 0 END AS checkID FROM user_data where user_id = '" + user_id.Text + "'";
                cmd.ExecuteNonQuery();
                int result;
                try {
                    result = (int)cmd.ExecuteScalar(); // 받는 값이 있으면 1 반환 , 없으면 에러 

                    // 1일 때만 정상 작동 에러라면 catch로 이동
                    User subForm = new User(user_id.Text);
                    subForm.ShowDialog();

                } catch(NullReferenceException) {
                    result = 0;
                    MessageBox.Show("아이디가 없습니다.");
                }
            }
            else
            {
                Manager subForm = new Manager();
                subForm.ShowDialog();
            }
            
        }

        private void user_CheckedChanged(object sender, EventArgs e)
        {
            id_text.Enabled = true;
            user_id.Enabled = true;
        }

        private void developer_CheckedChanged(object sender, EventArgs e)
        {
            id_text.Enabled = false;
            user_id.Enabled = false;
        }

    }
}
